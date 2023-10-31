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
            accordionControlElementHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElementProject = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElementTask = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElementEmployess = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElementAcount = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElementProfile = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElementChangePassword = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElementLogout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            barLargeButtonItem1 = new BarLargeButtonItem();
            barButtonItem1 = new BarButtonItem();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainerMain
            // 
            fluentDesignFormContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            fluentDesignFormContainerMain.Location = new Point(256, 46);
            fluentDesignFormContainerMain.Name = "fluentDesignFormContainerMain";
            fluentDesignFormContainerMain.Size = new Size(1342, 853);
            fluentDesignFormContainerMain.TabIndex = 0;
            fluentDesignFormContainerMain.Click += fluentDesignFormContainerMain_Click;
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElementHome, accordionControlElementProject, accordionControlElementTask, accordionControlElementEmployess, accordionControlElementAcount });
            accordionControl1.Location = new Point(0, 46);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControl1.Size = new Size(256, 853);
            accordionControl1.TabIndex = 1;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementHome
            // 
            accordionControlElementHome.Name = "accordionControlElementHome";
            accordionControlElementHome.Text = "Home";
            accordionControlElementHome.Click += accordionControlElementHome_Click;
            // 
            // accordionControlElementProject
            // 
            accordionControlElementProject.Name = "accordionControlElementProject";
            accordionControlElementProject.Text = "Project";
            accordionControlElementProject.Click += accordionControlElementProject_Click;
            // 
            // accordionControlElementTask
            // 
            accordionControlElementTask.Name = "accordionControlElementTask";
            accordionControlElementTask.Text = "Task";
            accordionControlElementTask.Click += accordionControlElementTask_Click;
            // 
            // accordionControlElementEmployess
            // 
            accordionControlElementEmployess.Name = "accordionControlElementEmployess";
            accordionControlElementEmployess.Text = "Emloyess";
            accordionControlElementEmployess.Click += accordionControlElementEmployess_Click;
            // 
            // accordionControlElementAcount
            // 
            accordionControlElementAcount.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElementProfile, accordionControlElementChangePassword, accordionControlElementLogout });
            accordionControlElementAcount.Expanded = true;
            accordionControlElementAcount.Name = "accordionControlElementAcount";
            accordionControlElementAcount.Text = "Account";
            // 
            // accordionControlElementProfile
            // 
            accordionControlElementProfile.Name = "accordionControlElementProfile";
            accordionControlElementProfile.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElementProfile.Text = "Profile";
            accordionControlElementProfile.Click += accordionControlElementProfile_Click;
            // 
            // accordionControlElementChangePassword
            // 
            accordionControlElementChangePassword.Name = "accordionControlElementChangePassword";
            accordionControlElementChangePassword.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElementChangePassword.Text = "Change Password";
            accordionControlElementChangePassword.Click += accordionControlElementChangePassword_Click;
            // 
            // accordionControlElementLogout
            // 
            accordionControlElementLogout.Name = "accordionControlElementLogout";
            accordionControlElementLogout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElementLogout.Text = "Log Out";
            accordionControlElementLogout.Click += accordionControlElementLogout_Click;
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.ForeColor = Color.FromArgb(41, 128, 185);
            fluentDesignFormControl1.Items.AddRange(new BarItem[] { barLargeButtonItem1, barButtonItem1 });
            fluentDesignFormControl1.Location = new Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new Size(1598, 46);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
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
            Load += FrmMain_Load;
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




        private BarLargeButtonItem barLargeButtonItem1;
        private BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementHome;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementProject;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementTask;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementEmployess;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementAcount;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementProfile;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementChangePassword;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementLogout;
    }
}

