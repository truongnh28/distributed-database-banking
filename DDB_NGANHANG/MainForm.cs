using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDB_NGANHANG
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void xacNhanDangNhapBtn_Click(object sender, EventArgs e)
        {
            GiaoDichForm fm = new GiaoDichForm();
            fm.StartPosition = FormStartPosition.CenterParent;
            fm.ShowDialog(this);
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }

        private void thoatDangNhapBtn_Click(object sender, EventArgs e)
        {
            ChuyenChiNhanhForm fmm = new ChuyenChiNhanhForm();
            fmm.StartPosition = FormStartPosition.CenterParent;
            fmm.ShowDialog(this);
        }
    }
}