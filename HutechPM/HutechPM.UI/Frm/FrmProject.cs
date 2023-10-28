using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HutechPM.UI.Frm
{
    public partial class FrmProject : Form
    {
        public FrmProject()
        {
            InitializeComponent();


        }
        public string projectName { get; set; }
        public string description { get; set; }
        public string owner { get; set; }
        public string dateStart { get; set; }
        public bool isActive { get; set; }
        public FrmProject(string projectName, string description, string owner, string dateStart, bool isActive)
        {
            InitializeComponent();
            this.projectName = projectName;
            this.description = description;
            this.owner = owner;
            this.dateStart = dateStart;
            this.isActive = isActive;
        }

        private void FrmProject_Load(object sender, EventArgs e)
        {
            dateTimePickerStartdate.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartdate.CustomFormat = "dd/MM/yyyy";

            textBoxProjectName.Text = projectName;
            textBoxDescription.Text = description;
            comboBoxOwner.Text = owner;
            string[] dateStartSplit = dateStart.Split(' ');
            dateTimePickerStartdate.Value = DateTime.ParseExact(dateStartSplit[0], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (isActive)
            {
                radioButtonTrue.Checked = true;
            }
            else
            {
                radioButtonFalse.Checked = false;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
