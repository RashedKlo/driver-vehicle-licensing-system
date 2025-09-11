
namespace DVLD
{
    partial class CTRFindPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gb_Filter = new System.Windows.Forms.GroupBox();
            this.Btn_AddPerson = new System.Windows.Forms.PictureBox();
            this.Btn_FindPerson = new System.Windows.Forms.PictureBox();
            this.Txt_FindBy = new System.Windows.Forms.TextBox();
            this.Cb_FindBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrPersonDetails1 = new DVLD.CTRPersonDetails();
            this.Gb_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_AddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_FindPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_Filter
            // 
            this.Gb_Filter.Controls.Add(this.Btn_AddPerson);
            this.Gb_Filter.Controls.Add(this.Btn_FindPerson);
            this.Gb_Filter.Controls.Add(this.Txt_FindBy);
            this.Gb_Filter.Controls.Add(this.Cb_FindBy);
            this.Gb_Filter.Controls.Add(this.label1);
            this.Gb_Filter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Filter.Location = new System.Drawing.Point(4, 5);
            this.Gb_Filter.Name = "Gb_Filter";
            this.Gb_Filter.Size = new System.Drawing.Size(852, 74);
            this.Gb_Filter.TabIndex = 30;
            this.Gb_Filter.TabStop = false;
            this.Gb_Filter.Text = "Filter";
            // 
            // Btn_AddPerson
            // 
            this.Btn_AddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddPerson.Image = global::DVLD.Properties.Resources.OIP1;
            this.Btn_AddPerson.Location = new System.Drawing.Point(602, 39);
            this.Btn_AddPerson.Name = "Btn_AddPerson";
            this.Btn_AddPerson.Size = new System.Drawing.Size(31, 24);
            this.Btn_AddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_AddPerson.TabIndex = 3;
            this.Btn_AddPerson.TabStop = false;
            this.Btn_AddPerson.Click += new System.EventHandler(this.Btn_AddPerson_Click);
            // 
            // Btn_FindPerson
            // 
            this.Btn_FindPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_FindPerson.Image = global::DVLD.Properties.Resources.FindPerson;
            this.Btn_FindPerson.Location = new System.Drawing.Point(551, 40);
            this.Btn_FindPerson.Name = "Btn_FindPerson";
            this.Btn_FindPerson.Size = new System.Drawing.Size(31, 24);
            this.Btn_FindPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_FindPerson.TabIndex = 3;
            this.Btn_FindPerson.TabStop = false;
            this.Btn_FindPerson.Click += new System.EventHandler(this.Btn_FindPerson_Click);
            // 
            // Txt_FindBy
            // 
            this.Txt_FindBy.Location = new System.Drawing.Point(329, 41);
            this.Txt_FindBy.Name = "Txt_FindBy";
            this.Txt_FindBy.Size = new System.Drawing.Size(183, 23);
            this.Txt_FindBy.TabIndex = 2;
            this.Txt_FindBy.TextChanged += new System.EventHandler(this.Txt_FindBy_TextChanged);
            // 
            // Cb_FindBy
            // 
            this.Cb_FindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_FindBy.FormattingEnabled = true;
            this.Cb_FindBy.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.Cb_FindBy.Location = new System.Drawing.Point(99, 40);
            this.Cb_FindBy.Name = "Cb_FindBy";
            this.Cb_FindBy.Size = new System.Drawing.Size(183, 24);
            this.Cb_FindBy.TabIndex = 1;
            this.Cb_FindBy.SelectedIndexChanged += new System.EventHandler(this.Cb_FindBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By :";
            // 
            // ctrPersonDetails1
            // 
            this.ctrPersonDetails1.BackColor = System.Drawing.Color.White;
            this.ctrPersonDetails1.Location = new System.Drawing.Point(4, 98);
            this.ctrPersonDetails1.Name = "ctrPersonDetails1";
            this.ctrPersonDetails1.Size = new System.Drawing.Size(852, 298);
            this.ctrPersonDetails1.TabIndex = 29;
            // 
            // CTRFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Gb_Filter);
            this.Controls.Add(this.ctrPersonDetails1);
            this.Name = "CTRFindPerson";
            this.Size = new System.Drawing.Size(855, 409);
            this.Load += new System.EventHandler(this.CTRFindPerson_Load);
            this.Gb_Filter.ResumeLayout(false);
            this.Gb_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_AddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_FindPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Btn_AddPerson;
        private System.Windows.Forms.PictureBox Btn_FindPerson;
        private System.Windows.Forms.TextBox Txt_FindBy;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Cb_FindBy;
        public System.Windows.Forms.GroupBox Gb_Filter;
        public CTRPersonDetails ctrPersonDetails1;
    }
}
