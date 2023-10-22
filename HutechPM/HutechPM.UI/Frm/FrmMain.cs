using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using HutechPM.UI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HutechNote.UI.Frm
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        uc_CreateProject uc_CreateProject;
        public FrmMain()
        {
            InitializeComponent();

            /* for(int i = 0; i < 10; i++)
             {
                 accordionControlElement1.AccordionControl.AddItem();
             }*/
            AccordionControlElement item = new AccordionControlElement();
            item.Text = "tran quoc trung";
            item.Style = ElementStyle.Item;
            accordionControlElement1.Elements.Add(item);
            createControlElement();
        }
        AccordionControlElement[] accordionControlElement = new AccordionControlElement[8];
        private void createControlElement()
        {
            for (int i = 0; i < 5; i++)
            {
                accordionControlElement[i] = new AccordionControlElement();
                accordionControlElement[i].Text = i.ToString();
                accordionControlElement[i].Style = ElementStyle.Item;
                accordionControlElement[i].Click += new EventHandler(thongbao);
                accordionControlElement1.Elements.Add(accordionControlElement[i]);
                //var a = accordionControlElement.to

            }
        }
        private void thongbao(object sender, EventArgs e)
        {
            var accordionControlElement = sender as AccordionControlElement;
            if (accordionControlElement.Text == "1")

                MessageBox.Show(accordionControlElement.Text);

        }
        private void fluentDesignFormContainerMain_Click(object sender, EventArgs e)
        {
            if (uc_CreateProject == null)
            {
                uc_CreateProject = new uc_CreateProject();
                uc_CreateProject.Dock = DockStyle.Fill;
                fluentDesignFormContainerMain.Controls.Add(uc_CreateProject);
                uc_CreateProject.BringToFront();
            }
            else
            {
                uc_CreateProject.BringToFront();
            }
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aaaaa");
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }
    }
}
