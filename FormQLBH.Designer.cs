namespace CHUONG_6
{
    partial class FormQLBH
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sắpXếpTheoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sắpXếpTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.D1 = new System.Windows.Forms.DateTimePicker();
            this.D2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(768, 428);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.danhSáchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHóaĐơnToolStripMenuItem,
            this.cậpNhậtHóaToolStripMenuItem,
            this.xóaHóaĐơnToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // danhSáchToolStripMenuItem
            // 
            this.danhSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sắpXếpTheoToolStripMenuItem,
            this.sắpXếpTheoNgàyToolStripMenuItem});
            this.danhSáchToolStripMenuItem.Name = "danhSáchToolStripMenuItem";
            this.danhSáchToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.danhSáchToolStripMenuItem.Text = "Danh Sách";
            // 
            // sắpXếpTheoToolStripMenuItem
            // 
            this.sắpXếpTheoToolStripMenuItem.Name = "sắpXếpTheoToolStripMenuItem";
            this.sắpXếpTheoToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.sắpXếpTheoToolStripMenuItem.Text = "Sắp xếp theo giá trị hóa đơn";
            this.sắpXếpTheoToolStripMenuItem.Click += new System.EventHandler(this.sắpXếpTheoToolStripMenuItem_Click);
            // 
            // sắpXếpTheoNgàyToolStripMenuItem
            // 
            this.sắpXếpTheoNgàyToolStripMenuItem.Name = "sắpXếpTheoNgàyToolStripMenuItem";
            this.sắpXếpTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.sắpXếpTheoNgàyToolStripMenuItem.Text = "Sắp xếp theo ngày";
            this.sắpXếpTheoNgàyToolStripMenuItem.Click += new System.EventHandler(this.sắpXếpTheoNgàyToolStripMenuItem_Click);
            // 
            // thêmHóaĐơnToolStripMenuItem
            // 
            this.thêmHóaĐơnToolStripMenuItem.Name = "thêmHóaĐơnToolStripMenuItem";
            this.thêmHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmHóaĐơnToolStripMenuItem.Text = "Thêm hóa đơn";
            this.thêmHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.thêmHóaĐơnToolStripMenuItem_Click);
            // 
            // cậpNhậtHóaToolStripMenuItem
            // 
            this.cậpNhậtHóaToolStripMenuItem.Name = "cậpNhậtHóaToolStripMenuItem";
            this.cậpNhậtHóaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cậpNhậtHóaToolStripMenuItem.Text = "Cập nhật hóa đơn";
            this.cậpNhậtHóaToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtHóaToolStripMenuItem_Click);
            // 
            // xóaHóaĐơnToolStripMenuItem
            // 
            this.xóaHóaĐơnToolStripMenuItem.Name = "xóaHóaĐơnToolStripMenuItem";
            this.xóaHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xóaHóaĐơnToolStripMenuItem.Text = "Xóa hóa đơn";
            this.xóaHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xóaHóaĐơnToolStripMenuItem_Click);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(58, 367);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(151, 40);
            this.buttonTimKiem.TabIndex = 2;
            this.buttonTimKiem.Text = "Tìm Kiếm Hóa Đơn";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Location = new System.Drawing.Point(92, 100);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(77, 22);
            this.textBoxMaHD.TabIndex = 3;
            // 
            // D1
            // 
            this.D1.Location = new System.Drawing.Point(38, 227);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(200, 22);
            this.D1.TabIndex = 4;
            this.D1.Value = new System.DateTime(2024, 7, 26, 0, 0, 0, 0);
            // 
            // D2
            // 
            this.D2.Location = new System.Drawing.Point(38, 281);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(200, 22);
            this.D2.TabIndex = 5;
            this.D2.Value = new System.DateTime(2024, 7, 26, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập mã hóa đơn để tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chọn thời gian để tìm kiếm:";
            // 
            // FormQLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.textBoxMaHD);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormQLBH";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.FormQLBH_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpTheoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpTheoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxMaHD;
        private System.Windows.Forms.DateTimePicker D1;
        private System.Windows.Forms.DateTimePicker D2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}