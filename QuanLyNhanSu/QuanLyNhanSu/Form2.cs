using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "1. Nhấn nút Thêm để thêm mới nhân sự";
            label2.Text = "2. Click vào các dòng trong danh sách để lấy thông\n tin nhân sự";
            label3.Text = "3.Nhấn nút Sửa để cập nhật thông tin nhân sự";
            label4.Text = "4. Sau khi thêm hoặc sửa thông tin nhấn nút Lưu để\n lưu thông tin";
            label5.Text = "5. Chọn thông tin nhân sự và nhấn nút Xóa để xóa\n thông tin";
            label5.Text = "6. Nhấn nút Refresh để xóa trắng thông tin nhập lỗi";
            label6.Text = "7. Nhập thông tin cần tìm kiếm vào search-box và\n nhẫn vào biểu tượng kính lúp để tìm";
        }
    }
}
