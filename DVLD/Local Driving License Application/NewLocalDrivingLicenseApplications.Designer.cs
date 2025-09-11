
namespace DVLD
{
    partial class NewLocalDrivingLicenseApplications
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBC_PersonDetails = new System.Windows.Forms.TabControl();
            this.PersonalInfo = new System.Windows.Forms.TabPage();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.ctrFindPerson1 = new DVLD.CTRFindPerson();
            this.ApplicationInfo = new System.Windows.Forms.TabPage();
            this.Btn_Previous = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lb_CreatedByUser = new System.Windows.Forms.Label();
            this.Lb_ApplicationFees = new System.Windows.Forms.Label();
            this.Lb_ApplicationDate = new System.Windows.Forms.Label();
            this.Lb_LocalApplicationID = new System.Windows.Forms.Label();
            this.Cb_LicenseClasses = new System.Windows.Forms.ComboBox();
            this.TBC_PersonDetails.SuspendLayout();
            this.PersonalInfo.SuspendLayout();
            this.ApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(248, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "New Local Driving License Applicaions";
            // 
            // TBC_PersonDetails
            // 
            this.TBC_PersonDetails.Controls.Add(this.PersonalInfo);
            this.TBC_PersonDetails.Controls.Add(this.ApplicationInfo);
            this.TBC_PersonDetails.Location = new System.Drawing.Point(12, 51);
            this.TBC_PersonDetails.Name = "TBC_PersonDetails";
            this.TBC_PersonDetails.SelectedIndex = 0;
            this.TBC_PersonDetails.Size = new System.Drawing.Size(959, 506);
            this.TBC_PersonDetails.TabIndex = 33;
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.Controls.Add(this.Btn_Next);
            this.PersonalInfo.Controls.Add(this.ctrFindPerson1);
            this.PersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalInfo.Size = new System.Drawing.Size(951, 480);
            this.PersonalInfo.TabIndex = 0;
            this.PersonalInfo.Text = "Personal Info";
            this.PersonalInfo.UseVisualStyleBackColor = true;
            // 
            // Btn_Next
            // 
            this.Btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Next.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Next.Location = new System.Drawing.Point(815, 441);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(99, 28);
            this.Btn_Next.TabIndex = 25;
            this.Btn_Next.Text = "Next -->";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // ctrFindPerson1
            // 
            this.ctrFindPerson1.Location = new System.Drawing.Point(10, 17);
            this.ctrFindPerson1.Name = "ctrFindPerson1";
            this.ctrFindPerson1.Size = new System.Drawing.Size(855, 409);
            this.ctrFindPerson1.TabIndex = 0;
            // 
            // ApplicationInfo
            // 
            this.ApplicationInfo.Controls.Add(this.Cb_LicenseClasses);
            this.ApplicationInfo.Controls.Add(this.Lb_LocalApplicationID);
            this.ApplicationInfo.Controls.Add(this.Lb_ApplicationDate);
            this.ApplicationInfo.Controls.Add(this.Lb_ApplicationFees);
            this.ApplicationInfo.Controls.Add(this.Lb_CreatedByUser);
            this.ApplicationInfo.Controls.Add(this.label6);
            this.ApplicationInfo.Controls.Add(this.label5);
            this.ApplicationInfo.Controls.Add(this.label4);
            this.ApplicationInfo.Controls.Add(this.label3);
            this.ApplicationInfo.Controls.Add(this.label1);
            this.ApplicationInfo.Controls.Add(this.Btn_Previous);
            this.ApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.ApplicationInfo.Name = "ApplicationInfo";
            this.ApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationInfo.Size = new System.Drawing.Size(951, 480);
            this.ApplicationInfo.TabIndex = 1;
            this.ApplicationInfo.Text = "Application Info";
            this.ApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // Btn_Previous
            // 
            this.Btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Previous.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Previous.Location = new System.Drawing.Point(820, 446);
            this.Btn_Previous.Name = "Btn_Previous";
            this.Btn_Previous.Size = new System.Drawing.Size(104, 28);
            this.Btn_Previous.TabIndex = 26;
            this.Btn_Previous.Text = "<-- Previous ";
            this.Btn_Previous.UseVisualStyleBackColor = true;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Enabled = false;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(846, 563);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(85, 28);
            this.Btn_Save.TabIndex = 35;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(715, 563);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(85, 28);
            this.Btn_Close.TabIndex = 36;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "D.L.Applications ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Application Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "License Class :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Applications Fees : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Created By : \r\n";
            // 
            // Lb_CreatedByUser
            // 
            this.Lb_CreatedByUser.AutoSize = true;
            this.Lb_CreatedByUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_CreatedByUser.Location = new System.Drawing.Point(180, 338);
            this.Lb_CreatedByUser.Name = "Lb_CreatedByUser";
            this.Lb_CreatedByUser.Size = new System.Drawing.Size(44, 18);
            this.Lb_CreatedByUser.TabIndex = 27;
            this.Lb_CreatedByUser.Text = "????";
            // 
            // Lb_ApplicationFees
            // 
            this.Lb_ApplicationFees.AutoSize = true;
            this.Lb_ApplicationFees.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ApplicationFees.Location = new System.Drawing.Point(216, 261);
            this.Lb_ApplicationFees.Name = "Lb_ApplicationFees";
            this.Lb_ApplicationFees.Size = new System.Drawing.Size(44, 18);
            this.Lb_ApplicationFees.TabIndex = 27;
            this.Lb_ApplicationFees.Text = "????";
            // 
            // Lb_ApplicationDate
            // 
            this.Lb_ApplicationDate.AutoSize = true;
            this.Lb_ApplicationDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ApplicationDate.Location = new System.Drawing.Point(208, 122);
            this.Lb_ApplicationDate.Name = "Lb_ApplicationDate";
            this.Lb_ApplicationDate.Size = new System.Drawing.Size(44, 18);
            this.Lb_ApplicationDate.TabIndex = 27;
            this.Lb_ApplicationDate.Text = "????";
            // 
            // Lb_LocalApplicationID
            // 
            this.Lb_LocalApplicationID.AutoSize = true;
            this.Lb_LocalApplicationID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_LocalApplicationID.Location = new System.Drawing.Point(229, 60);
            this.Lb_LocalApplicationID.Name = "Lb_LocalApplicationID";
            this.Lb_LocalApplicationID.Size = new System.Drawing.Size(44, 18);
            this.Lb_LocalApplicationID.TabIndex = 27;
            this.Lb_LocalApplicationID.Text = "????";
            // 
            // Cb_LicenseClasses
            // 
            this.Cb_LicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_LicenseClasses.FormattingEnabled = true;
            this.Cb_LicenseClasses.Location = new System.Drawing.Point(183, 190);
            this.Cb_LicenseClasses.Name = "Cb_LicenseClasses";
            this.Cb_LicenseClasses.Size = new System.Drawing.Size(207, 21);
            this.Cb_LicenseClasses.TabIndex = 28;
            // 
            // NewLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 595);
            this.Controls.Add(this.TBC_PersonDetails);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewLocalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLocalDrivingLicenseApplications";
            this.Load += new System.EventHandler(this.NewLocalDrivingLicenseApplications_Load);
            this.TBC_PersonDetails.ResumeLayout(false);
            this.PersonalInfo.ResumeLayout(false);
            this.ApplicationInfo.ResumeLayout(false);
            this.ApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl TBC_PersonDetails;
        private System.Windows.Forms.TabPage PersonalInfo;
        private System.Windows.Forms.Button Btn_Next;
        private CTRFindPerson ctrFindPerson1;
        private System.Windows.Forms.TabPage ApplicationInfo;
        private System.Windows.Forms.Button Btn_Previous;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_LicenseClasses;
        private System.Windows.Forms.Label Lb_LocalApplicationID;
        private System.Windows.Forms.Label Lb_ApplicationDate;
        private System.Windows.Forms.Label Lb_ApplicationFees;
        private System.Windows.Forms.Label Lb_CreatedByUser;
    }
}