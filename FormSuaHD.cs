using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHUONG_6
{
    public partial class FormSuaHD : Form
    {
        public FormSuaHD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCapNhatHD_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các điều khiển người dùng
                int id = int.Parse(textBoxMaHD.Text);
                string tenHang = textBoxTenSP.Text.Trim();
                DateTime ngayBan = D0.Value;

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

                    // Xây dựng câu lệnh SQL để cập nhật thông tin hóa đơn
                    string query = @"
                UPDATE HoaDon
                SET NgayBan = @NgayBan, 
                    TenHang = @TenHang, 
                    DonGia = @DonGia, 
                    SoLuong = @SoLuong
                WHERE MaHoaDon = @MaHoaDon";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@NgayBan", ngayBan);
                        command.Parameters.AddWithValue("@TenHang", tenHang);
                        command.Parameters.AddWithValue("@DonGia", donGia);
                        command.Parameters.AddWithValue("@SoLuong", soLuong);
                        command.Parameters.AddWithValue("@MaHoaDon", id);

                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bản ghi nào bị ảnh hưởng không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật hóa đơn thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn với mã số này.");
                        }
                    }
                }
                // Đóng form xóa sau khi hoàn tất
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
