using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TamilNadu;

namespace ttak_datetime
{
    public partial class TamDateTray : Form
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        //ttak_datetime.SysTray objSysTray = null;
        tnDateTime objtnDateTime = null;


        static TamDateTray objTamDateTray = null;

        //public NotifyIcon notifyIcon;
        private ContextMenu notificationMenu;

        public TamDateTray()
        {
            InitializeComponent();
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TamDate));
            //objSysTray = new ttak_datetime.SysTray(this.Text,
            //  (Icon)resources.GetObject("$this.Icon"),
            //  new ContextMenu(InitializeMenu()));
            //objSysTray.setDoubleClickEvent(IconDoubleClick);

            //notifyIcon = new NotifyIcon();
            //notificationMenu = new ContextMenu(InitializeMenu());

            ////notifyIcon.DoubleClick += IconDoubleClick;
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TamDateTray));
            //notifyIcon.Icon = (Icon)resources.GetObject("$this.Icon");
            //notifyIcon.ContextMenu = notificationMenu;
            //notifyIcon.Text = "Thani Thamizh Akarathi Kalanjiyam";
        }

       
        private MenuItem[] InitializeMenu()
        {
            MenuItem[] menu = new MenuItem[] {
                new MenuItem("காண்பி", menuShowClick),                
				new MenuItem("மேலே/கீழே வை", menuMakeFrontOnlyClick),
				new MenuItem("முடக்கு", menuExitClick)
			};
            return menu;
        }

        private void menuMakeFrontOnlyClick(object sender, EventArgs e)
        {
            try
            {
                log.Info("02467180854PM Starting..");
                if (this.TopMost)
                {
                    this.TopMost = false;
                }
                else
                {
                    this.TopMost = true;
                }
                log.Info("02465015465855PM End.");
            }
            catch (Exception ex)
            {
                log.Error("0208731865657PM " + ex.Message);
            }
        }

        private void menuShowClick(object sender, EventArgs e)
        {
            try
            {
                //log.Info("0201567180854PM Starting..");
                this.BringToFront();
                //log.Info("0246501880855PM End.");
            }
            catch (Exception ex)
            {
                //log.Error("020873180857PM " + ex.Message);
            }
        }

        private void menuExitClick(object sender, EventArgs e)
        {
            try
            {
                //log.Info("0201567180854PM Starting..");
                this.Dispose();
                //log.Info("0246501880855PM End.");
            }
            catch (Exception ex)
            {
                //log.Error("020873180857PM " + ex.Message);
            }
        }

        private void menuDateTimeClick(object sender, EventArgs e)
        {
            try
            {
                //log.Info("0201567180854PM Starting..");
                //TamDate objAboutBoxTamKal2018 = new TamDate();
                //objAboutBoxTamKal2018.StartPosition = FormStartPosition.CenterScreen;
                //objAboutBoxTamKal2018.ShowDialog();
                //log.Info("0246501880855PM End.");
            }
            catch (Exception ex)
            {
                //log.Error("020873180857PM " + ex.Message);
            }
        }

        private void TamDateTray_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Location = new Point(x, y);

            objtnDateTime = tnDateTime.CreateObject();
            timer1.Start();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowPoluthuKal();
        }

        private void ShowPoluthuKal()
        {
            textBox1.Text = objtnDateTime
                .getTamilSiruPoluthukalToString(
                DateTime.Now, true);
        }

        

        public static TamDateTray CreateObject()
        {
            if (objTamDateTray == null)
            {
                objTamDateTray = new TamDateTray();
            }
            return objTamDateTray;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            TamDate objTamDate = TamDate.CreateObject();
            objTamDate.ShowDialog();
            //objTamDate.BringToFront();
        }

    }
}
