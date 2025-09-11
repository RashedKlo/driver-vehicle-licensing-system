
namespace DVLD
{
    partial class ManageDetainLicense
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
            this.Txt_RowFilter = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonHistoryLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Lb_Records = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Detain = new System.Windows.Forms.Button();
            this.Btn_Release = new System.Windows.Forms.Button();
            this.Chk_IsReleased = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cb_FilterBy
            // 
            this.Cb_FilterBy.DisplayMember = "None";
            this.Cb_FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_FilterBy.FormattingEnabled = true;
            this.Cb_FilterBy.Items.AddRange(new object[] {
            "None",
            "DetainID",
            "IsReleased",
            "NationalNo",
            "FullName",
            "ReleaseApplicationID"});
            this.Cb_FilterBy.Location = new System.Drawing.Point(80, 84);
            this.Cb_FilterBy.Name = "Cb_FilterBy";
            this.Cb_FilterBy.Size = new System.Drawing.Size(150, 21);
            this.Cb_FilterBy.TabIndex = 45;
            this.Cb_FilterBy.ValueMember = "None";
            this.Cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.Cb_FilterBy_SelectedIndexChanged);
            // 
            // Txt_RowFilter
            // 
            this.Txt_RowFilter.Culture = new System.Globalization.CultureInfo("en-001");
            this.Txt_RowFilter.HidePromptOnLeave = true;
            this.Txt_RowFilter.Location = new System.Drawing.Point(278, 85);
            this.Txt_RowFilter.Name = "Txt_RowFilter";
            this.Txt_RowFilter.PromptChar = ' ';
            this.Txt_RowFilter.RejectInputOnFirstFailure = true;
            this.Txt_RowFilter.Size = new System.Drawing.Size(150, 20);
            this.Txt_RowFilter.TabIndex = 46;
            this.Txt_RowFilter.Visible = false;
            this.Txt_RowFilter.TextChanged += new System.EventHandler(this.Txt_RowFilter_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 44;
            this.label3.Text = "Fliter By ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(974, 377);
            this.dataGridView1.TabIndex = 41;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonHistoryLicenseToolStripMenuItem,
            this.toolStripSeparator1,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(234, 98);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonHistoryLicenseToolStripMenuItem
            // 
            this.showPersonHistoryLicenseToolStripMenuItem.Name = "showPersonHistoryLicenseToolStripMenuItem";
            this.showPersonHistoryLicenseToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.showPersonHistoryLicenseToolStripMenuItem.Text = "Show Person (History License)";
            this.showPersonHistoryLicenseToolStripMenuItem.Click += new System.EventHandler(this.showPersonHistoryLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(897, 499);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(85, 30);
            this.Btn_Close.TabIndex = 40;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.ForeColor = System.Drawing.Color.Red;
            this.Lb_Title.Location = new System.Drawing.Point(334, 21);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(325, 33);
            this.Lb_Title.TabIndex = 39;
            this.Lb_Title.Text = "Manage Detain License";
            // 
            // Lb_Records
            // 
            this.Lb_Records.AutoSize = true;
            this.Lb_Records.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Records.Location = new System.Drawing.Point(98, 511);
            this.Lb_Records.Name = "Lb_Records";
            this.Lb_Records.Size = new System.Drawing.Size(21, 14);
            this.Lb_Records.TabIndex = 42;
            this.Lb_Records.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 43;
            this.label1.Text = "Records : ";
            // 
            // Btn_Detain
            // 
            this.Btn_Detain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Detain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Detain.Location = new System.Drawing.Point(897, 63);
            this.Btn_Detain.Name = "Btn_Detain";
            this.Btn_Detain.Size = new System.Drawing.Size(75, 42);
            this.Btn_Detain.TabIndex = 47;
            this.Btn_Detain.Text = "Detain";
            this.Btn_Detain.UseVisualStyleBackColor = true;
            this.Btn_Detain.Click += new System.EventHandler(this.Btn_Detain_Click);
            // 
            // Btn_Release
            // 
            this.Btn_Release.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Release.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Release.Location = new System.Drawing.Point(799, 63);
            this.Btn_Release.Name = "Btn_Release";
            this.Btn_Release.Size = new System.Drawing.Size(75, 42);
            this.Btn_Release.TabIndex = 47;
            this.Btn_Release.Text = "Release";
            this.Btn_Release.UseVisualStyleBackColor = true;
            this.Btn_Release.Click += new System.EventHandler(this.Btn_Release_Click);
            // 
            // Chk_IsReleased
            // 
            this.Chk_IsReleased.AutoSize = true;
            this.Chk_IsReleased.Location = new System.Drawing.Point(311, 85);
            this.Chk_IsReleased.Name = "Chk_IsReleased";
            this.Chk_IsReleased.Size = new System.Drawing.Size(82, 17);
            this.Chk_IsReleased.TabIndex = 48;
            this.Chk_IsReleased.Text = "Is Released";
            this.Chk_IsReleased.UseVisualStyleBackColor = true;
            this.Chk_IsReleased.Visible = false;
            this.Chk_IsReleased.CheckedChanged += new System.EventHandler(this.Chk_IsActive_CheckedChanged);
            // 
            // ManageDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 538);
            this.Controls.Add(this.Chk_IsReleased);
            this.Controls.Add(this.Btn_Release);
            this.Controls.Add(this.Btn_Detain);
            this.Controls.Add(this.Cb_FilterBy);
            this.Controls.Add(this.Txt_RowFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Lb_Title);
            this.Controls.Add(this.Lb_Records);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Detain License";
            this.Load += new System.EventHandler(this.ManageDetainLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cb_FilterBy;
        private System.Windows.Forms.MaskedTextBox Txt_RowFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Label Lb_Records;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonHistoryLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Detain;
        private System.Windows.Forms.Button Btn_Release;
        private System.Windows.Forms.CheckBox Chk_IsReleased;
    }
}