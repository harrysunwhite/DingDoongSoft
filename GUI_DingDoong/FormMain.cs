﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_DingDoong
{
    public partial class FormMain : Form
    {
        public static int session = 0;
        public static int profile = 0;
        public static int quyen;
        Thread th;


        public FormMain()
        {
            InitializeComponent();
            this.CenterToScreen();
            lblEmailMain.Text = FormLogin.NvMain.Email;
            quyen = FormLogin.NvMain.Quyen;
          

        }

        public void opennewapp()
        {
           FormLogin login = new FormLogin();
            

            Application.Run(login);
        }
        private void phanquyen()
        {
            pbNhanVien.Enabled = false;
            pnlNhanVien.BackColor = Color.Gray;
            pnlNhanVien.Enabled = false;

            pbMenu.Enabled = false;
            pnlMenu.Enabled = false;
            pnlMenu.BackColor = Color.Gray;

            pbThongKe.Enabled = false;
            pnlThongKe.Enabled = false;
            pnlThongKe.BackColor = Color.Gray;

            pbKhuyenMai.Enabled = false;
            pnlKhuyenMai.BackColor = Color.Gray;
            pnlKhuyenMai.Enabled = false;


        }

        private void pbAccounts_Click(object sender, EventArgs e)
        {
            FormChangePass formChangePass = new FormChangePass(lblEmailMain.Text);
            this.Hide();

            formChangePass.Closed += (s, args) => this.Close();
            formChangePass.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pbNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien nv = new FormNhanVien();
            this.Hide();

            nv.Closed += (s, args) => this.Close();
            nv.Show();
        }

        private void pbKhachHang_Click(object sender, EventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            this.Hide();

            kh.Closed += (s, args) => this.Close();
            kh.Show();
        }

        private void pbQuanLyBan_Click(object sender, EventArgs e)
        {
            FormKhuVucBan kv = new FormKhuVucBan(-1);
            this.Hide();

            kv.Closed += (s, args) => this.Close();
            kv.Show();
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            FormThucDon thucdon = new FormThucDon();
            this.Hide();

            thucdon.Closed += (s, args) => this.Close();
            thucdon.Show();
        }

        private void pbKhuyenMai_Click(object sender, EventArgs e)
        {
            FormKhuyenMai khuyenmai = new FormKhuyenMai();
            this.Hide();

            khuyenmai.Closed += (s, args) => this.Close();
            khuyenmai.Show();
        }

        private void pbThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe thongKe = new FormThongKe();
            this.Hide();

            thongKe.Closed += (s, args) => this.Close();
            thongKe.Show();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

            lbTime.Text = (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
            lbDate.Text = DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();
            lbMonth.Text = DateTime.Now.ToString("MMM");
            LbYear.Text = DateTime.Now.ToString("yyyy");
            lbDayofweek.Text = DateTime.Now.ToString("ddd");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lbTime.Text = (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
            lbDate.Text = DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();
            lbMonth.Text = DateTime.Now.ToString("MMM");
            LbYear.Text = DateTime.Now.ToString("yyyy");
            lbDayofweek.Text = DateTime.Now.ToString("ddd");
            if (quyen == 0)
            {
                phanquyen();
            }    
        }

        private void pnlThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe thongKe = new FormThongKe();
            this.Hide();

            thongKe.Closed += (s, args) => this.Close();
            thongKe.Show();
        }

        private void pnlQuanLyBan_Click(object sender, EventArgs e)
        {
            FormKhuVucBan kv = new FormKhuVucBan(-1);
            this.Hide();

            kv.Closed += (s, args) => this.Close();
            kv.Show();
        }

        private void pnlQuanLyBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Infor.Show(pictureBox1, -150, 25);
            }
        }

        private void InforNV_Click(object sender, EventArgs e)
        {
            FormThongTin frmThongTin = new FormThongTin();
            frmThongTin.Activate();
            frmThongTin.Show();
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewapp);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pbNhanVien_MouseEnter(object sender, EventArgs e)
        {
            pnlNhanVien.Location = new Point(48,90);
            pbNhanVien.Cursor = Cursors.Hand;

        }

        private void pbNhanVien_MouseLeave(object sender, EventArgs e)
        {
            pnlNhanVien.Location = new Point(48, 96);
            pbNhanVien.Cursor = Cursors.Default;


        }

        private void pbKhachHang_MouseEnter(object sender, EventArgs e)
        {
            pbKhachHang.Cursor = Cursors.Hand;
            pnlKhachHang.Location = new Point(179, 90);
        }

        private void pbKhachHang_MouseLeave(object sender, EventArgs e)
        {
            pbKhachHang.Cursor = Cursors.Default;
            pnlKhachHang.Location = new Point(179, 96);
        }

        private void pnlQuanLyBan_MouseEnter(object sender, EventArgs e)
        {
            pnlQuanLyBan.Location = new Point(54, 227);
            pnlQuanLyBan.Cursor = Cursors.Hand;

        }

        private void pnlQuanLyBan_MouseLeave(object sender, EventArgs e)
        {
            pnlQuanLyBan.Location = new Point(48, 227);
            pnlQuanLyBan.Cursor = Cursors.Default;
        }

        private void pbQuanLyBan_MouseEnter(object sender, EventArgs e)
        {
            pnlQuanLyBan.Location = new Point(54, 227);
            pbQuanLyBan.Cursor = Cursors.Hand;
        }

        private void pbQuanLyBan_MouseLeave(object sender, EventArgs e)
        {
            pnlQuanLyBan.Location = new Point(48, 227);
            pbQuanLyBan.Cursor = Cursors.Default;
        }

        private void pbCaiDat_MouseEnter(object sender, EventArgs e)
        {
            pnlCaiDat.Location = new Point(48, 364);
            pbCaiDat.Cursor = Cursors.Hand;
        }

        private void pbCaiDat_MouseLeave(object sender, EventArgs e)
        {
            pnlCaiDat.Location = new Point(48, 358);
            pbCaiDat.Cursor = Cursors.Default;
        }

        private void pbAccounts_MouseEnter(object sender, EventArgs e)
        {
            pnlAccounts.Location = new Point(179, 364);
            pbAccounts.Cursor = Cursors.Hand;
            
        }

        private void pbAccounts_MouseLeave(object sender, EventArgs e)
        {
            pnlAccounts.Location = new Point(179, 358);
            pbAccounts.Cursor = Cursors.Default;
        }

        private void pbMenu_MouseEnter(object sender, EventArgs e)
        {
            pnlMenu.Location = new Point(361, 93);
            pbMenu.Cursor = Cursors.Hand;
        }

        private void pbMenu_MouseLeave(object sender, EventArgs e)
        {
            pnlMenu.Location = new Point(361, 99);
            pbMenu.Cursor = Cursors.Default;

        }

        private void pbKhuyenMai_MouseEnter(object sender, EventArgs e)
        {
            pnlKhuyenMai.Location = new Point(492, 93);
            pbKhuyenMai.Cursor = Cursors.Hand;
        }

        private void pbKhuyenMai_MouseLeave(object sender, EventArgs e)
        {
            pnlKhuyenMai.Location = new Point(492, 99);
            pbKhuyenMai.Cursor = Cursors.Default;

        }

        private void pbThongKe_MouseEnter(object sender, EventArgs e)
        {
            pbThongKe.Cursor = Cursors.Hand;
            pnlThongKe.Location = new Point(367, 230);
        }

        private void pbThongKe_MouseLeave(object sender, EventArgs e)
        {
            pbThongKe.Cursor = Cursors.Default;
            pnlThongKe.Location = new Point(361, 230);
        }

        private void pnlThongKe_MouseEnter(object sender, EventArgs e)
        {
            pbThongKe.Cursor = Cursors.Hand;
            pnlThongKe.Location = new Point(367, 230);
        }

        private void pnlThongKe_MouseLeave(object sender, EventArgs e)
        {
            pbThongKe.Cursor = Cursors.Default;
            pnlThongKe.Location = new Point(361, 230);

        }

        private void pbHuongDan_MouseEnter(object sender, EventArgs e)
        {
            pbHuongDan.Cursor = Cursors.Hand;
            pnlHuongDan.Location = new Point(361, 367);
        }

        private void pbHuongDan_MouseLeave(object sender, EventArgs e)
        {
            pbHuongDan.Cursor = Cursors.Default;
            pnlHuongDan.Location = new Point(361, 361);
        }

        private void pbHoTro_MouseEnter(object sender, EventArgs e)
        {
            pbHoTro.Cursor = Cursors.Hand;
            pnlHoTro.Location = new Point(492, 367);
        }

        private void pbHoTro_MouseLeave(object sender, EventArgs e)
        {
            pbHoTro.Cursor = Cursors.Default;
            pnlHoTro.Location = new Point(492, 361);
        }

        private void pnlDongHo_MouseEnter(object sender, EventArgs e)
        {
            pnlDongHo.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlDongHo_MouseLeave(object sender, EventArgs e)
        {
            pnlDongHo.BorderStyle = BorderStyle.None;

        }

        private void lbTime_MouseEnter(object sender, EventArgs e)
        {
            pnlDongHo.BorderStyle = BorderStyle.Fixed3D;

        }

        private void lbTime_MouseLeave(object sender, EventArgs e)
        {
            pnlDongHo.BorderStyle = BorderStyle.None;

        }

        private void lbDate_MouseEnter(object sender, EventArgs e)
        {
            pnlDongHo.BorderStyle = BorderStyle.Fixed3D;

        }

        private void lbDate_MouseLeave(object sender, EventArgs e)
        {
            pnlDongHo.BorderStyle = BorderStyle.None;

        }

        private void lbDayofweek_MouseEnter(object sender, EventArgs e)
        {
            pnlDongHo.BorderStyle = BorderStyle.Fixed3D;


        }

        private void lbDayofweek_MouseLeave(object sender, EventArgs e)
        {
            pnlDongHo.BorderStyle = BorderStyle.None;

        }

        private void lbMonth_MouseEnter(object sender, EventArgs e)
        {
            pnlDongHo.BorderStyle = BorderStyle.Fixed3D;

        }

        private void lbMonth_MouseLeave(object sender, EventArgs e)
        {
            pnlDongHo.BorderStyle = BorderStyle.None;

        }

        private void LbYear_MouseEnter(object sender, EventArgs e)
        {
            pnlDongHo.BorderStyle = BorderStyle.Fixed3D;

        }

        private void LbYear_MouseLeave(object sender, EventArgs e)
        {
            pnlDongHo.BorderStyle = BorderStyle.None;

        }

        private void pbCaiDat_Click(object sender, EventArgs e)
        {
            FrmSetupBan frmSetting = new FrmSetupBan();
            frmSetting.FormClosed += FormMain_Load;
            frmSetting.Show();
        }

        private void pbHuongDan_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "Guide.docx");
                System.Diagnostics.Process.Start(path);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file is not found in the specified location");
            }
        }
    }
}
