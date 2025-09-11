
namespace DVLD
{
    partial class LicenseHirstory
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBC_PersonDetails = new System.Windows.Forms.TabControl();
            this.LocalID = new System.Windows.Forms.TabPage();
            this.Lb_LocalRecords = new System.Windows.Forms.Label();
            this.DGV_LocalLicenses = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.International = new System.Windows.Forms.TabPage();
            this.Lb_InternationalRecords = new System.Windows.Forms.Label();
            this.DGV_InternationalLicenses = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrPersonDetails1 = new DVLD.CTRPersonDetails();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TBC_PersonDetails.SuspendLayout();
            this.LocalID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LocalLicenses)).BeginInit();
            this.International.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InternationalLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(318, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "License History";
            // 
            // TBC_PersonDetails
            // 
            this.TBC_PersonDetails.Controls.Add(this.LocalID);
            this.TBC_PersonDetails.Controls.Add(this.International);
            this.TBC_PersonDetails.Location = new System.Drawing.Point(12, 315);
            this.TBC_PersonDetails.Name = "TBC_PersonDetails";
            this.TBC_PersonDetails.SelectedIndex = 0;
            this.TBC_PersonDetails.Size = new System.Drawing.Size(854, 244);
            this.TBC_PersonDetails.TabIndex = 7;
            // 
            // LocalID
            // 
            this.LocalID.Controls.Add(this.Lb_LocalRecords);
            this.LocalID.Controls.Add(this.DGV_LocalLicenses);
            this.LocalID.Controls.Add(this.label3);
            this.LocalID.Controls.Add(this.label1);
            this.LocalID.Location = new System.Drawing.Point(4, 22);
            this.LocalID.Name = "LocalID";
            this.LocalID.Padding = new System.Windows.Forms.Padding(3);
            this.LocalID.Size = new System.Drawing.Size(846, 218);
            this.LocalID.TabIndex = 0;
            this.LocalID.Text = "Local";
            this.LocalID.UseVisualStyleBackColor = true;
            // 
            // Lb_LocalRecords
            // 
            this.Lb_LocalRecords.AutoSize = true;
            this.Lb_LocalRecords.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_LocalRecords.Location = new System.Drawing.Point(99, 191);
            this.Lb_LocalRecords.Name = "Lb_LocalRecords";
            this.Lb_LocalRecords.Size = new System.Drawing.Size(21, 14);
            this.Lb_LocalRecords.TabIndex = 31;
            this.Lb_LocalRecords.Text = "??";
            // 
            // DGV_LocalLicenses
            // 
            this.DGV_LocalLicenses.AllowUserToAddRows = false;
            this.DGV_LocalLicenses.AllowUserToDeleteRows = false;
            this.DGV_LocalLicenses.AllowUserToOrderColumns = true;
            this.DGV_LocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_LocalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.DGV_LocalLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_LocalLicenses.Location = new System.Drawing.Point(11, 30);
            this.DGV_LocalLicenses.Name = "DGV_LocalLicenses";
            this.DGV_LocalLicenses.ReadOnly = true;
            this.DGV_LocalLicenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_LocalLicenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DGV_LocalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_LocalLicenses.Size = new System.Drawing.Size(802, 150);
            this.DGV_LocalLicenses.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 14);
            this.label3.TabIndex = 32;
            this.label3.Text = "Local Licenses History";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "Records : ";
            // 
            // International
            // 
            this.International.Controls.Add(this.Lb_InternationalRecords);
            this.International.Controls.Add(this.DGV_InternationalLicenses);
            this.International.Controls.Add(this.label6);
            this.International.Controls.Add(this.label5);
            this.International.Location = new System.Drawing.Point(4, 22);
            this.International.Name = "International";
            this.International.Padding = new System.Windows.Forms.Padding(3);
            this.International.Size = new System.Drawing.Size(846, 218);
            this.International.TabIndex = 1;
            this.International.Text = "International";
            this.International.UseVisualStyleBackColor = true;
            // 
            // Lb_InternationalRecords
            // 
            this.Lb_InternationalRecords.AutoSize = true;
            this.Lb_InternationalRecords.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_InternationalRecords.Location = new System.Drawing.Point(94, 193);
            this.Lb_InternationalRecords.Name = "Lb_InternationalRecords";
            this.Lb_InternationalRecords.Size = new System.Drawing.Size(21, 14);
            this.Lb_InternationalRecords.TabIndex = 34;
            this.Lb_InternationalRecords.Text = "??";
            // 
            // DGV_InternationalLicenses
            // 
            this.DGV_InternationalLicenses.AllowUserToAddRows = false;
            this.DGV_InternationalLicenses.AllowUserToDeleteRows = false;
            this.DGV_InternationalLicenses.AllowUserToOrderColumns = true;
            this.DGV_InternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_InternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.DGV_InternationalLicenses.Location = new System.Drawing.Point(6, 32);
            this.DGV_InternationalLicenses.Name = "DGV_InternationalLicenses";
            this.DGV_InternationalLicenses.ReadOnly = true;
            this.DGV_InternationalLicenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_InternationalLicenses.Size = new System.Drawing.Size(802, 150);
            this.DGV_InternationalLicenses.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 14);
            this.label6.TabIndex = 36;
            this.label6.Text = "Records : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "International Licenses History";
            // 
            // ctrPersonDetails1
            // 
            this.ctrPersonDetails1.Location = new System.Drawing.Point(12, 11);
            this.ctrPersonDetails1.Name = "ctrPersonDetails1";
            this.ctrPersonDetails1.Size = new System.Drawing.Size(864, 298);
            this.ctrPersonDetails1.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 26);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // LicenseHirstory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 569);
            this.Controls.Add(this.TBC_PersonDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrPersonDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LicenseHirstory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Hirstory";
            this.TBC_PersonDetails.ResumeLayout(false);
            this.LocalID.ResumeLayout(false);
            this.LocalID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LocalLicenses)).EndInit();
            this.International.ResumeLayout(false);
            this.International.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InternationalLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private CTRPersonDetails ctrPersonDetails1;
        private System.Windows.Forms.TabControl TBC_PersonDetails;
        private System.Windows.Forms.TabPage LocalID;
        private System.Windows.Forms.TabPage International;
        private System.Windows.Forms.DataGridView DGV_LocalLicenses;
        private System.Windows.Forms.Label Lb_LocalRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_InternationalRecords;
        private System.Windows.Forms.DataGridView DGV_InternationalLicenses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}