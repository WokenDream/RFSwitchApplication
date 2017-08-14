namespace RFSwitch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Channel_B = new System.Windows.Forms.GroupBox();
            this.checkBox1B = new System.Windows.Forms.CheckBox();
            this.checkBox2B = new System.Windows.Forms.CheckBox();
            this.checkBox3B = new System.Windows.Forms.CheckBox();
            this.checkBox4B = new System.Windows.Forms.CheckBox();
            this.checkBox5B = new System.Windows.Forms.CheckBox();
            this.checkBox6B = new System.Windows.Forms.CheckBox();
            this.buttonB = new System.Windows.Forms.Button();
            this.Channel_A = new System.Windows.Forms.GroupBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.checkBox1A = new System.Windows.Forms.CheckBox();
            this.checkBox2A = new System.Windows.Forms.CheckBox();
            this.checkBox3A = new System.Windows.Forms.CheckBox();
            this.checkBox4A = new System.Windows.Forms.CheckBox();
            this.checkBox5A = new System.Windows.Forms.CheckBox();
            this.checkBox6A = new System.Windows.Forms.CheckBox();
            this.Channel_B.SuspendLayout();
            this.Channel_A.SuspendLayout();
            this.SuspendLayout();
            // 
            // Channel_B
            // 
            this.Channel_B.Controls.Add(this.buttonB);
            this.Channel_B.Controls.Add(this.checkBox1B);
            this.Channel_B.Controls.Add(this.checkBox2B);
            this.Channel_B.Controls.Add(this.checkBox3B);
            this.Channel_B.Controls.Add(this.checkBox4B);
            this.Channel_B.Controls.Add(this.checkBox5B);
            this.Channel_B.Controls.Add(this.checkBox6B);
            this.Channel_B.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Channel_B.Location = new System.Drawing.Point(0, 232);
            this.Channel_B.Name = "Channel_B";
            this.Channel_B.Size = new System.Drawing.Size(304, 220);
            this.Channel_B.TabIndex = 2;
            this.Channel_B.TabStop = false;
            this.Channel_B.Text = "Channel B";
            // 
            // checkBox1B
            // 
            this.checkBox1B.AutoSize = true;
            this.checkBox1B.Location = new System.Drawing.Point(6, 29);
            this.checkBox1B.Name = "checkBox1B";
            this.checkBox1B.Size = new System.Drawing.Size(57, 17);
            this.checkBox1B.TabIndex = 17;
            this.checkBox1B.Text = "Path 1";
            this.checkBox1B.UseVisualStyleBackColor = true;
            this.checkBox1B.CheckedChanged += new System.EventHandler(this.checkBox1B_CheckedChanged);
            // 
            // checkBox2B
            // 
            this.checkBox2B.AutoSize = true;
            this.checkBox2B.Location = new System.Drawing.Point(6, 52);
            this.checkBox2B.Name = "checkBox2B";
            this.checkBox2B.Size = new System.Drawing.Size(57, 17);
            this.checkBox2B.TabIndex = 16;
            this.checkBox2B.Text = "Path 2";
            this.checkBox2B.UseVisualStyleBackColor = true;
            this.checkBox2B.CheckedChanged += new System.EventHandler(this.checkBox2B_CheckedChanged);
            // 
            // checkBox3B
            // 
            this.checkBox3B.AutoSize = true;
            this.checkBox3B.Location = new System.Drawing.Point(6, 75);
            this.checkBox3B.Name = "checkBox3B";
            this.checkBox3B.Size = new System.Drawing.Size(57, 17);
            this.checkBox3B.TabIndex = 15;
            this.checkBox3B.Text = "Path 3";
            this.checkBox3B.UseVisualStyleBackColor = true;
            this.checkBox3B.CheckedChanged += new System.EventHandler(this.checkBox3B_CheckedChanged);
            // 
            // checkBox4B
            // 
            this.checkBox4B.AutoSize = true;
            this.checkBox4B.Location = new System.Drawing.Point(6, 98);
            this.checkBox4B.Name = "checkBox4B";
            this.checkBox4B.Size = new System.Drawing.Size(57, 17);
            this.checkBox4B.TabIndex = 14;
            this.checkBox4B.Text = "Path 4";
            this.checkBox4B.UseVisualStyleBackColor = true;
            this.checkBox4B.CheckedChanged += new System.EventHandler(this.checkBox4B_CheckedChanged);
            // 
            // checkBox5B
            // 
            this.checkBox5B.AutoSize = true;
            this.checkBox5B.Location = new System.Drawing.Point(6, 121);
            this.checkBox5B.Name = "checkBox5B";
            this.checkBox5B.Size = new System.Drawing.Size(57, 17);
            this.checkBox5B.TabIndex = 13;
            this.checkBox5B.Text = "Path 5";
            this.checkBox5B.UseVisualStyleBackColor = true;
            this.checkBox5B.CheckedChanged += new System.EventHandler(this.checkBox5B_CheckedChanged);
            // 
            // checkBox6B
            // 
            this.checkBox6B.AutoSize = true;
            this.checkBox6B.Location = new System.Drawing.Point(6, 144);
            this.checkBox6B.Name = "checkBox6B";
            this.checkBox6B.Size = new System.Drawing.Size(57, 17);
            this.checkBox6B.TabIndex = 12;
            this.checkBox6B.Text = "Path 6";
            this.checkBox6B.UseVisualStyleBackColor = true;
            this.checkBox6B.CheckedChanged += new System.EventHandler(this.checkBox6B_CheckedChanged);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(173, 138);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(75, 23);
            this.buttonB.TabIndex = 18;
            this.buttonB.Text = "Enable";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.button_Click);
            // 
            // Channel_A
            // 
            this.Channel_A.Controls.Add(this.buttonA);
            this.Channel_A.Controls.Add(this.checkBox1A);
            this.Channel_A.Controls.Add(this.checkBox2A);
            this.Channel_A.Controls.Add(this.checkBox3A);
            this.Channel_A.Controls.Add(this.checkBox4A);
            this.Channel_A.Controls.Add(this.checkBox5A);
            this.Channel_A.Controls.Add(this.checkBox6A);
            this.Channel_A.Dock = System.Windows.Forms.DockStyle.Top;
            this.Channel_A.Location = new System.Drawing.Point(0, 0);
            this.Channel_A.Name = "Channel_A";
            this.Channel_A.Size = new System.Drawing.Size(304, 220);
            this.Channel_A.TabIndex = 3;
            this.Channel_A.TabStop = false;
            this.Channel_A.Text = "Channel A";
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(173, 138);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(75, 23);
            this.buttonA.TabIndex = 18;
            this.buttonA.Text = "Enable";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.button_Click);
            // 
            // checkBox1A
            // 
            this.checkBox1A.AutoSize = true;
            this.checkBox1A.Location = new System.Drawing.Point(6, 29);
            this.checkBox1A.Name = "checkBox1A";
            this.checkBox1A.Size = new System.Drawing.Size(57, 17);
            this.checkBox1A.TabIndex = 17;
            this.checkBox1A.Text = "Path 1";
            this.checkBox1A.UseVisualStyleBackColor = true;
            this.checkBox1A.CheckedChanged += new System.EventHandler(this.checkBox1A_CheckedChanged);
            // 
            // checkBox2A
            // 
            this.checkBox2A.AutoSize = true;
            this.checkBox2A.Location = new System.Drawing.Point(6, 52);
            this.checkBox2A.Name = "checkBox2A";
            this.checkBox2A.Size = new System.Drawing.Size(57, 17);
            this.checkBox2A.TabIndex = 16;
            this.checkBox2A.Text = "Path 2";
            this.checkBox2A.UseVisualStyleBackColor = true;
            this.checkBox2A.CheckedChanged += new System.EventHandler(this.checkBox2A_CheckedChanged);
            // 
            // checkBox3A
            // 
            this.checkBox3A.AutoSize = true;
            this.checkBox3A.Location = new System.Drawing.Point(6, 75);
            this.checkBox3A.Name = "checkBox3A";
            this.checkBox3A.Size = new System.Drawing.Size(57, 17);
            this.checkBox3A.TabIndex = 15;
            this.checkBox3A.Text = "Path 3";
            this.checkBox3A.UseVisualStyleBackColor = true;
            this.checkBox3A.CheckedChanged += new System.EventHandler(this.checkBox3A_CheckedChanged);
            // 
            // checkBox4A
            // 
            this.checkBox4A.AutoSize = true;
            this.checkBox4A.Location = new System.Drawing.Point(6, 98);
            this.checkBox4A.Name = "checkBox4A";
            this.checkBox4A.Size = new System.Drawing.Size(57, 17);
            this.checkBox4A.TabIndex = 14;
            this.checkBox4A.Text = "Path 4";
            this.checkBox4A.UseVisualStyleBackColor = true;
            this.checkBox4A.CheckedChanged += new System.EventHandler(this.checkBox4A_CheckedChanged);
            // 
            // checkBox5A
            // 
            this.checkBox5A.AutoSize = true;
            this.checkBox5A.Location = new System.Drawing.Point(6, 121);
            this.checkBox5A.Name = "checkBox5A";
            this.checkBox5A.Size = new System.Drawing.Size(57, 17);
            this.checkBox5A.TabIndex = 13;
            this.checkBox5A.Text = "Path 5";
            this.checkBox5A.UseVisualStyleBackColor = true;
            this.checkBox5A.CheckedChanged += new System.EventHandler(this.checkBox5A_CheckedChanged);
            // 
            // checkBox6A
            // 
            this.checkBox6A.AutoSize = true;
            this.checkBox6A.Location = new System.Drawing.Point(6, 144);
            this.checkBox6A.Name = "checkBox6A";
            this.checkBox6A.Size = new System.Drawing.Size(57, 17);
            this.checkBox6A.TabIndex = 12;
            this.checkBox6A.Text = "Path 6";
            this.checkBox6A.UseVisualStyleBackColor = true;
            this.checkBox6A.CheckedChanged += new System.EventHandler(this.checkBox6A_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(304, 452);
            this.Controls.Add(this.Channel_A);
            this.Controls.Add(this.Channel_B);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "RF Switch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Channel_B.ResumeLayout(false);
            this.Channel_B.PerformLayout();
            this.Channel_A.ResumeLayout(false);
            this.Channel_A.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Channel_B;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.CheckBox checkBox1B;
        private System.Windows.Forms.CheckBox checkBox2B;
        private System.Windows.Forms.CheckBox checkBox3B;
        private System.Windows.Forms.CheckBox checkBox4B;
        private System.Windows.Forms.CheckBox checkBox5B;
        private System.Windows.Forms.CheckBox checkBox6B;
        private System.Windows.Forms.GroupBox Channel_A;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.CheckBox checkBox1A;
        private System.Windows.Forms.CheckBox checkBox2A;
        private System.Windows.Forms.CheckBox checkBox3A;
        private System.Windows.Forms.CheckBox checkBox4A;
        private System.Windows.Forms.CheckBox checkBox5A;
        private System.Windows.Forms.CheckBox checkBox6A;
    }
}

