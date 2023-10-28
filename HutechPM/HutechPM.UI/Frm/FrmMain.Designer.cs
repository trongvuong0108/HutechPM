using DevExpress.XtraBars;
using System.Drawing;

namespace HutechNote.UI.Frm
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            fluentDesignFormContainerMain = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElementTasks = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            barLargeButtonItem1 = new BarLargeButtonItem();
            barButtonItem1 = new BarButtonItem();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElementProject = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainerMain
            // 
            fluentDesignFormContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            fluentDesignFormContainerMain.Location = new Point(263, 46);
            fluentDesignFormContainerMain.Name = "fluentDesignFormContainerMain";
            fluentDesignFormContainerMain.Size = new Size(1335, 853);
            fluentDesignFormContainerMain.TabIndex = 0;
            fluentDesignFormContainerMain.Click += fluentDesignFormContainerMain_Click;
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement4, accordionControlElement1, accordionControlElementTasks, accordionControlElement3 });
            accordionControl1.Location = new Point(0, 46);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControl1.Size = new Size(263, 853);
            accordionControl1.TabIndex = 1;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement4
            // 
            accordionControlElement4.Expanded = true;
            accordionControlElement4.ImageOptions.Image = (Image)resources.GetObject("accordionControlElement4.ImageOptions.Image");
            accordionControlElement4.Name = "accordionControlElement4";
            accordionControlElement4.Text = "Home";
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.ImageOptions.Image = (Image)resources.GetObject("accordionControlElement1.ImageOptions.Image");
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Text = "Project";
            accordionControlElement1.Click += accordionControlElement1_Click;
            // 
            // accordionControlElementTasks
            // 
            accordionControlElementTasks.Name = "accordionControlElementTasks";
            accordionControlElementTasks.Text = "Tasks";
            // 
            // accordionControlElement3
            // 
            accordionControlElement3.ImageOptions.Image = (Image)resources.GetObject("accordionControlElement3.ImageOptions.Image");
            accordionControlElement3.Name = "accordionControlElement3";
            accordionControlElement3.Text = "User";
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Items.AddRange(new BarItem[] { barLargeButtonItem1, barButtonItem1 });
            fluentDesignFormControl1.Location = new Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new Size(1598, 46);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.Click += fluentDesignFormControl1_Click;
            // 
            // barLargeButtonItem1
            // 
            barLargeButtonItem1.Alignment = BarItemLinkAlignment.Right;
            barLargeButtonItem1.Id = 1;
            barLargeButtonItem1.ImageOptions.Image = (Image)resources.GetObject("barLargeButtonItem1.ImageOptions.Image");
            barLargeButtonItem1.Name = "barLargeButtonItem1";
            barLargeButtonItem1.PaintStyle = BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Alignment = BarItemLinkAlignment.Right;
            barButtonItem1.Caption = "Login";
            barButtonItem1.Id = 2;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new BarItem[] { barLargeButtonItem1, barButtonItem1 });
            fluentFormDefaultManager1.MaxItemId = 3;
            // 
            // accordionControlElement2
            // 
            accordionControlElement2.ImageOptions.Image = (Image)resources.GetObject("accordionControlElement2.ImageOptions.Image");
            accordionControlElement2.Name = "accordionControlElement2";
            accordionControlElement2.Text = "Task";
            // 
            // accordionControlElement5
            // 
            accordionControlElement5.Name = "accordionControlElement5";
            accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement5.Text = "Element5";
            // 
            // accordionControlElementProject
            // 
            accordionControlElementProject.Expanded = true;
            accordionControlElementProject.Name = "accordionControlElementProject";
            accordionControlElementProject.Text = "Project";
            // 
            // accordionControlElement6
            // 
            accordionControlElement6.Name = "accordionControlElement6";
            accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement6.Text = "Element";
            // 
            // FrmMain
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(1598, 899);
            ControlContainer = fluentDesignFormContainerMain;
            Controls.Add(fluentDesignFormContainerMain);
            Controls.Add(accordionControl1);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            IconOptions.Icon = (Icon)resources.GetObject("FrmMain.IconOptions.Icon");
            IconOptions.ShowIcon = false;
            IconOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            Name = "FrmMain";
            NavigationControl = accordionControl1;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Hutech PM";
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainerMain;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private BarLargeButtonItem barLargeButtonItem1;
        private BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementProject;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementTasks;
    }
}

