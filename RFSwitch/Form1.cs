using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1A_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            RFSwitch.ChannelA_EnablePath(1, temp.Checked);
        }

        private void checkBox2A_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            RFSwitch.ChannelA_EnablePath(2, temp.Checked);
        }

        private void checkBox3A_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            RFSwitch.ChannelA_EnablePath(3, temp.Checked);
        }

        private void checkBox4A_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            RFSwitch.ChannelA_EnablePath(4, temp.Checked);
        }

        private void checkBox5A_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            RFSwitch.ChannelA_EnablePath(5, temp.Checked);
        }

        private void checkBox6A_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            RFSwitch.ChannelA_EnablePath(6, temp.Checked);
        }

        
        private void checkBox1B_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            RFSwitch.ChannelB_EnablePath(1, temp.Checked);
        }

        private void checkBox2B_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            RFSwitch.ChannelB_EnablePath(2, temp.Checked);
        }

        private void checkBox3B_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            RFSwitch.ChannelB_EnablePath(3, temp.Checked);
        }

        private void checkBox4B_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            RFSwitch.ChannelB_EnablePath(4, temp.Checked);
        }

        private void checkBox5B_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            RFSwitch.ChannelB_EnablePath(5, temp.Checked);
        }

        private void checkBox6B_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            RFSwitch.ChannelB_EnablePath(6, temp.Checked);
        }

        private void button_Click(object sender, EventArgs e)
        {
            EnableApplyButtons(false);
            Button btn = sender as Button;
            try
            {
                if (btn == buttonA)
                {
                    Console.WriteLine("button 1 is clicked");
                    button1_Click();
                }
                else if (btn == buttonB)
                {
                    Console.WriteLine("button 2 is clicked");
                    button2_Click();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            EnableApplyButtons(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
