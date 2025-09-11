
namespace DVLD
{
    partial class ManagePeople
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
            this.Pb_AddPerson = new System.Windows.Forms.PictureBox();
            this.DGV_People = new System.Windows.Forms.DataGridView();
            this.CMS_ManagePeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Records = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cb_FilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_RowFilter = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_People)).BeginInit();
            this.CMS_ManagePeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_AddPerson
            // 
            this.Pb_AddPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_AddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_AddPerson.Image = global::DVLD.Properties.Resources.OIP;
            this.Pb_AddPerson.Location = new System.Drawing.Point(1180, 88);
            this.Pb_AddPerson.Name = "Pb_AddPerson";
            this.Pb_AddPerson.Size = new System.Drawing.Size(50, 47);
            this.Pb_AddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_AddPerson.TabIndex = 1;
            this.Pb_AddPerson.TabStop = false;
            this.Pb_AddPerson.Click += new System.EventHandler(this.Pb_AddPerson_Click);
            // 
            // DGV_People
            // 
            this.DGV_People.AllowUserToAddRows = false;
            this.DGV_People.AllowUserToDeleteRows = false;
            this.DGV_People.AllowUserToOrderColumns = true;
            this.DGV_People.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_People.BackgroundColor = System.Drawing.Color.White;
            this.DGV_People.ColumnHeadersHeight = 20;
            this.DGV_People.ContextMenuStrip = this.CMS_ManagePeople;
            this.DGV_People.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_People.Location = new System.Drawing.Point(-3, 135);
            this.DGV_People.Name = "DGV_People";
            this.DGV_People.ReadOnly = true;
            this.DGV_People.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_People.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DGV_People.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_People.Size = new System.Drawing.Size(1237, 365);
            this.DGV_People.TabIndex = 2;
            // 
            // CMS_ManagePeople
            // 
            this.CMS_ManagePeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.CMS_ManagePeople.Name = "CMS_ManagePeople";
            this.CMS_ManagePeople.Size = new System.Drawing.Size(163, 142);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Records : ";
            // 
            // Lb_Records
            // 
            this.Lb_Records.AutoSize = true;
            this.Lb_Records.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Records.Location = new System.Drawing.Point(83, 514);
            this.Lb_Records.Name = "Lb_Records";
            this.Lb_Records.Size = new System.Drawing.Size(16, 16);
            this.Lb_Records.TabIndex = 3;
            this.Lb_Records.Text = "..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(502, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manage People";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.GroupOfPeople;
            this.pictureBox1.Location = new System.Drawing.Point(572, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Cb_FilterBy
            // 
            this.Cb_FilterBy.DisplayMember = "None";
            this.Cb_FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_FilterBy.FormattingEnabled = true;
            this.Cb_FilterBy.Items.AddRange(new object[] {
            "None"});
            this.Cb_FilterBy.Location = new System.Drawing.Point(67, 108);
            this.Cb_FilterBy.Name = "Cb_FilterBy";
            this.Cb_FilterBy.Size = new System.Drawing.Size(150, 21);
            this.Cb_FilterBy.TabIndex = 6;
            this.Cb_FilterBy.ValueMember = "None";
            this.Cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.Cb_FlitersBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fliter By ";
            // 
            // Txt_RowFilter
            // 
            this.Txt_RowFilter.Culture = new System.Globalization.CultureInfo("en-001");
            this.Txt_RowFilter.HidePromptOnLeave = true;
            this.Txt_RowFilter.Location = new System.Drawing.Point(265, 108);
            this.Txt_RowFilter.Name = "Txt_RowFilter";
            this.Txt_RowFilter.PromptChar = ' ';
            this.Txt_RowFilter.RejectInputOnFirstFailure = true;
            this.Txt_RowFilter.Size = new System.Drawing.Size(150, 20);
            this.Txt_RowFilter.TabIndex = 7;
            this.Txt_RowFilter.TextChanged += new System.EventHandler(this.Txt_RowFilter_TextChanged);
            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 620);
            this.Controls.Add(this.Cb_FilterBy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lb_Records);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_People);
            this.Controls.Add(this.Pb_AddPerson);
            this.Controls.Add(this.Txt_RowFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagePeople";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagePeople_FormClosing);
            this.Load += new System.EventHandler(this.ManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_AddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_People)).EndInit();
            this.CMS_ManagePeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pb_AddPerson;
        private System.Windows.Forms.DataGridView DGV_People;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Records;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Cb_FilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Txt_RowFilter;
        private System.Windows.Forms.ContextMenuStrip CMS_ManagePeople;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}