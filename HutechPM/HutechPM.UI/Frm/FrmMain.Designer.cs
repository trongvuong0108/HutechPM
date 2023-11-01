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
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
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
            barHeaderItem1 = new BarHeaderItem();
            barWorkspaceMenuItem1 = new BarWorkspaceMenuItem();
            workspaceManager1 = new DevExpress.Utils.WorkspaceManager(components);
            barStaticItem1 = new BarStaticItem();
            barStaticItemTittle = new BarStaticItem();
            barStaticItemTitle = new BarStaticItem();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainerMain
            // 
            fluentDesignFormContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            fluentDesignFormContainerMain.Location = new Point(265, 61);
            fluentDesignFormContainerMain.Name = "fluentDesignFormContainerMain";
            fluentDesignFormContainerMain.Size = new Size(1333, 838);
            fluentDesignFormContainerMain.TabIndex = 0;
            fluentDesignFormContainerMain.Click += fluentDesignFormContainerMain_Click;
            // 
            // accordionControl1
            // 
            accordionControl1.Appearance.AccordionControl.BackColor = Color.FromArgb(41, 128, 185);
            accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElementHome, accordionControlElementProject, accordionControlElementTask, accordionControlElementEmployess, accordionControlElementAcount });
            accordionControl1.Location = new Point(0, 61);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControl1.Size = new Size(265, 838);
            accordionControl1.TabIndex = 1;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementHome
            // 
            accordionControlElementHome.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElementHome.ImageOptions.SvgImage");
            accordionControlElementHome.Name = "accordionControlElementHome";
            accordionControlElementHome.Text = "Home";
            accordionControlElementHome.Click += accordionControlElementHome_Click;
            // 
            // accordionControlElementProject
            // 
            accordionControlElementProject.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElementProject.ImageOptions.SvgImage");
            accordionControlElementProject.Name = "accordionControlElementProject";
            accordionControlElementProject.Text = "Project";
            accordionControlElementProject.Click += accordionControlElementProject_Click;
            // 
            // accordionControlElementTask
            // 
            accordionControlElementTask.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElementTask.ImageOptions.SvgImage");
            accordionControlElementTask.Name = "accordionControlElementTask";
            accordionControlElementTask.Text = "Task";
            accordionControlElementTask.Click += accordionControlElementTask_Click;
            // 
            // accordionControlElementEmployess
            // 
            accordionControlElementEmployess.Expanded = true;
            accordionControlElementEmployess.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElementEmployess.ImageOptions.SvgImage");
            accordionControlElementEmployess.Name = "accordionControlElementEmployess";
            accordionControlElementEmployess.Text = "Emloyess";
            accordionControlElementEmployess.Click += accordionControlElementEmployess_Click;
            // 
            // accordionControlElementAcount
            // 
            accordionControlElementAcount.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElementProfile, accordionControlElementChangePassword, accordionControlElementLogout });
            accordionControlElementAcount.Expanded = true;
            accordionControlElementAcount.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElementAcount.ImageOptions.SvgImage");
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
            fluentDesignFormControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.ForeColor = Color.FromArgb(41, 128, 185);
            fluentDesignFormControl1.Items.AddRange(new BarItem[] { barLargeButtonItem1, barButtonItem1, barHeaderItem1, barWorkspaceMenuItem1, barStaticItem1, barStaticItemTittle, barStaticItemTitle });
            fluentDesignFormControl1.Location = new Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new Size(1598, 61);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.TitleItemLinks.Add(barStaticItemTitle);
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
            // barHeaderItem1
            // 
            barHeaderItem1.Id = 3;
            barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barWorkspaceMenuItem1
            // 
            barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            barWorkspaceMenuItem1.Id = 4;
            barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            barWorkspaceMenuItem1.WorkspaceManager = workspaceManager1;
            // 
            // workspaceManager1
            // 
            workspaceManager1.TargetControl = this;
            workspaceManager1.TransitionType = pushTransition1;
            // 
            // barStaticItem1
            // 
            barStaticItem1.Id = 5;
            barStaticItem1.Name = "barStaticItem1";
            // 
            // barStaticItemTittle
            // 
            barStaticItemTittle.Id = 6;
            barStaticItemTittle.ItemAppearance.Disabled.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            barStaticItemTittle.ItemAppearance.Disabled.Options.UseFont = true;
            barStaticItemTittle.ItemAppearance.Normal.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            barStaticItemTittle.ItemAppearance.Normal.ForeColor = Color.FromArgb(41, 128, 185);
            barStaticItemTittle.ItemAppearance.Normal.Options.UseFont = true;
            barStaticItemTittle.ItemAppearance.Normal.Options.UseForeColor = true;
            barStaticItemTittle.Name = "barStaticItemTittle";
            // 
            // barStaticItemTitle
            // 
            barStaticItemTitle.Caption = "Home";
            barStaticItemTitle.Id = 7;
            barStaticItemTitle.ItemAppearance.Normal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            barStaticItemTitle.ItemAppearance.Normal.ForeColor = Color.FromArgb(41, 128, 185);
            barStaticItemTitle.ItemAppearance.Normal.Options.UseFont = true;
            barStaticItemTitle.ItemAppearance.Normal.Options.UseForeColor = true;
            barStaticItemTitle.Name = "barStaticItemTitle";
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new BarItem[] { barLargeButtonItem1, barButtonItem1, barHeaderItem1, barWorkspaceMenuItem1, barStaticItem1, barStaticItemTittle, barStaticItemTitle });
            fluentFormDefaultManager1.MaxItemId = 8;
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
        private BarHeaderItem barHeaderItem1;
        private BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private BarStaticItem barStaticItem1;
        private BarStaticItem barStaticItemTittle;
        private BarStaticItem barStaticItemTitle;
    }
}

