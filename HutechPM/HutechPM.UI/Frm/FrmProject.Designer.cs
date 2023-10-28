namespace HutechPM.UI.Frm
{
    partial class FrmProject
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBoxProjectName = new System.Windows.Forms.TextBox();
            comboBoxOwner = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            dateTimePickerStartdate = new System.Windows.Forms.DateTimePicker();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            radioButtonTrue = new System.Windows.Forms.RadioButton();
            radioButtonFalse = new System.Windows.Forms.RadioButton();
            dateTimePickerEnddate = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label1.Location = new System.Drawing.Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(658, 59);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(69, 108);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(123, 25);
            label2.TabIndex = 1;
            label2.Text = "Project name*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(71, 288);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 25);
            label4.TabIndex = 3;
            label4.Text = "Owner*";
            // 
            // textBoxProjectName
            // 
            textBoxProjectName.Location = new System.Drawing.Point(239, 108);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.Size = new System.Drawing.Size(300, 31);
            textBoxProjectName.TabIndex = 4;
            // 
            // comboBoxOwner
            // 
            comboBoxOwner.FormattingEnabled = true;
            comboBoxOwner.Location = new System.Drawing.Point(241, 285);
            comboBoxOwner.Name = "comboBoxOwner";
            comboBoxOwner.Size = new System.Drawing.Size(298, 33);
            comboBoxOwner.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(69, 185);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(102, 25);
            label5.TabIndex = 8;
            label5.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new System.Drawing.Point(239, 182);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new System.Drawing.Size(300, 58);
            textBoxDescription.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(69, 380);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 25);
            label7.TabIndex = 12;
            label7.Text = "Start date";
            // 
            // dateTimePickerStartdate
            // 
            dateTimePickerStartdate.Location = new System.Drawing.Point(239, 375);
            dateTimePickerStartdate.Name = "dateTimePickerStartdate";
            dateTimePickerStartdate.Size = new System.Drawing.Size(300, 31);
            dateTimePickerStartdate.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(436, 654);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(112, 34);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(284, 654);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(112, 34);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(71, 541);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 25);
            label3.TabIndex = 16;
            label3.Text = "Is Active";
            // 
            // radioButtonTrue
            // 
            radioButtonTrue.AutoSize = true;
            radioButtonTrue.Location = new System.Drawing.Point(241, 541);
            radioButtonTrue.Name = "radioButtonTrue";
            radioButtonTrue.Size = new System.Drawing.Size(69, 29);
            radioButtonTrue.TabIndex = 17;
            radioButtonTrue.TabStop = true;
            radioButtonTrue.Text = "True";
            radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // radioButtonFalse
            // 
            radioButtonFalse.AutoSize = true;
            radioButtonFalse.Location = new System.Drawing.Point(361, 541);
            radioButtonFalse.Name = "radioButtonFalse";
            radioButtonFalse.Size = new System.Drawing.Size(75, 29);
            radioButtonFalse.TabIndex = 18;
            radioButtonFalse.TabStop = true;
            radioButtonFalse.Text = "False";
            radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEnddate
            // 
            dateTimePickerEnddate.Location = new System.Drawing.Point(239, 460);
            dateTimePickerEnddate.Name = "dateTimePickerEnddate";
            dateTimePickerEnddate.Size = new System.Drawing.Size(300, 31);
            dateTimePickerEnddate.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(71, 460);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(82, 25);
            label6.TabIndex = 19;
            label6.Text = "End date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(66, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(105, 38);
            label8.TabIndex = 22;
            label8.Text = "Project";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconmenu1;
            pictureBox1.Location = new System.Drawing.Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(36, 47);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // FrmProject
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(652, 745);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(dateTimePickerEnddate);
            Controls.Add(label6);
            Controls.Add(radioButtonFalse);
            Controls.Add(radioButtonTrue);
            Controls.Add(label3);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerStartdate);
            Controls.Add(label7);
            Controls.Add(textBoxDescription);
            Controls.Add(label5);
            Controls.Add(comboBoxOwner);
            Controls.Add(textBoxProjectName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmProject";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Project";
            Load += FrmProject_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.ComboBox comboBoxOwner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonTrue;
        private System.Windows.Forms.RadioButton radioButtonFalse;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnddate;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}