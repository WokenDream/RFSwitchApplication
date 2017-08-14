using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Runtime.InteropServices;
using FT_HANDLE = System.UInt32;

namespace DLP2232M_G
{
    public enum Channel : byte
    {
        A,
        B
    }

    public static class DLP2232M
    {
        private const string ChannelA = "DLP232M A";
        private const string ChannelB = "DLP232M B";
        
        public static unsafe void SetBitBangMode(Channel ChannelEnum, byte VoltMask, byte NumOfAttempts = 10)
        {
            // error checking
            if (ChannelEnum > Channel.B)
            {
                throw new Exception("Invalid Channel: " + ChannelEnum);
            }

            string ChannelStr = ChannelEnum == Channel.A ? ChannelA : ChannelB;

            if (NumOfAttempts < 2)
            {
                NumOfAttempts = 2;
            }

            UInt32 NumDevs;
            FT.ListDevices(&NumDevs, null, FT.FT_LIST_NUMBER_ONLY); // get number of devices connected
            if (NumDevs == 0)
            {
                throw new Exception("No USB interface is attached");
            }

            // 
            byte[] DataSet = { 0 };
            DataSet[0] = VoltMask;
            byte[] DataRead = { 0 };

            for (UInt32 i = 0; i < NumDevs; ++i) //find the correct channel for the chip
            {
                byte[] DevName = new byte[64];
                fixed (byte* dev_name = DevName, data_set = DataSet, data_read = DataRead)
                {
                    FT.ListDevices(i, dev_name, FT.FT_LIST_BY_INDEX | FT.FT_OPEN_BY_DESCRIPTION); //get the description of current device
                    System.Text.ASCIIEncoding Enc = new System.Text.ASCIIEncoding();
                    string DevInfo = Enc.GetString(DevName, 0, DevName.Length).Trim('\0');
                    if (!DevInfo.Equals(ChannelStr))
                    {
                        continue;
                    }

                    SetMask(dev_name, VoltMask, data_read, data_set, NumOfAttempts);

                }
            }
        }

        private static unsafe void SetMask(byte* dev_name, byte VoltMask, byte* data_read, byte* data_set, byte NumOfAttempts)
        {
            const byte Enable = 0x01;
            const byte Mask = 0xff; // all 8 pins set to output
            FT_HANDLE ftHandle = 0;
            byte attempt = 0;

            do
            {
                Console.WriteLine("attempt: {0}", attempt);
                FT.OpenEx(dev_name, FT.FT_OPEN_BY_DESCRIPTION, ref ftHandle); //open device by description
                FT.SetBitMode(ftHandle, Mask, Enable); //enter Bit Bang mode, and set all the 8 pins to output
                System.Threading.Thread.Sleep(50);

                FT_HANDLE NumByteWritten = 2, NumByteRead = 2;
                FT.Write(ftHandle, data_set, 1, ref NumByteWritten); //set voltages on the 8 pins
                System.Threading.Thread.Sleep(50);
                FT.Read(ftHandle, data_read, 1, ref NumByteRead); //read volts back from pins
                FT.Close(ftHandle);
                ++attempt;

            } while (data_read[0] != data_set[0] && attempt < NumOfAttempts);

            if (data_read[0] != data_set[0])
            {
                throw new Exception("Unable to set voltages. Please check the connection of the USB interface.");
            }
        }
    }
}
