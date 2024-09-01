using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHUONG_6
{
    public partial class FormQLBH : Form
    {
        private SqlConnection cnn = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=BanHang_c#;Integrated Security=True");

        public FormQLBH()
        {
            InitializeComponent();
        }

        // Hàm kết nối cơ sở dữ liệu và lấy dữ liệu
        private void ketnoicsdl()
        {
            string sql = "SELECT * FROM HoaDon";
            DataTable dt = ExecuteQuery(sql);
            if (dt != null)
            {
                dataGridView1.DataSource = dt; // Đổ dữ liệu vào DataGridView
            }
        }

        // Hàm thực thi câu lệnh SQL và trả về DataTable
        private DataTable ExecuteQuery(string query)
        {
            try
            {
                cnn.Open();
                SqlCommand com = new SqlCommand(query, cnn);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return null;
            }
            finally
            {
                cnn.Close();
            }
        }



        // Các phương thức sự kiện khác
        private void sắpXếpTheoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HoaDon ORDER BY ThanhTien ASC";
            DataTable sortedData = ExecuteQuery(query);
            if (sortedData != null)
            {
                dataGridView1.DataSource = sortedData;
            }
        }

        private void thêmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemHD them = new FormThemHD();
            this.Hide();
            them.ShowDialog();
            this.Show();
            ketnoicsdl();
        }

        private void cậpNhậtHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSuaHD sua = new FormSuaHD();
            this.Hide();
            sua.ShowDialog();
            this.Show();
            ketnoicsdl();
        }

        private void xóaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXoaHD xoa = new FormXoaHD();
            this.Hide();
            xoa.ShowDialog();
            this.Show();
            ketnoicsdl();
        }

        private void sắpXếpTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HoaDon ORDER BY NgayBan ASC";
            DataTable sortedData = ExecuteQuery(query);
            if (sortedData != null)
            {
                dataGridView1.DataSource = sortedData;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormQLBH_Load_1(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các điều khiển
                string maHoaDon = textBoxMaHD.Text.Trim();
                DateTime? tuNgay = D1.Checked ? (DateTime?)D1.Value : null;
                DateTime? denNgay = D2.Checked ? (DateTime?)D2.Value : null;

                // Xây dựng câu lệnh SQL
                string query = "SELECT * FROM HoaDon WHERE 1=1"; // 1=1 là điều kiện luôn đúng, giúp dễ dàng nối thêm các điều kiện khác

                if (!string.IsNullOrEmpty(maHoaDon))
                {
                    query += " AND MaHoaDon = @MaHoaDon";
                }

                if (tuNgay.HasValue)
                {
                    query += " AND NgayBan >= @TuNgay";
                }

                if (denNgay.HasValue)
                {
                    query += " AND NgayBan <= @DenNgay";
                }

                // Kết nối tới cơ sở dữ liệu và thực hiện tìm kiếm
                using (SqlConnection connection = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=BanHang_c#;Integrated Security=True"))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    if (!string.IsNullOrEmpty(maHoaDon))
                    {
                        command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    }

                    if (tuNgay.HasValue)
                    {
                        command.Parameters.AddWithValue("@TuNgay", tuNgay.Value);
                    }

                    if (denNgay.HasValue)
                    {
                        command.Parameters.AddWithValue("@DenNgay", denNgay.Value);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Hiển thị kết quả tìm kiếm
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

    }
}
