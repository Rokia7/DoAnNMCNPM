using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmXacNhan : Form
    {
        public frmXacNhan()
        {
            InitializeComponent();
        }
        string hienthicauhoi = "";
        string yes;
        string no;
        public frmXacNhan(string cauhoi,string thuchien, string khongthuchien)
        {
            hienthicauhoi = cauhoi;
            yes = thuchien;
            no = khongthuchien;
            InitializeComponent();
        }
        private void frmXacNhan_Load(object sender, EventArgs e)
        {
            lblCauHoi.Text = hienthicauhoi;
            btnDongY.Text = yes;
            btnHuy.Text = no;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMiniSize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

    }
}
