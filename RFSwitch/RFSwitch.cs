using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLP2232M_G;


namespace RFSwitch
{
    public static class RFSwitch
    {
        private static byte ChannelA_Mask = 0;
        private static byte ChannelB_Mask = 0;

        public static void ChannelA_EnablePath(int path, bool enable)
        {
            // path: 1 ... 6 -> mask: 0 ... 5

            ChannelA_Mask = (byte)(enable ? ChannelA_Mask | (1 << (path - 1)) : ChannelA_Mask & (~(1 << (path - 1))));
        }

        public static void ChannelB_EnablePath(int path, bool enable)
        {
            ChannelB_Mask = (byte)(enable ? ChannelB_Mask | (1 << (path - 1)) : ChannelB_Mask & (~(1 << (path - 1))));
        }

        public static void ChannelA_Apply()
        {
            DLP2232M.SetBitBangMode(Channel.A, ChannelA_Mask);
        }

        public static void ChannelB_Apply()
        {
            DLP2232M.SetBitBangMode(Channel.B, ChannelB_Mask);
        }
    }
}
