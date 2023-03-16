using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {

        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Thứ tự mặt hàng được chọn
            var stt = cbbTenHang.SelectedIndex; 
            //0,1,2 là vị trí các mặt hàng trong danh sách
            switch (stt)
            {
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "2000000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            double thanhTien = donGia * soLuong;
            if (rdChuyenKhoan.Checked)
                thanhTien = donGia * soLuong * 0.95;

            //Hiển thị kết quả
            lblSoTien.Text = thanhTien.ToString(); 
        }
    }
}
