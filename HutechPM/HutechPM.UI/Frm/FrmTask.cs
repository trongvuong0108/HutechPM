using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;

namespace HutechPM.UI.Frm
{
    public partial class FrmTask : Form
    {
        public FrmTask()
        {
            InitializeComponent();
        }

        public string TaskName { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string Estimate { get; set; }
        public string Remaining  { get; set; }
        public string Status { get; set; }
        public FrmTask(string taskName, string description, string owner, string estimate, string remaining, string status)
        {
            InitializeComponent();
            this.TaskName = taskName;
            this.Description = description;
            this.Owner = owner;
            this.Estimate = estimate;
            this.Remaining = remaining;
            this.Status = status;
        }
        private void FrmTask_Load(object sender, EventArgs e)
        {
            textBoxTaskName.Text = TaskName;
            textBoxDescription.Text = Description;
            comboBoxOwner.Text = Owner;
            textBoxEstimate.Text = Estimate;
            textBoxRemaining.Text = Remaining;
            comboBoxStatus.Text = Status;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        
    }
}
