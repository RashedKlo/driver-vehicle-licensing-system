
namespace DVLD
{
    partial class MainDVLD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDVLD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_AccountSettings = new System.Windows.Forms.Button();
            this.Btn_Users = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Drivers = new System.Windows.Forms.Button();
            this.Btn_People = new System.Windows.Forms.Button();
            this.Btn_Applications = new System.Windows.Forms.Button();
            this.CM_AccountSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Applications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.manageApplicationsTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loaclDrivingLiscenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForLostOrDamagedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reTakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.CM_AccountSettings.SuspendLayout();
            this.CM_Applications.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Btn_AccountSettings);
            this.panel1.Controls.Add(this.Btn_Users);
            this.panel1.Controls.Add(this.Btn_Drivers);
            this.panel1.Controls.Add(this.Btn_People);
            this.panel1.Controls.Add(this.Btn_Applications);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 59);
            this.panel1.TabIndex = 0;
            // 
            // Btn_AccountSettings
            // 
            this.Btn_AccountSettings.FlatAppearance.BorderSize = 0;
            this.Btn_AccountSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AccountSettings.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AccountSettings.ForeColor = System.Drawing.Color.Black;
            this.Btn_AccountSettings.Location = new System.Drawing.Point(696, 0);
            this.Btn_AccountSettings.Name = "Btn_AccountSettings";
            this.Btn_AccountSettings.Size = new System.Drawing.Size(174, 58);
            this.Btn_AccountSettings.TabIndex = 1;
            this.Btn_AccountSettings.Text = "AccountSettings";
            this.Btn_AccountSettings.UseVisualStyleBackColor = true;
            this.Btn_AccountSettings.Click += new System.EventHandler(this.Btn_AccountSettings_Click);
            // 
            // Btn_Users
            // 
            this.Btn_Users.FlatAppearance.BorderSize = 0;
            this.Btn_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Users.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Users.ForeColor = System.Drawing.Color.Black;
            this.Btn_Users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Users.ImageIndex = 0;
            this.Btn_Users.ImageList = this.imageList1;
            this.Btn_Users.Location = new System.Drawing.Point(522, 0);
            this.Btn_Users.Name = "Btn_Users";
            this.Btn_Users.Size = new System.Drawing.Size(174, 58);
            this.Btn_Users.TabIndex = 1;
            this.Btn_Users.Text = "Users";
            this.Btn_Users.UseVisualStyleBackColor = true;
            this.Btn_Users.Click += new System.EventHandler(this.Btn_Users_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "GroupOfPeople.png");
            this.imageList1.Images.SetKeyName(1, "Driving License.jpg");
            this.imageList1.Images.SetKeyName(2, "UserName.png");
            // 
            // Btn_Drivers
            // 
            this.Btn_Drivers.FlatAppearance.BorderSize = 0;
            this.Btn_Drivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Drivers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Drivers.ForeColor = System.Drawing.Color.Black;
            this.Btn_Drivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Drivers.ImageIndex = 2;
            this.Btn_Drivers.ImageList = this.imageList1;
            this.Btn_Drivers.Location = new System.Drawing.Point(348, 0);
            this.Btn_Drivers.Name = "Btn_Drivers";
            this.Btn_Drivers.Size = new System.Drawing.Size(174, 58);
            this.Btn_Drivers.TabIndex = 1;
            this.Btn_Drivers.Text = "Drivers";
            this.Btn_Drivers.UseVisualStyleBackColor = true;
            this.Btn_Drivers.Click += new System.EventHandler(this.Btn_Drivers_Click);
            // 
            // Btn_People
            // 
            this.Btn_People.FlatAppearance.BorderSize = 0;
            this.Btn_People.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_People.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_People.ForeColor = System.Drawing.Color.Black;
            this.Btn_People.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_People.ImageIndex = 0;
            this.Btn_People.ImageList = this.imageList1;
            this.Btn_People.Location = new System.Drawing.Point(174, 0);
            this.Btn_People.Name = "Btn_People";
            this.Btn_People.Size = new System.Drawing.Size(174, 58);
            this.Btn_People.TabIndex = 1;
            this.Btn_People.Text = "People";
            this.Btn_People.UseVisualStyleBackColor = true;
            this.Btn_People.Click += new System.EventHandler(this.Btn_People_Click);
            // 
            // Btn_Applications
            // 
            this.Btn_Applications.FlatAppearance.BorderSize = 0;
            this.Btn_Applications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Applications.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Applications.ForeColor = System.Drawing.Color.Black;
            this.Btn_Applications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Applications.ImageIndex = 1;
            this.Btn_Applications.ImageList = this.imageList1;
            this.Btn_Applications.Location = new System.Drawing.Point(0, 0);
            this.Btn_Applications.Name = "Btn_Applications";
            this.Btn_Applications.Size = new System.Drawing.Size(174, 58);
            this.Btn_Applications.TabIndex = 1;
            this.Btn_Applications.Text = "Applications";
            this.Btn_Applications.UseVisualStyleBackColor = true;
            this.Btn_Applications.Click += new System.EventHandler(this.Btn_Applications_Click);
            // 
            // CM_AccountSettings
            // 
            this.CM_AccountSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.CM_AccountSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.CM_AccountSettings.Name = "CM_AccountSettings";
            this.CM_AccountSettings.Size = new System.Drawing.Size(169, 76);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changeToolStripMenuItem.Text = "Current User info";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem2.Text = "Sign Out";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // CM_Applications
            // 
            this.CM_Applications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageApplicationsTypesToolStripMenuItem,
            this.mangeTestTypesToolStripMenuItem,
            this.sToolStripMenuItem,
            this.drivingLicensesServicesToolStripMenuItem,
            this.detainLicensesToolStripMenuItem});
            this.CM_Applications.Name = "CM_Applications";
            this.CM_Applications.Size = new System.Drawing.Size(219, 136);
            // 
            // manageApplicationsTypesToolStripMenuItem
            // 
            this.manageApplicationsTypesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Edit;
            this.manageApplicationsTypesToolStripMenuItem.Name = "manageApplicationsTypesToolStripMenuItem";
            this.manageApplicationsTypesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.manageApplicationsTypesToolStripMenuItem.Text = "Manage Applications Types";
            this.manageApplicationsTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsTypesToolStripMenuItem_Click);
            // 
            // mangeTestTypesToolStripMenuItem
            // 
            this.mangeTestTypesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Edit;
            this.mangeTestTypesToolStripMenuItem.Name = "mangeTestTypesToolStripMenuItem";
            this.mangeTestTypesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.mangeTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.mangeTestTypesToolStripMenuItem.Click += new System.EventHandler(this.mangeTestTypesToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loaclDrivingLiscenseApplicationsToolStripMenuItem,
            this.internationalLicenseApplicationsToolStripMenuItem});
            this.sToolStripMenuItem.Image = global::DVLD.Properties.Resources.Password;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.sToolStripMenuItem.Text = "Manage Applications";
            // 
            // loaclDrivingLiscenseApplicationsToolStripMenuItem
            // 
            this.loaclDrivingLiscenseApplicationsToolStripMenuItem.Name = "loaclDrivingLiscenseApplicationsToolStripMenuItem";
            this.loaclDrivingLiscenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.loaclDrivingLiscenseApplicationsToolStripMenuItem.Text = "Loacl Driving License Applications";
            this.loaclDrivingLiscenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.loaclDrivingLiscenseApplicationsToolStripMenuItem_Click);
            // 
            // internationalLicenseApplicationsToolStripMenuItem
            // 
            this.internationalLicenseApplicationsToolStripMenuItem.Name = "internationalLicenseApplicationsToolStripMenuItem";
            this.internationalLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.internationalLicenseApplicationsToolStripMenuItem.Text = "International License Applications";
            this.internationalLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseApplicationsToolStripMenuItem_Click);
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            this.drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replacementForLostOrDamagedLicenseToolStripMenuItem,
            this.toolStripSeparator2,
            this.releaseDetainedDrivingLicenseToolStripMenuItem,
            this.reTakeTestToolStripMenuItem});
            this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            this.newDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.newDrivingLicenseToolStripMenuItem_Click);
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // replacementForLostOrDamagedLicenseToolStripMenuItem
            // 
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Name = "replacementForLostOrDamagedLicenseToolStripMenuItem";
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Click += new System.EventHandler(this.replacementForLostOrDamagedLicenseToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicensesToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(293, 6);
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedDrivingLicenseToolStripMenuItem_Click);
            // 
            // reTakeTestToolStripMenuItem
            // 
            this.reTakeTestToolStripMenuItem.Name = "reTakeTestToolStripMenuItem";
            this.reTakeTestToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.reTakeTestToolStripMenuItem.Text = "ReTake Test";
            this.reTakeTestToolStripMenuItem.Click += new System.EventHandler(this.reTakeTestToolStripMenuItem_Click);
            // 
            // MainDVLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1146, 597);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainDVLD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DVLD_Load);
            this.panel1.ResumeLayout(false);
            this.CM_AccountSettings.ResumeLayout(false);
            this.CM_Applications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_AccountSettings;
        private System.Windows.Forms.Button Btn_Users;
        private System.Windows.Forms.Button Btn_Drivers;
        private System.Windows.Forms.Button Btn_People;
        private System.Windows.Forms.Button Btn_Applications;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip CM_AccountSettings;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip CM_Applications;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loaclDrivingLiscenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamagedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reTakeTestToolStripMenuItem;
    }
}