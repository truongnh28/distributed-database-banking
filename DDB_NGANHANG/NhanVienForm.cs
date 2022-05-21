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
    public partial class NhanVienForm : DevExpress.XtraEditors.XtraForm
    {
        DataGridViewRow dt;
        public NhanVienForm(DataGridViewRow dt, bool isAdd)
        {
            this.dt = dt;
            InitializeComponent();
            hoThemNVTxt.Focus();
            if (isAdd) return;
            maNVThemNVTxt.Enabled = false;
            maNVThemNVTxt.Text = dt.Cells[0].Value.ToString();
            hoThemNVTxt.Text = dt.Cells[1].Value.ToString();
            tenThemNVTxt.Text = dt.Cells[2].Value.ToString();
            diaChiThemNVTxt.Text = dt.Cells[3].Value.ToString();
            sdtThemNVTxt.Text = dt.Cells[5].Value.ToString();
            if (dt.Cells[4].Value.ToString().Equals("Nam"))
            {
                namNVRadio.Checked = true;
                nuNVRadio.Checked = !(namNVRadio.Checked);
            }
            else
            {
                nuNVRadio.Checked = true;
                namNVRadio.Checked = !nuNVRadio.Checked;
            }
            hoThemNVTxt.Focus();
        }

        private void xacNhanThemNVTxt_Click(object sender, EventArgs e)
        {
            //if...
            String gioiTinh = namNVRadio.Checked ? "Nam" : "Nữ";
            DateTime dateTime = DateTime.ParseExact(DateTime.Today.ToString("dd'-'MM'-'yyyy HH:mm:ss"), "dd'-'MM'-'yyyy HH:mm:ss", null);
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            int maNV = 0;
            String cmd = $"INSERT INTO DBO.NhanVien (MANV, HO, TEN, DIACHI, PHAI, SODT, MACN, TrangThaiXoa) VALUES ({maNV}, {hoThemNVTxt.Text}, {tenThemNVTxt.Text}, {diaChiThemNVTxt.Text}, {gioiTinh}, {sdtThemNVTxt.Text}, {dt.Cells[2]}, {0})";
            DAO.ExecSqlNonQuery(cmd, DAO.connstr);
        }

        private void thoatThemNVBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}