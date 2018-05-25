using System.Windows.Forms;
namespace ttak_datetime
{
    partial class usrCntrlTamDate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSiruPoluthu = new System.Windows.Forms.TextBox();
            this.txtPerumPoluthu = new System.Windows.Forms.TextBox();
            this.vGroupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCurrentTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.analogClock1 = new AnalogClockControl.AnalogClock();
            this.tnDateTimePicker1 = new TamilNadu.tnDateTimePicker();
            this.vGroupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSiruPoluthu
            // 
            this.txtSiruPoluthu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSiruPoluthu.Location = new System.Drawing.Point(117, 45);
            this.txtSiruPoluthu.Name = "txtSiruPoluthu";
            this.txtSiruPoluthu.ReadOnly = true;
            this.txtSiruPoluthu.Size = new System.Drawing.Size(100, 20);
            this.txtSiruPoluthu.TabIndex = 3;
            // 
            // txtPerumPoluthu
            // 
            this.txtPerumPoluthu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPerumPoluthu.Location = new System.Drawing.Point(117, 19);
            this.txtPerumPoluthu.Name = "txtPerumPoluthu";
            this.txtPerumPoluthu.ReadOnly = true;
            this.txtPerumPoluthu.Size = new System.Drawing.Size(100, 20);
            this.txtPerumPoluthu.TabIndex = 2;
            this.txtPerumPoluthu.Text = "கார்காலம்";
            // 
            // vGroupBox3
            // 
            this.vGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.vGroupBox3.Controls.Add(this.tnDateTimePicker1);
            this.vGroupBox3.Location = new System.Drawing.Point(3, 3);
            this.vGroupBox3.Name = "vGroupBox3";
            this.vGroupBox3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.vGroupBox3.Size = new System.Drawing.Size(221, 413);
            this.vGroupBox3.TabIndex = 3;
            this.vGroupBox3.TabStop = false;
            this.vGroupBox3.Text = " நாட்காட்டி ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtSiruPoluthu);
            this.groupBox1.Controls.Add(this.lblCurrentTime);
            this.groupBox1.Controls.Add(this.txtPerumPoluthu);
            this.groupBox1.Controls.Add(this.analogClock1);
            this.groupBox1.Location = new System.Drawing.Point(331, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.groupBox1.Size = new System.Drawing.Size(221, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " நேரம் ";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentTime.Location = new System.Drawing.Point(6, 127);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.ReadOnly = true;
            this.lblCurrentTime.Size = new System.Drawing.Size(111, 20);
            this.lblCurrentTime.TabIndex = 3;
            this.lblCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // analogClock1
            // 
            this.analogClock1.Draw1MinuteTicks = true;
            this.analogClock1.Draw5MinuteTicks = true;
            this.analogClock1.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock1.Location = new System.Drawing.Point(6, 16);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock1.Size = new System.Drawing.Size(111, 111);
            this.analogClock1.TabIndex = 0;
            this.analogClock1.TicksColor = System.Drawing.Color.Black;
            // 
            // tnDateTimePicker1
            // 
            this.tnDateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tnDateTimePicker1.Location = new System.Drawing.Point(3, 16);
            this.tnDateTimePicker1.Name = "tnDateTimePicker1";
            this.tnDateTimePicker1.Size = new System.Drawing.Size(215, 387);
            this.tnDateTimePicker1.TabIndex = 0;
            // 
            // usrCntrlTamDate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vGroupBox3);
            this.Name = "usrCntrlTamDate";
            this.Size = new System.Drawing.Size(594, 487);
            this.Load += new System.EventHandler(this.usrCntrlTamDate_Load);
            this.vGroupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox vGroupBox3;
        private TamilNadu.tnDateTimePicker tnDateTimePicker1;
        private GroupBox groupBox1;
        private Timer timer1;
        private TextBox txtSiruPoluthu;
        private TextBox txtPerumPoluthu;
        private AnalogClockControl.AnalogClock analogClock1;
        private TextBox lblCurrentTime;

    }
}
