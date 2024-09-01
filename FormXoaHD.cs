using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHUONG_6
{
    public partial class FormXoaHD : Form
    {
        public FormXoaHD()
        {
            InitializeComponent();
        }

        private void buttonXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                string maHDText = textBoxMaHD.Text.Trim();

                // Kiểm tra nếu mã hóa đơn trốngs
                if (string.IsNullOrEmpty(maHDText))
                {
                    MessageBox.Show("Vui lòng nhập mã hóa đơn.");
                    return;
                }

                // Chuyển đổi mã hóa đơn từ chuỗi sang số nguyên
                int maHD;
                if (!int.TryParse(maHDText, out maHD))
                {
                    MessageBox.Show("Mã hóa đơn phải là số nguyên.");
                    return;
                }

                // Xác nhận xóa hóa đơn
                if (MessageBox.Show("Bạn có thật sự muốn xóa hóa đơn này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Kết nối cơ sở dữ liệu và thực hiện xóa
                    using (SqlConnection connection = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=BanHang_c#;Integrated Security=True"))
                    {
                        connection.Open();
                        string query = "DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số vào câu lệnh SQL
                            command.Parameters.AddWithValue("@MaHoaDon", maHD);
                            int rowsAffected = command.ExecuteNonQuery();

                            // Kiểm tra xem có bản ghi nào bị xóa không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy hóa đơn với mã này.");
                            }
                        }
                    }

                    // Đóng form xóa sau khi hoàn tất
                    this.DialogResult = DialogResult.OK; // Trả về kết quả OK cho form chính
                    this.Close(); // Đóng form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
