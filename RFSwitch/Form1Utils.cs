using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFSwitch
{
    public partial class Form1
    {
        private void EnableApplyButtons(bool Enable)
        {
            buttonA.Enabled = Enable;
            buttonB.Enabled = Enable;
        }

        private void button1_Click()
        {
            RFSwitch.ChannelA_Apply();
        }

        private void button2_Click()
        {
            RFSwitch.ChannelB_Apply();
        }
    }
}
