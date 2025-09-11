
namespace DVLD
{
    partial class CTRValidateText
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
            this.Text = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Text.Location = new System.Drawing.Point(0, 0);
            this.Text.Multiline = true;
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(129, 19);
            this.Text.TabIndex = 1;
            this.Text.WordWrap = false;
            this.Text.TextChanged += new System.EventHandler(this.Text_TextChanged);
            this.Text.Validating += new System.ComponentModel.CancelEventHandler(this.Text_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CTRValidateText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Text);
            this.Name = "CTRValidateText";
            this.Size = new System.Drawing.Size(156, 20);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox Text;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
