
namespace DVLD
{
    partial class ChangePassword
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
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tx = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrUser1 = new DVLD.CTRUser();
            this.Txt_NewPassword = new DVLD.CTRValidateText();
            this.Txt_CheckPassword = new DVLD.CTRValidateText();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(904, 576);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(85, 28);
            this.Btn_Save.TabIndex = 25;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(773, 576);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(85, 28);
            this.Btn_Close.TabIndex = 26;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(327, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 33);
            this.label3.TabIndex = 30;
            this.label3.Text = "Change Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Check Password : ";
            // 
            // Tx
            // 
            this.Tx.AutoSize = true;
            this.Tx.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx.Location = new System.Drawing.Point(38, 474);
            this.Tx.Name = "Tx";
            this.Tx.Size = new System.Drawing.Size(132, 18);
            this.Tx.TabIndex = 32;
            this.Tx.Text = "New Password : ";
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Password.Location = new System.Drawing.Point(192, 426);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(134, 20);
            this.Txt_Password.TabIndex = 37;
            this.Txt_Password.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Password_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 36;
            this.label7.Text = "Password : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrUser1
            // 
            this.ctrUser1.Location = new System.Drawing.Point(25, 42);
            this.ctrUser1.Name = "ctrUser1";
            this.ctrUser1.Size = new System.Drawing.Size(899, 364);
            this.ctrUser1.TabIndex = 38;
            // 
            // Txt_NewPassword
            // 
            this.Txt_NewPassword.Location = new System.Drawing.Point(192, 474);
            this.Txt_NewPassword.Name = "Txt_NewPassword";
            this.Txt_NewPassword.Size = new System.Drawing.Size(156, 20);
            this.Txt_NewPassword.TabIndex = 39;
            // 
            // Txt_CheckPassword
            // 
            this.Txt_CheckPassword.Location = new System.Drawing.Point(192, 520);
            this.Txt_CheckPassword.Name = "Txt_CheckPassword";
            this.Txt_CheckPassword.Size = new System.Drawing.Size(156, 20);
            this.Txt_CheckPassword.TabIndex = 39;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 616);
            this.Controls.Add(this.Txt_CheckPassword);
            this.Controls.Add(this.Txt_NewPassword);
            this.Controls.Add(this.ctrUser1);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Tx;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CTRUser ctrUser1;
        private CTRValidateText Txt_NewPassword;
        private CTRValidateText Txt_CheckPassword;
    }
}