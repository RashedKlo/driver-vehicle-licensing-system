
namespace DVLD
{
    partial class AddOrUpdate
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
            this.Btn_Close = new System.Windows.Forms.Button();
            this.ctrAddOrUpdatePerson1 = new DVLD.CTRAddOrUpdatePerson();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(433, 453);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(85, 28);
            this.Btn_Close.TabIndex = 16;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // ctrAddOrUpdatePerson1
            // 
            this.ctrAddOrUpdatePerson1.Location = new System.Drawing.Point(27, 10);
            this.ctrAddOrUpdatePerson1.Name = "ctrAddOrUpdatePerson1";
            this.ctrAddOrUpdatePerson1.Size = new System.Drawing.Size(813, 492);
            this.ctrAddOrUpdatePerson1.TabIndex = 17;
            this.ctrAddOrUpdatePerson1.Load += new System.EventHandler(this.ctrAddOrUpdatePerson1_Load);
            // 
            // AddOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 523);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.ctrAddOrUpdatePerson1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Close;
        private CTRAddOrUpdatePerson ctrAddOrUpdatePerson1;
    }
}