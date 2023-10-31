using HutechNote.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HutechPM.UI.Frm
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            FileUploadService fileUpload = new FileUploadService();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Title = "Browse Text Files";
            openFileDialog.ShowDialog();
            foreach (String file in openFileDialog.FileNames)
            {
                var res = await fileUpload.uploadFile(file, file);
                MessageBox.Show(res);

                /*try
                {
                    Process process = new Process();
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = "chrome";
                    process.StartInfo.Arguments = res.Trim();
                    process.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }*/
            }
        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }
    }
}
