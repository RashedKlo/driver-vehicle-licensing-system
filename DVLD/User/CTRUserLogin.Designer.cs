
namespace DVLD
{
    partial class CTRUserDetails
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Chk_IsActive = new System.Windows.Forms.CheckBox();
            this.Lb_UserID = new System.Windows.Forms.Label();
            this.Txt_Password = new DVLD.CTRValidateText();
            this.Txt_UserName = new DVLD.CTRValidateText();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Txt_CheckPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "UseID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Check Password : ";
            // 
            // Chk_IsActive
            // 
            this.Chk_IsActive.AutoSize = true;
            this.Chk_IsActive.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_IsActive.Location = new System.Drawing.Point(206, 262);
            this.Chk_IsActive.Name = "Chk_IsActive";
            this.Chk_IsActive.Size = new System.Drawing.Size(81, 20);
            this.Chk_IsActive.TabIndex = 2;
            this.Chk_IsActive.Text = "IsActive";
            this.Chk_IsActive.UseVisualStyleBackColor = true;
            // 
            // Lb_UserID
            // 
            this.Lb_UserID.AutoSize = true;
            this.Lb_UserID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserID.Location = new System.Drawing.Point(189, 36);
            this.Lb_UserID.Name = "Lb_UserID";
            this.Lb_UserID.Size = new System.Drawing.Size(44, 18);
            this.Lb_UserID.TabIndex = 3;
            this.Lb_UserID.Text = "????";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(192, 152);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(156, 20);
            this.Txt_Password.TabIndex = 1;
            this.Txt_Password.Enter += new System.EventHandler(this.Txt_Password_Enter);
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Location = new System.Drawing.Point(192, 94);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(156, 20);
            this.Txt_UserName.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Txt_CheckPassword
            // 
            this.Txt_CheckPassword.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_CheckPassword.Location = new System.Drawing.Point(192, 208);
            this.Txt_CheckPassword.Name = "Txt_CheckPassword";
            this.Txt_CheckPassword.PasswordChar = '*';
            this.Txt_CheckPassword.Size = new System.Drawing.Size(134, 20);
            this.Txt_CheckPassword.TabIndex = 4;
            this.Txt_CheckPassword.TextChanged += new System.EventHandler(this.Txt_CheckPassword_TextChanged);
            // 
            // CTRUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_CheckPassword);
            this.Controls.Add(this.Lb_UserID);
            this.Controls.Add(this.Chk_IsActive);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CTRUserDetails";
            this.Size = new System.Drawing.Size(575, 304);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public CTRValidateText Txt_UserName;
        public CTRValidateText Txt_Password;
        public System.Windows.Forms.CheckBox Chk_IsActive;
        public System.Windows.Forms.Label Lb_UserID;
        private System.Windows.Forms.TextBox Txt_CheckPassword;
    }
}
