
namespace DVLD
{
    partial class Drivers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Lb_Records = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_FilterBy = new System.Windows.Forms.ComboBox();
            this.Txt_RowFilter = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 377);
            this.dataGridView1.TabIndex = 33;
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(722, 540);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(85, 28);
            this.Btn_Close.TabIndex = 32;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.ForeColor = System.Drawing.Color.Red;
            this.Lb_Title.Location = new System.Drawing.Point(332, 26);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(113, 33);
            this.Lb_Title.TabIndex = 31;
            this.Lb_Title.Text = "Drivers";
            // 
            // Lb_Records
            // 
            this.Lb_Records.AutoSize = true;
            this.Lb_Records.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Records.Location = new System.Drawing.Point(105, 547);
            this.Lb_Records.Name = "Lb_Records";
            this.Lb_Records.Size = new System.Drawing.Size(21, 14);
            this.Lb_Records.TabIndex = 34;
            this.Lb_Records.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 35;
            this.label1.Text = "Records : ";
            // 
            // Cb_FilterBy
            // 
            this.Cb_FilterBy.DisplayMember = "None";
            this.Cb_FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_FilterBy.FormattingEnabled = true;
            this.Cb_FilterBy.Items.AddRange(new object[] {
            "None",
            "DriverID",
            "PersonID",
            "NationalNo",
            "FullName"});
            this.Cb_FilterBy.Location = new System.Drawing.Point(87, 101);
            this.Cb_FilterBy.Name = "Cb_FilterBy";
            this.Cb_FilterBy.Size = new System.Drawing.Size(150, 21);
            this.Cb_FilterBy.TabIndex = 37;
            this.Cb_FilterBy.ValueMember = "None";
            this.Cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.Cb_FilterBy_SelectedIndexChanged);
            // 
            // Txt_RowFilter
            // 
            this.Txt_RowFilter.Culture = new System.Globalization.CultureInfo("en-001");
            this.Txt_RowFilter.HidePromptOnLeave = true;
            this.Txt_RowFilter.Location = new System.Drawing.Point(285, 102);
            this.Txt_RowFilter.Name = "Txt_RowFilter";
            this.Txt_RowFilter.PromptChar = ' ';
            this.Txt_RowFilter.RejectInputOnFirstFailure = true;
            this.Txt_RowFilter.Size = new System.Drawing.Size(150, 20);
            this.Txt_RowFilter.TabIndex = 38;
            this.Txt_RowFilter.Visible = false;
            this.Txt_RowFilter.TextChanged += new System.EventHandler(this.Txt_RowFilter_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fliter By ";
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 583);
            this.Controls.Add(this.Cb_FilterBy);
            this.Controls.Add(this.Txt_RowFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Lb_Title);
            this.Controls.Add(this.Lb_Records);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Drivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drivers";
            this.Load += new System.EventHandler(this.Drivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Label Lb_Records;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_FilterBy;
        private System.Windows.Forms.MaskedTextBox Txt_RowFilter;
        private System.Windows.Forms.Label label3;
    }
}