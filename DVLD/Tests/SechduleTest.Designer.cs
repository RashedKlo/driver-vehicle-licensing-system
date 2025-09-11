
namespace DVLD
{
    partial class SechduleTest
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
            this.Btn_Close = new System.Windows.Forms.Button();
            this.ctrSechduleTest1 = new DVLD.CTRSechduleTest();
            this.Lb_TitleMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.ForeColor = System.Drawing.Color.Red;
            this.Lb_Title.Location = new System.Drawing.Point(289, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(186, 29);
            this.Lb_Title.TabIndex = 32;
            this.Lb_Title.Text = "Sechdule Test ";
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(334, 593);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(85, 28);
            this.Btn_Close.TabIndex = 35;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // ctrSechduleTest1
            // 
            this.ctrSechduleTest1.BackColor = System.Drawing.Color.White;
            this.ctrSechduleTest1.Location = new System.Drawing.Point(21, 69);
            this.ctrSechduleTest1.Name = "ctrSechduleTest1";
            this.ctrSechduleTest1.Size = new System.Drawing.Size(659, 470);
            this.ctrSechduleTest1.TabIndex = 36;
            this.ctrSechduleTest1.Load += new System.EventHandler(this.ctrSechduleTest1_Load);
            // 
            // Lb_TitleMessage
            // 
            this.Lb_TitleMessage.AutoSize = true;
            this.Lb_TitleMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TitleMessage.ForeColor = System.Drawing.Color.Red;
            this.Lb_TitleMessage.Location = new System.Drawing.Point(248, 38);
            this.Lb_TitleMessage.Name = "Lb_TitleMessage";
            this.Lb_TitleMessage.Size = new System.Drawing.Size(0, 16);
            this.Lb_TitleMessage.TabIndex = 32;
            // 
            // SechduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 705);
            this.Controls.Add(this.ctrSechduleTest1);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Lb_TitleMessage);
            this.Controls.Add(this.Lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SechduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SechduleTest";
            this.Load += new System.EventHandler(this.SechduleTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Button Btn_Close;
        public CTRSechduleTest ctrSechduleTest1;
        private System.Windows.Forms.Label Lb_TitleMessage;
    }
}