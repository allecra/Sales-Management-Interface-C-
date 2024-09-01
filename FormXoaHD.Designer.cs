namespace CHUONG_6
{
    partial class FormXoaHD
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.buttonXoaHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập mã hóa đơn để xóa:";
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Location = new System.Drawing.Point(325, 62);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(174, 22);
            this.textBoxMaHD.TabIndex = 11;
            // 
            // buttonXoaHD
            // 
            this.buttonXoaHD.Location = new System.Drawing.Point(210, 119);
            this.buttonXoaHD.Name = "buttonXoaHD";
            this.buttonXoaHD.Size = new System.Drawing.Size(183, 35);
            this.buttonXoaHD.TabIndex = 12;
            this.buttonXoaHD.Text = "Xóa hóa đơn";
            this.buttonXoaHD.UseVisualStyleBackColor = true;
            this.buttonXoaHD.Click += new System.EventHandler(this.buttonXoaHD_Click);
            // 
            // FormXoaHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 201);
            this.Controls.Add(this.buttonXoaHD);
            this.Controls.Add(this.textBoxMaHD);
            this.Controls.Add(this.label1);
            this.Name = "FormXoaHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXoaHD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.Button buttonXoaHD;
    }
}