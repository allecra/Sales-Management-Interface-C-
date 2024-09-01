using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHUONG_6
{
    public partial class FormThemHD : Form
    {
        public FormThemHD()
        {
            InitializeComponent();
        }

        private void buttonThemHD_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các điều khiển người dùng
                string tenHang = textBoxTenSp.Text.Trim();
                DateTime ngayBan = D0.Value; // Sử dụng tên chính xác của DateTimePicker

                // Kiểm tra và lấy giá trị từ các TextBox
                decimal donGia;
                int soLuong;

                if (!decimal.TryParse(textBoxDonGia.Text, out donGia) ||
                    !int.TryParse(textBoxSoLuong.Text, out soLuong))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho đơn giá và số lượng.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=BanHang_c#;Integrated Security=True"))
                {
                    connection.Open();
                    // Xây dựng câu lệnh SQL để thêm hóa đơn vào cơ sở dữ liệu
                    string query = "INSERT INTO HoaDon (NgayBan, TenHang, DonGia, SoLuong) VALUES (@NgayBan, @TenHang, @DonGia, @SoLuong)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@NgayBan", ngayBan);
                        command.Parameters.AddWithValue("@TenHang", tenHang);
                        command.Parameters.AddWithValue("@DonGia", donGia);
                        command.Parameters.AddWithValue("@SoLuong", soLuong);

                        // Thực thi câu lệnh SQL
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm hóa đơn thành công!");
                    }
                }

                // Đóng form sau khi hoàn tất
                this.DialogResult = DialogResult.OK; // Trả về kết quả OK cho form chính
                this.Close(); // Đóng form
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
