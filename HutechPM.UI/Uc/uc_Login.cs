using DevExpress.XtraRichEdit.Fields;
using HutechPM.UI.Frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HutechPM.UI.Uc
{
    public partial class uc_Login : UserControl
    {
        public uc_Login()
        {
            InitializeComponent();
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            textBoxUser.BackColor = Color.White;
            pictureBoxUser.BackColor = Color.White;
            pictureBoxIconUser.BackColor = Color.White;
            textBoxPassword.BackColor = SystemColors.Control;
            pictureBoxPasswork.BackColor = SystemColors.Control;
            pictureBoxIconLock.BackColor = SystemColors.Control;

        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
            pictureBoxPasswork.BackColor = Color.White;
            pictureBoxIconLock.BackColor = Color.White;
            textBoxUser.BackColor = SystemColors.Control;
            pictureBoxUser.BackColor = SystemColors.Control;
            pictureBoxIconUser.BackColor = SystemColors.Control;

        }

        private void labelForget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aa");
        }

        private void uc_Login_Load(object sender, EventArgs e)
        {

        }


        private void pictureBoxIconLock_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxIconLock_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void pictureBoxIconLock_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }


        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
