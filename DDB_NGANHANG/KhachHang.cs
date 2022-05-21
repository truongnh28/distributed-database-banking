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
    public partial class KhachHang : DevExpress.XtraEditors.XtraForm
    {
        DataGridViewRow dt;
        public KhachHang(DataGridViewRow dt)
        {
            this.dt = dt;
            InitializeComponent();
        }

        private void xacNhanThemKhachHangTxt_Click(object sender, EventArgs e)
        {
            //if.....
            String gioiTinh = namKhachHangFormRadio.Checked ? "Nam" : "Nữ";
            DateTime dateTime = DateTime.ParseExact(DateTime.Today.ToString("dd'-'MM'-'yyyy HH:mm:ss"), "dd'-'MM'-'yyyy HH:mm:ss", null);
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            String cmd = $"INSERT INTO DBO.KhachHang VALUES ({cmndThemKHTxt.Text}, {hoThemKHTxt.Text}, {tenThemKHTxt.Text}, {diaChiThemKHTxt.Text}, {gioiTinh}, {date}, {sdtThemKHTxt.Text}, {dt.Cells[2]})";
            DAO.ExecSqlNonQuery(cmd, DAO.connstr);
        }

        private void thoatThemKhachHangTxt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}