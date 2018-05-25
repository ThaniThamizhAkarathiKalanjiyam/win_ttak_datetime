/*
 * Created by SharpDevelop.
 * User: Muthukumaran
 * Date: 5/13/2018
 * Time: 7:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ttak_datetime;

namespace ttak_datetime
{
    public sealed class TtakCatetimeNotificationIcon
    {
        private static readonly log4net.ILog log =
          log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static TamDateTray objTamDateTray = null;

        public NotifyIcon notifyIcon;
        private ContextMenu notificationMenu;

        #region Initialize icon and menu
        public TtakCatetimeNotificationIcon()
        {
            notifyIcon = new NotifyIcon();
            notificationMenu = new ContextMenu(InitializeMenu());

            notifyIcon.DoubleClick += IconDoubleClick;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TamDateTray));
            notifyIcon.Icon = (Icon)resources.GetObject("$this.Icon");
            notifyIcon.ContextMenu = notificationMenu;
            notifyIcon.Text = "Thani Thamizh Akarathi Kalanjiyam";
        }


        #endregion

        #region Main - Program entry point
        /// <summary>Program entry point.</summary>
        /// <param name="args">Command Line Arguments</param>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            objTamDateTray = new TamDateTray();

            bool isFirstInstance;
            // Please use a unique name for the mutex to prevent conflicts with other programs
            using (Mutex mtx = new Mutex(true, "ttak_datetime", out isFirstInstance))
            {
                if (isFirstInstance)
                {
                    TtakCatetimeNotificationIcon notificationIcon = new TtakCatetimeNotificationIcon();
                    notificationIcon.notifyIcon.Visible = true;
                    Application.Run(objTamDateTray);
                    notificationIcon.notifyIcon.Dispose();
                }
                else
                {
                    // The application is already running
                    // TODO: Display message box or change focus to existing application instance
                    MessageBox.Show("This application is running already. Please click at taskbar icon.");
                }
            } // releases the Mutex
        }
        #endregion

        #region Event Handlers

        private MenuItem[] InitializeMenu()
        {
            MenuItem[] menu = new MenuItem[] {
                //new MenuItem("காண்பி", menuShowClick),                
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
                if (objTamDateTray.TopMost)
                {
                    objTamDateTray.TopMost = false;
                }
                else
                {
                    objTamDateTray.TopMost = true;
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
                objTamDateTray.BringToFront();
                //log.Info("0246501880855PM End.");
            }
            catch (Exception ex)
            {
                //log.Error("020873180857PM " + ex.Message);
            }
        }

        private void menuAboutClick(object sender, EventArgs e)
        {
            //MessageBox.Show("About This Application");
            try
            {
                log.Info("0201205657854PM Starting..");
                //AboutBoxTamKal2018 objAboutBoxTamKal2018 = new AboutBoxTamKal2018();                
                //objAboutBoxTamKal2018.StartPosition = FormStartPosition.CenterScreen;
                //objAboutBoxTamKal2018.ShowDialog();
                log.Info("02012fgfd80855PM End.");
            }
            catch (Exception ex)
            {
                log.Error("0201240180857PM " + ex.Message);
            }
        }

        private void menuExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconDoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("The icon was double clicked");
            //objTamDateTray.Show();
            //objTamDateTray.Focus();
            //objTamDateTray.ma();
            objTamDateTray.BringToFront();
        }
        #endregion
    }
}
