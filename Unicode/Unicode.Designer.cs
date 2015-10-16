namespace Unicode
{
    partial class frmUnicode
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
            this.lstUnicode = new System.Windows.Forms.ListBox();
            this.btnCauculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUnicode
            // 
            this.lstUnicode.FormattingEnabled = true;
            this.lstUnicode.Location = new System.Drawing.Point(32, 33);
            this.lstUnicode.Name = "lstUnicode";
            this.lstUnicode.Size = new System.Drawing.Size(120, 95);
            this.lstUnicode.TabIndex = 1;
            // 
            // btnCauculate
            // 
            this.btnCauculate.Location = new System.Drawing.Point(119, 153);
            this.btnCauculate.Name = "btnCauculate";
            this.btnCauculate.Size = new System.Drawing.Size(75, 23);
            this.btnCauculate.TabIndex = 2;
            this.btnCauculate.Text = "Cauculate";
            this.btnCauculate.UseVisualStyleBackColor = true;
            this.btnCauculate.Click += new System.EventHandler(this.btnCauculate_Click);
            // 
            // frmUnicode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 194);
            this.Controls.Add(this.btnCauculate);
            this.Controls.Add(this.lstUnicode);
            this.Name = "frmUnicode";
            this.Text = "Unicode 32";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstUnicode;
        private System.Windows.Forms.Button btnCauculate;
    }
}

