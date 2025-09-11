
namespace DVLD
{
    partial class IssueDrivingLicenseTheFirstTime
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
            this.ctrDrivingLicenseApplicationInfo1 = new DVLD.CTRDrivingLicenseApplicationInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Issue = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ctrDrivingLicenseApplicationInfo1
            // 
            this.ctrDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(12, -9);
            this.ctrDrivingLicenseApplicationInfo1.Name = "ctrDrivingLicenseApplicationInfo1";
            this.ctrDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(907, 451);
            this.ctrDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notes : ";
            // 
            // Btn_Issue
            // 
            this.Btn_Issue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Issue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Issue.Location = new System.Drawing.Point(804, 567);
            this.Btn_Issue.Name = "Btn_Issue";
            this.Btn_Issue.Size = new System.Drawing.Size(85, 28);
            this.Btn_Issue.TabIndex = 37;
            this.Btn_Issue.Text = "Issue";
            this.Btn_Issue.UseVisualStyleBackColor = true;
            this.Btn_Issue.Click += new System.EventHandler(this.Btn_Issue_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(673, 567);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(85, 28);
            this.Btn_Close.TabIndex = 38;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Location = new System.Drawing.Point(108, 456);
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(766, 91);
            this.Txt_Notes.TabIndex = 1;
            // 
            // IssueDrivingLicenseTheFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 605);
            this.Controls.Add(this.Btn_Issue);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Notes);
            this.Controls.Add(this.ctrDrivingLicenseApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IssueDrivingLicenseTheFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driving License The First Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTRDrivingLicenseApplicationInfo ctrDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Issue;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.TextBox Txt_Notes;
    }
}