using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMuaNguyenVatLieu frm = new frmMuaNguyenVatLieu();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmQuanLyKho frm = new frmQuanLyKho();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }


        private void btnQuanLyDoanhThu_Click(object sender, EventArgs e)
        {
            frmQuanLyDoanhThu frm = new frmQuanLyDoanhThu();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
