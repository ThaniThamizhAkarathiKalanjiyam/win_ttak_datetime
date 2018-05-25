namespace ttak_datetime
{
    partial class TamDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TamDate));
            this.tnDateTimePicker1 = new TamilNadu.tnDateTimePicker();
            this.SuspendLayout();
            // 
            // tnDateTimePicker1
            // 
            this.tnDateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tnDateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.tnDateTimePicker1.Name = "tnDateTimePicker1";
            this.tnDateTimePicker1.Size = new System.Drawing.Size(219, 324);
            this.tnDateTimePicker1.TabIndex = 0;
            // 
            // TamDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 324);
            this.Controls.Add(this.tnDateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TamDate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "தனித்தமிழ் நாளிகை";
            this.Load += new System.EventHandler(this.TamDate_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TamDate_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private TamilNadu.tnDateTimePicker tnDateTimePicker1;

    }
}

