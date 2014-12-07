using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCG
{
    
    public partial class SplashScreen : Form
    {
        private static Thread _splashThread;
        private static SplashScreen _splashScreen;

        public SplashScreen()
        {
            InitializeComponent();
        }

        public static void ShowSplash()
        {
            if (_splashThread == null)
            {
                _splashThread = new Thread(new ThreadStart(DoShowSplash));
                _splashThread.IsBackground = true;
                _splashThread.Start();
            }
        }

        private static void DoShowSplash()
        {
            if (_splashScreen == null)
            {
                _splashScreen = new SplashScreen();
            }

            Application.Run(_splashScreen);
        }

        public static void CloseSplash()
        {
            if (_splashScreen.InvokeRequired)
            {                
                _splashScreen.Invoke(new MethodInvoker(CloseSplash));
            }
            else
            {                
                Application.ExitThread();
            }
        }
    }
}
