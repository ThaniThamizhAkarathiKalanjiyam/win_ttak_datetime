using System;
using System.Collections.Generic;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TamilNadu;



namespace ttak_datetime
{
    public partial class usrCntrlTamDate : UserControl
    {
        tnDateTime objtnDateTime = tnDateTime.CreateObject();

        public usrCntrlTamDate()
        {        	
            InitializeComponent();   


            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToLongTimeString();
            ShowPoluthuKal();
        }

        private void ShowPoluthuKal()
        {
            txtPerumPoluthu.Text = "";
            txtSiruPoluthu.Text = objtnDateTime.getTamilSiruPoluthukal(DateTime.Now).SiruPoluthuName;
        }

        private void usrCntrlTamDate_Load(object sender, EventArgs e)
        {
            

            //TamilMonths = objtnDateTime.getTamilMonths(Eras.ThaiBased);
            //tnDateTimePicker2.cboMonthName.DisplayMember = "MonthName";
            //tnDateTimePicker2.cboMonthName.ValueMember = "MonthNo";
            //tnDateTimePicker2.cboMonthName.DataSource = TamilMonths;
            
        }
    }
}
