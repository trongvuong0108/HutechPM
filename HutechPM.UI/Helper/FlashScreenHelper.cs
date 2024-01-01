using HutechPM.UI.FRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechPM.UI.Common
{
    public abstract class FlashScreenHelper
    {
        public static readonly FrmSplashScreen FrmSplashScreen = new FrmSplashScreen();
        public static void doAsyncMethod(Action worker)
        {
            FrmSplashScreen.Show();
            worker();
            FrmSplashScreen.Close();
        }

    }
}
