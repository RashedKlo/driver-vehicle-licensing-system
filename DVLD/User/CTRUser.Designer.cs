
namespace DVLD
{
    partial class CTRUser
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
            this.label6 = new System.Windows.Forms.Label();
            this.Lb_IsActive = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_UserName = new System.Windows.Forms.Label();
            this.Lb_UserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrPersonDetails1 = new DVLD.CTRPersonDetails();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Is Active : ";
            // 
            // Lb_IsActive
            // 
            this.Lb_IsActive.AutoSize = true;
            this.Lb_IsActive.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_IsActive.Location = new System.Drawing.Point(667, 328);
            this.Lb_IsActive.Name = "Lb_IsActive";
            this.Lb_IsActive.Size = new System.Drawing.Size(49, 18);
            this.Lb_IsActive.TabIndex = 33;
            this.Lb_IsActive.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "User Name : ";
            // 
            // Lb_UserName
            // 
            this.Lb_UserName.AutoSize = true;
            this.Lb_UserName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserName.Location = new System.Drawing.Point(425, 328);
            this.Lb_UserName.Name = "Lb_UserName";
            this.Lb_UserName.Size = new System.Drawing.Size(49, 18);
            this.Lb_UserName.TabIndex = 34;
            this.Lb_UserName.Text = "[???]";
            // 
            // Lb_UserID
            // 
            this.Lb_UserID.AutoSize = true;
            this.Lb_UserID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserID.Location = new System.Drawing.Point(134, 328);
            this.Lb_UserID.Name = "Lb_UserID";
            this.Lb_UserID.Size = new System.Drawing.Size(49, 18);
            this.Lb_UserID.TabIndex = 35;
            this.Lb_UserID.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "UseID : ";
            // 
            // ctrPersonDetails1
            // 
            this.ctrPersonDetails1.Location = new System.Drawing.Point(7, -2);
            this.ctrPersonDetails1.Name = "ctrPersonDetails1";
            this.ctrPersonDetails1.Size = new System.Drawing.Size(852, 298);
            this.ctrPersonDetails1.TabIndex = 30;
            // 
            // CTRUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lb_IsActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lb_UserName);
            this.Controls.Add(this.Lb_UserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrPersonDetails1);
            this.Name = "CTRUser";
            this.Size = new System.Drawing.Size(899, 364);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lb_IsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_UserName;
        private System.Windows.Forms.Label Lb_UserID;
        private System.Windows.Forms.Label label1;
        private CTRPersonDetails ctrPersonDetails1;
    }
}
