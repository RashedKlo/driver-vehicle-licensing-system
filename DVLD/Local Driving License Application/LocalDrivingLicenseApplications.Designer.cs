
namespace DVLD
{
    partial class LocalDrivingLicenseApplications
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
            this.Cb_FilterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Records = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_RowFilter = new System.Windows.Forms.MaskedTextBox();
            this.SechduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.WrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.StreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_ManagePeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.CancelAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.issuingDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_AddLicense = new System.Windows.Forms.PictureBox();
            this.CMS_ManagePeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_AddLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // Cb_FilterBy
            // 
            this.Cb_FilterBy.DisplayMember = "None";
            this.Cb_FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_FilterBy.FormattingEnabled = true;
            this.Cb_FilterBy.Items.AddRange(new object[] {
            "None",
            "LocalDrivingLicenseApplicationID",
            "NationalNo",
            "FullName",
            "Status"});
            this.Cb_FilterBy.Location = new System.Drawing.Point(68, 172);
            this.Cb_FilterBy.Name = "Cb_FilterBy";
            this.Cb_FilterBy.Size = new System.Drawing.Size(150, 21);
            this.Cb_FilterBy.TabIndex = 33;
            this.Cb_FilterBy.ValueMember = "None";
            this.Cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.Cb_FilterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(425, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Local Driving License Applicaions";
            // 
            // Lb_Records
            // 
            this.Lb_Records.AutoSize = true;
            this.Lb_Records.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Records.Location = new System.Drawing.Point(84, 579);
            this.Lb_Records.Name = "Lb_Records";
            this.Lb_Records.Size = new System.Drawing.Size(16, 16);
            this.Lb_Records.TabIndex = 28;
            this.Lb_Records.Text = "..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Records : ";
            // 
            // Txt_RowFilter
            // 
            this.Txt_RowFilter.Culture = new System.Globalization.CultureInfo("en-001");
            this.Txt_RowFilter.HidePromptOnLeave = true;
            this.Txt_RowFilter.Location = new System.Drawing.Point(266, 173);
            this.Txt_RowFilter.Name = "Txt_RowFilter";
            this.Txt_RowFilter.PromptChar = ' ';
            this.Txt_RowFilter.RejectInputOnFirstFailure = true;
            this.Txt_RowFilter.Size = new System.Drawing.Size(150, 20);
            this.Txt_RowFilter.TabIndex = 34;
            this.Txt_RowFilter.Visible = false;
            this.Txt_RowFilter.TextChanged += new System.EventHandler(this.Txt_RowFilter_TextChanged);
            // 
            // SechduleTestToolStripMenuItem
            // 
            this.SechduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisionTest,
            this.WrittenTest,
            this.StreetTest});
            this.SechduleTestToolStripMenuItem.Name = "SechduleTestToolStripMenuItem";
            this.SechduleTestToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.SechduleTestToolStripMenuItem.Text = "Sechdule Test";
            this.SechduleTestToolStripMenuItem.MouseEnter += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // VisionTest
            // 
            this.VisionTest.Name = "VisionTest";
            this.VisionTest.Size = new System.Drawing.Size(210, 22);
            this.VisionTest.Text = "Vision Test Appointment";
            this.VisionTest.Click += new System.EventHandler(this.VisionTest_Click);
            // 
            // WrittenTest
            // 
            this.WrittenTest.Name = "WrittenTest";
            this.WrittenTest.Size = new System.Drawing.Size(210, 22);
            this.WrittenTest.Text = "Written Test Appointment";
            this.WrittenTest.Click += new System.EventHandler(this.WrittenTest_Click_1);
            // 
            // StreetTest
            // 
            this.StreetTest.Name = "StreetTest";
            this.StreetTest.Size = new System.Drawing.Size(210, 22);
            this.StreetTest.Text = "Street Test Appointment";
            this.StreetTest.Click += new System.EventHandler(this.StreetTest_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 30;
            this.label3.Text = "Fliter By ";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.DeleteToolStripMenuItem.Text = "Delete Application";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // EditApplicationToolStripMenuItem
            // 
            this.EditApplicationToolStripMenuItem.Name = "EditApplicationToolStripMenuItem";
            this.EditApplicationToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.EditApplicationToolStripMenuItem.Text = "Edit Application";
            this.EditApplicationToolStripMenuItem.Click += new System.EventHandler(this.EditApplicationToolStripMenuItem_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // CMS_ManagePeople
            // 
            this.CMS_ManagePeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.EditApplicationToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.CancelAppToolStripMenuItem,
            this.toolStripSeparator1,
            this.SechduleTestToolStripMenuItem,
            this.dToolStripMenuItem,
            this.issuingDrivingLicenseFirstTimeToolStripMenuItem,
            this.dToolStripMenuItem1,
            this.showLicenseToolStripMenuItem,
            this.dToolStripMenuItem2,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.CMS_ManagePeople.Name = "CMS_ManagePeople";
            this.CMS_ManagePeople.Size = new System.Drawing.Size(257, 232);
            this.CMS_ManagePeople.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_ManagePeople_Opening);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(253, 6);
            this.sendEmailToolStripMenuItem.MouseEnter += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // CancelAppToolStripMenuItem
            // 
            this.CancelAppToolStripMenuItem.Image = global::DVLD.Properties.Resources.R_Black1;
            this.CancelAppToolStripMenuItem.Name = "CancelAppToolStripMenuItem";
            this.CancelAppToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.CancelAppToolStripMenuItem.Text = "Cancel Application";
            this.CancelAppToolStripMenuItem.Click += new System.EventHandler(this.CancelAppToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(253, 6);
            // 
            // issuingDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issuingDrivingLicenseFirstTimeToolStripMenuItem.Name = "issuingDrivingLicenseFirstTimeToolStripMenuItem";
            this.issuingDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.issuingDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issuing Driving License (First Time)";
            this.issuingDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issuingDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem1
            // 
            this.dToolStripMenuItem1.Name = "dToolStripMenuItem1";
            this.dToolStripMenuItem1.Size = new System.Drawing.Size(253, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem2
            // 
            this.dToolStripMenuItem2.Name = "dToolStripMenuItem2";
            this.dToolStripMenuItem2.Size = new System.Drawing.Size(253, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ContextMenuStrip = this.CMS_ManagePeople;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 365);
            this.dataGridView1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Driving_License;
            this.pictureBox1.Location = new System.Drawing.Point(573, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_AddLicense
            // 
            this.Btn_AddLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Btn_AddLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddLicense.Image = global::DVLD.Properties.Resources.OIP;
            this.Btn_AddLicense.Location = new System.Drawing.Point(1181, 153);
            this.Btn_AddLicense.Name = "Btn_AddLicense";
            this.Btn_AddLicense.Size = new System.Drawing.Size(50, 47);
            this.Btn_AddLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_AddLicense.TabIndex = 26;
            this.Btn_AddLicense.TabStop = false;
            this.Btn_AddLicense.Click += new System.EventHandler(this.Btn_AddLicense_Click);
            // 
            // LocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 600);
            this.Controls.Add(this.Cb_FilterBy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lb_Records);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_RowFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_AddLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocalDrivingLicenseApplications";
            this.Load += new System.EventHandler(this.LocalDrivingLicenseApplications_Load);
            this.CMS_ManagePeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_AddLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cb_FilterBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_Records;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Txt_RowFilter;
        private System.Windows.Forms.ToolStripMenuItem SechduleTestToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem CancelAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMS_ManagePeople;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox Btn_AddLicense;
        private System.Windows.Forms.ToolStripSeparator sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuingDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator dToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator dToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem VisionTest;
        private System.Windows.Forms.ToolStripMenuItem WrittenTest;
        private System.Windows.Forms.ToolStripMenuItem StreetTest;
    }
}