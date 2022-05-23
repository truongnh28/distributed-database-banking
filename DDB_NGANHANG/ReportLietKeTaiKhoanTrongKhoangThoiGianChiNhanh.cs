using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DDB_NGANHANG
{
    public partial class ReportLietKeTaiKhoanTrongKhoangThoiGianChiNhanh : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportLietKeTaiKhoanTrongKhoangThoiGianChiNhanh(string ngayBD, string ngayKT, string macn, string chiNhanhViet)
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = DAO.connstr;
            sqlDataSource1.Queries[0].Parameters[0].ValueInfo = ngayBD;
            sqlDataSource1.Queries[0].Parameters[1].ValueInfo = ngayKT;
            sqlDataSource1.Queries[0].Parameters[2].ValueInfo = macn;
            sqlDataSource1.Fill();
            xrLabel1.Text = "Từ ngày " + ngayBD;
            xrLabel2.Text = "Đến ngày " + ngayKT;
            if (macn == "TANDINH" || macn == "BENTHANH")
            {
                label1.Text = "TÀI KHOẢN ĐƯỢC MỞ TẠI CHI NHÁNH " + chiNhanhViet;
            }
            else
            {
                label1.Text = "TÀI KHOẢN ĐƯỢC MỞ Ở CẢ " + chiNhanhViet;
            }
        }

    }
}
