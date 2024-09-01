namespace CHUONG_6
{
    partial class FormSuaHD
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTenSP = new System.Windows.Forms.TextBox();
            this.D0 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.buttonCapNhatHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm bán ra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày nhập hóa đơn:";
            // 
            // textBoxTenSP
            // 
            this.textBoxTenSP.Location = new System.Drawing.Point(166, 100);
            this.textBoxTenSP.Name = "textBoxTenSP";
            this.textBoxTenSP.Size = new System.Drawing.Size(182, 22);
            this.textBoxTenSP.TabIndex = 1;
            // 
            // D0
            // 
            this.D0.Location = new System.Drawing.Point(666, 100);
            this.D0.Name = "D0";
            this.D0.Size = new System.Drawing.Size(200, 22);
            this.D0.TabIndex = 4;
            this.D0.Value = new System.DateTime(2024, 7, 26, 0, 0, 0, 0);
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(400, 100);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(85, 22);
            this.textBoxDonGia.TabIndex = 2;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(523, 102);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(85, 22);
            this.textBoxSoLuong.TabIndex = 3;
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Location = new System.Drawing.Point(29, 100);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(85, 22);
            this.textBoxMaHD.TabIndex = 0;
            // 
            // buttonCapNhatHD
            // 
            this.buttonCapNhatHD.Location = new System.Drawing.Point(342, 176);
            this.buttonCapNhatHD.Name = "buttonCapNhatHD";
            this.buttonCapNhatHD.Size = new System.Drawing.Size(183, 35);
            this.buttonCapNhatHD.TabIndex = 5;
            this.buttonCapNhatHD.Text = "Cập nhật hóa đơn";
            this.buttonCapNhatHD.UseVisualStyleBackColor = true;
            this.buttonCapNhatHD.Click += new System.EventHandler(this.buttonCapNhatHD_Click);
            // 
            // FormSuaHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 262);
            this.Controls.Add(this.buttonCapNhatHD);
            this.Controls.Add(this.textBoxMaHD);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.textBoxDonGia);
            this.Controls.Add(this.D0);
            this.Controls.Add(this.textBoxTenSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaHD";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin hóa đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTenSP;
        private System.Windows.Forms.DateTimePicker D0;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.Button buttonCapNhatHD;
    }
}