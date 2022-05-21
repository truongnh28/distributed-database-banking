using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDB_NGANHANG
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        bool fl = false;
        int idx = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        public static void EnableTab(TabPage page, bool enable)
        {
            EnableControls(page.Controls, enable);
        }
        private static void EnableControls(Control.ControlCollection ctls, bool enable)
        {
            foreach (Control ctl in ctls)
            {
                ctl.Enabled = enable;
                EnableControls(ctl.Controls, enable);
            }
        }

        private void xacNhanDangNhapBtn_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)chiNhanhDangNhapComboBox.SelectedItem;
            DAO.servername = drv["TENSERVER"].ToString();
            DAO.username = taiKhoanDangNhapTxt.Text;
            DAO.password = matKhauDangNhapTxt.Text;
            if (DAO.KetNoi() == 1) return;
            String cmd = $"EXEC dbo.sp_DangNhap '{DAO.username}'";
            DataTable dt = DAO.ExecSqlDataTable(cmd, false);
            maNVToolTrip.Text = "MaNV: " + (string)dt.Rows[0][0];
            hoTenToolTrip.Text = "Họ tên: " + (string)dt.Rows[0][1];
            nhomToolTrip.Text = "Nhóm: " + (string)dt.Rows[0][2];
            maNVToolTrip2.Text = "MaNV: " + (string)dt.Rows[0][0];
            hoTenToolTrip2.Text = "Họ tên: " + (string)dt.Rows[0][1];
            nhomToolTrip2.Text = "Nhóm: " + (string)dt.Rows[0][2];
            maNVToolTrip3.Text = "MaNV: " + (string)dt.Rows[0][0];
            hoTenToolTrip3.Text = "Họ tên: " + (string)dt.Rows[0][1];
            nhomToolTrip3.Text = "Nhóm: " + (string)dt.Rows[0][2];
            //MessageBox.Show("Đăng nhập thành công");
            enableTagLogin(true);
            fl = true;
            if(dt.Rows[0][2].ToString().Equals("NganHang"))
            {
                khachHangPanel.Enabled = false;
                nhanVienPanel.Enabled = false;
            }
            if (!fl) return;
            cmd = "EXEC [DBO].[SP_DANHSACHNHANVIEN]";
            dt = DAO.ExecSqlDataTable(cmd, false);
            nhanVienTable.DataSource = dt;
            cmd = "EXEC [DBO].[SP_DANHSACHKHACHHANG]";
            dt = DAO.ExecSqlDataTable(cmd, false);
            khachHangTable.DataSource = dt;
            showInfoKhachHang();
            showInfoNhanVien();
        }

        private void thoatDangNhapBtn_Click(object sender, EventArgs e)
        {
            taiKhoanDangNhapTxt.Text = "";
            matKhauDangNhapTxt.Text = "";
        }

        private void traCuuTCBtn_Click(object sender, EventArgs e)
        {
            TraCuuKhachHangForm fmm = new TraCuuKhachHangForm();
            fmm.StartPosition = FormStartPosition.CenterParent;
            fmm.ShowDialog(this);
        }
        private void process()
        {
            //if(systemControl.SelectedIndex == 0)
            //{
            //    MessageBox.Show(systemControl.SelectedTab.Text);
            //}
            //else if(systemControl.SelectedIndex == 1)
            //{
            //    MessageBox.Show(systemControl.SelectedTab.Text);
            //}
            //else
            //{
            //    MessageBox.Show(systemControl.SelectedTab.Text);
            //}

        }
        private void systemControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(systemControl.SelectedIndex == 0)
            {

            }
            else if(systemControl.SelectedIndex == 1)
            {
                
                
            }
            else if(systemControl.SelectedIndex == 2)
            {

            }
            process();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (DAO.ketNoiDBGoc() == 1) return;
            String cmd = "SELECT * FROM VIEW_DanhSachPhanManh";
            DAO.chiNhanhDT = DAO.ExecSqlDataTable(cmd, true);
            DAO.chiNhanhDT.Rows[1].Delete();
            DAO.chiNhanhDT.AcceptChanges();
            chiNhanhDangNhapComboBox.DataSource = DAO.chiNhanhDT;
            chiNhanhDangNhapComboBox.ValueMember = "TENSERVER";
            chiNhanhDangNhapComboBox.DisplayMember = "TENCN";
            taiKhoanTaoTaiKhoangComboBox.DataSource = DAO.chiNhanhDT;
            taiKhoanTaoTaiKhoangComboBox.ValueMember = "TENSERVER";
            taiKhoanTaoTaiKhoangComboBox.DisplayMember = "TENCN";
            DAO.conn.Close();
            enableTagLogin(false);
        }
        private void enableTagLogin(bool flag)
        {
            EnableTab(systemControl.TabPages[systemControl.SelectedIndex = 1], flag);
            EnableTab(systemControl.TabPages[systemControl.SelectedIndex = 2], flag);
            EnableTab(subSystemControl.TabPages[subSystemControl.SelectedIndex = 1], flag);
            EnableTab(subSystemControl.TabPages[subSystemControl.SelectedIndex = 2], flag);
            //EnableTab(subSystemControl.TabPages[subSystemControl.SelectedIndex = 3], flag);
            EnableTab(subSystemControl.TabPages[subSystemControl.SelectedIndex = 0], !flag);
            systemControl.SelectedIndex = 0;
            subSystemControl.SelectedIndex = 0;
            
        }
        private void taiKhoanTaoTaiKhoanTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void xacNhanDangXuatTxt_Click(object sender, EventArgs e)
        {
            enableTagLogin(false);
            taiKhoanDangNhapTxt.Text = "";
            matKhauDangNhapTxt.Text = "";
            maNVToolTrip.Text = "MaNV";
            hoTenToolTrip.Text = "Họ tên";
            nhomToolTrip.Text = "Nhóm";
        }

        private void xacNhanThoatBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void subQuanLyControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            idx = 0;
        }


        private void showInfoNhanVien(bool f = false)
        {
            int idx = 0;
            if (f) idx = nhanVienTable.CurrentRow.Index;
            maNhanVienTxt.Text = nhanVienTable.Rows[idx].Cells[0].Value.ToString();
            hoNhanVienTxt.Text = nhanVienTable.Rows[idx].Cells[1].Value.ToString();
            tenNhanVienTxt.Text = nhanVienTable.Rows[idx].Cells[2].Value.ToString();
            diaChiNhanVienTxt.Text = nhanVienTable.Rows[idx].Cells[3].Value.ToString();
            sdtNhanVienTxt.Text = nhanVienTable.Rows[idx].Cells[5].Value.ToString();
            if (nhanVienTable.Rows[idx].Cells[4].Value.ToString().Equals("Nam"))
            {
                namNhanVienRadio.Checked = true;
                nuNhanVienRadio.Checked = !(namNhanVienRadio.Checked);
            }
            else
            {
                nuNhanVienRadio.Checked = true;
                namNhanVienRadio.Checked = !nuNhanVienRadio.Checked;
            }
        }
        private void showInfoKhachHang(bool f = false)
        {
            cmndKhachHangTxt.Text = khachHangTable.Rows[idx].Cells[2].Value.ToString();
            hoKhachHangTxt.Text = khachHangTable.Rows[idx].Cells[0].Value.ToString();
            tenKhachHangTxt.Text = khachHangTable.Rows[idx].Cells[1].Value.ToString();
            diaChiKhachHangTxt.Text = khachHangTable.Rows[idx].Cells[3].Value.ToString();
            sdtKhachHangTxt.Text = khachHangTable.Rows[idx].Cells[5].Value.ToString();
            if (khachHangTable.Rows[idx].Cells[4].Value.ToString().Equals("Nam"))
            {
                namKhachHangRadio.Checked = true;
                nuKhachHangRadio.Checked = !(namKhachHangRadio.Checked);
            }
            else
            {
                nuKhachHangRadio.Checked = true;
                namKhachHangRadio.Checked = !nuKhachHangRadio.Checked;
            }
        }
        private void khachHangTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = khachHangTable.CurrentRow.Index;
            showInfoKhachHang(true);
        }

        private void nhanVienTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = nhanVienTable.CurrentRow.Index;
            showInfoNhanVien(true);
        }

        private void themNhanVienBtn_Click(object sender, EventArgs e)
        {
            NhanVienForm nhanVienForm = new NhanVienForm(nhanVienTable.Rows[idx], true);
            nhanVienForm.StartPosition = FormStartPosition.CenterParent;
            nhanVienForm.ShowDialog(this);
        }

        private void xoaNhanVienBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn xóa nhân viên", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

            }
        }

        private void chinhSuaNhanVienBtn_Click(object sender, EventArgs e)
        { 
            NhanVienForm nhanVienForm = new NhanVienForm(nhanVienTable.Rows[idx], false);
            nhanVienForm.StartPosition = FormStartPosition.CenterParent;
            nhanVienForm.ShowDialog(this);
        }

        private void chuyenChiNhanhBtn_Click(object sender, EventArgs e)
        {

        }

        private void luuNhanVienBtn_Click(object sender, EventArgs e)
        {

        }
    }
}