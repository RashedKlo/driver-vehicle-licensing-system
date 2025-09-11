
namespace DVLD
{
    partial class AddOrUpdateUser
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
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.TBC_PersonDetails = new System.Windows.Forms.TabControl();
            this.PersonID = new System.Windows.Forms.TabPage();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.LoginUser = new System.Windows.Forms.TabPage();
            this.Btn_Previous = new System.Windows.Forms.Button();
            this.ctrFindPerson1 = new DVLD.CTRFindPerson();
            this.ctrUserDetails1 = new DVLD.CTRUserDetails();
            this.TBC_PersonDetails.SuspendLayout();
            this.PersonID.SuspendLayout();
            this.LoginUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.ForeColor = System.Drawing.Color.Red;
            this.Lb_Title.Location = new System.Drawing.Point(401, 15);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(219, 25);
            this.Lb_Title.TabIndex = 22;
            this.Lb_Title.Text = "Add Or Update User";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Enabled = false;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(893, 555);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(85, 28);
            this.Btn_Save.TabIndex = 23;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(762, 555);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(85, 28);
            this.Btn_Close.TabIndex = 24;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // TBC_PersonDetails
            // 
            this.TBC_PersonDetails.Controls.Add(this.PersonID);
            this.TBC_PersonDetails.Controls.Add(this.LoginUser);
            this.TBC_PersonDetails.Location = new System.Drawing.Point(39, 43);
            this.TBC_PersonDetails.Name = "TBC_PersonDetails";
            this.TBC_PersonDetails.SelectedIndex = 0;
            this.TBC_PersonDetails.Size = new System.Drawing.Size(959, 506);
            this.TBC_PersonDetails.TabIndex = 4;
            // 
            // PersonID
            // 
            this.PersonID.Controls.Add(this.Btn_Next);
            this.PersonID.Controls.Add(this.ctrFindPerson1);
            this.PersonID.Location = new System.Drawing.Point(4, 22);
            this.PersonID.Name = "PersonID";
            this.PersonID.Padding = new System.Windows.Forms.Padding(3);
            this.PersonID.Size = new System.Drawing.Size(951, 480);
            this.PersonID.TabIndex = 0;
            this.PersonID.Text = "PersonID";
            this.PersonID.UseVisualStyleBackColor = true;
            // 
            // Btn_Next
            // 
            this.Btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Next.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Next.Location = new System.Drawing.Point(826, 441);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(99, 28);
            this.Btn_Next.TabIndex = 25;
            this.Btn_Next.Text = "Next -->";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // LoginUser
            // 
            this.LoginUser.Controls.Add(this.ctrUserDetails1);
            this.LoginUser.Controls.Add(this.Btn_Previous);
            this.LoginUser.Location = new System.Drawing.Point(4, 22);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Padding = new System.Windows.Forms.Padding(3);
            this.LoginUser.Size = new System.Drawing.Size(951, 480);
            this.LoginUser.TabIndex = 1;
            this.LoginUser.Text = "LoginUser";
            this.LoginUser.UseVisualStyleBackColor = true;
            // 
            // Btn_Previous
            // 
            this.Btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Previous.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Previous.Location = new System.Drawing.Point(831, 446);
            this.Btn_Previous.Name = "Btn_Previous";
            this.Btn_Previous.Size = new System.Drawing.Size(104, 28);
            this.Btn_Previous.TabIndex = 26;
            this.Btn_Previous.Text = "<-- Previous ";
            this.Btn_Previous.UseVisualStyleBackColor = true;
            this.Btn_Previous.Click += new System.EventHandler(this.Btn_Previous_Click);
            // 
            // ctrFindPerson1
            // 
            this.ctrFindPerson1.Location = new System.Drawing.Point(21, 17);
            this.ctrFindPerson1.Name = "ctrFindPerson1";
            this.ctrFindPerson1.Size = new System.Drawing.Size(855, 409);
            this.ctrFindPerson1.TabIndex = 0;
            // 
            // ctrUserDetails1
            // 
            this.ctrUserDetails1.Location = new System.Drawing.Point(18, 29);
            this.ctrUserDetails1.Name = "ctrUserDetails1";
            this.ctrUserDetails1.Size = new System.Drawing.Size(575, 304);
            this.ctrUserDetails1.TabIndex = 27;
            // 
            // AddOrUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 595);
            this.Controls.Add(this.TBC_PersonDetails);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrUpdateUser";
            this.Load += new System.EventHandler(this.AddOrUpdateUser_Load);
            this.TBC_PersonDetails.ResumeLayout(false);
            this.PersonID.ResumeLayout(false);
            this.LoginUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.TabControl TBC_PersonDetails;
        private System.Windows.Forms.TabPage PersonID;
        private System.Windows.Forms.TabPage LoginUser;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Previous;
        private CTRUserDetails ctrUserDetails1;
        private CTRFindPerson ctrFindPerson1;
    }
}