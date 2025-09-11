
namespace DVLD
{
    partial class ManageUser
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Records = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_RowFilter = new System.Windows.Forms.MaskedTextBox();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_ManageUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pb_AddUser = new System.Windows.Forms.PictureBox();
            this.Cb_IsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CMS_ManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddUser)).BeginInit();
            this.SuspendLayout();
            // 
            // Cb_FilterBy
            // 
            this.Cb_FilterBy.DisplayMember = "None";
            this.Cb_FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_FilterBy.FormattingEnabled = true;
            this.Cb_FilterBy.Items.AddRange(new object[] {
            "None",
            "UserID",
            "UserName",
            "PersonID",
            "FullName",
            "IsActive"});
            this.Cb_FilterBy.Location = new System.Drawing.Point(73, 118);
            this.Cb_FilterBy.Name = "Cb_FilterBy";
            this.Cb_FilterBy.Size = new System.Drawing.Size(150, 21);
            this.Cb_FilterBy.TabIndex = 15;
            this.Cb_FilterBy.ValueMember = "None";
            this.Cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.Cb_FilterBy_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.GroupOfPeople;
            this.pictureBox1.Location = new System.Drawing.Point(578, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(508, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Manage Users";
            // 
            // Lb_Records
            // 
            this.Lb_Records.AutoSize = true;
            this.Lb_Records.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Records.Location = new System.Drawing.Point(89, 524);
            this.Lb_Records.Name = "Lb_Records";
            this.Lb_Records.Size = new System.Drawing.Size(16, 16);
            this.Lb_Records.TabIndex = 10;
            this.Lb_Records.Text = "..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Records : ";
            // 
            // Txt_RowFilter
            // 
            this.Txt_RowFilter.Culture = new System.Globalization.CultureInfo("en-001");
            this.Txt_RowFilter.HidePromptOnLeave = true;
            this.Txt_RowFilter.Location = new System.Drawing.Point(271, 118);
            this.Txt_RowFilter.Name = "Txt_RowFilter";
            this.Txt_RowFilter.PromptChar = ' ';
            this.Txt_RowFilter.RejectInputOnFirstFailure = true;
            this.Txt_RowFilter.Size = new System.Drawing.Size(150, 20);
            this.Txt_RowFilter.TabIndex = 16;
            this.Txt_RowFilter.TextChanged += new System.EventHandler(this.Txt_RowFilter_TextChanged);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fliter By ";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewPersonToolStripMenuItem.Text = "Add New User";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // CMS_ManageUsers
            // 
            this.CMS_ManageUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.CMS_ManageUsers.Name = "CMS_ManagePeople";
            this.CMS_ManageUsers.Size = new System.Drawing.Size(181, 186);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ContextMenuStrip = this.CMS_ManageUsers;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(5, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 365);
            this.dataGridView1.TabIndex = 9;
            // 
            // Pb_AddUser
            // 
            this.Pb_AddUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_AddUser.Image = global::DVLD.Properties.Resources.OIP;
            this.Pb_AddUser.Location = new System.Drawing.Point(979, 92);
            this.Pb_AddUser.Name = "Pb_AddUser";
            this.Pb_AddUser.Size = new System.Drawing.Size(50, 47);
            this.Pb_AddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_AddUser.TabIndex = 8;
            this.Pb_AddUser.TabStop = false;
            this.Pb_AddUser.Click += new System.EventHandler(this.Pb_AddUser_Click);
            // 
            // Cb_IsActive
            // 
            this.Cb_IsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_IsActive.FormattingEnabled = true;
            this.Cb_IsActive.Items.AddRange(new object[] {
            "None",
            "1",
            "0"});
            this.Cb_IsActive.Location = new System.Drawing.Point(271, 117);
            this.Cb_IsActive.Name = "Cb_IsActive";
            this.Cb_IsActive.Size = new System.Drawing.Size(150, 21);
            this.Cb_IsActive.TabIndex = 17;
            this.Cb_IsActive.Visible = false;
            this.Cb_IsActive.SelectedIndexChanged += new System.EventHandler(this.Cb_IsActive_SelectedIndexChanged);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 548);
            this.Controls.Add(this.Cb_IsActive);
            this.Controls.Add(this.Cb_FilterBy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lb_Records);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_RowFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Pb_AddUser);
            this.Name = "ManageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUser";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CMS_ManageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddUser)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMS_ManageUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox Pb_AddUser;
        private System.Windows.Forms.ComboBox Cb_IsActive;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}