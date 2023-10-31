using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HutechPM.UI.FRM
{
    public partial class FrmSplashScreen : SplashScreen
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        private void labelCopyright_Click(object sender, EventArgs e)
        {

        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {

        }

        public enum SplashScreenCommand
        {
        }
    }
}