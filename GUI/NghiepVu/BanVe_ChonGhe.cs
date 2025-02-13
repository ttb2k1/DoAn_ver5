﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_ver5.DTO;
using DoAn_ver5.BLL;

namespace DoAn_ver5.GUI.NghiepVu
{
    public partial class BanVe_ChonGhe : Form
    {
        DTO_SuatChieu Suatchieu;
        DTO_Phim Phim;

        //float GiaVe = 0;

        int SizeGhe = 30;
        int KhoangCachGhe = 7;

        List<DTO_Ve> listGhe = new List<DTO_Ve>();
        List<Button> listGheDaChon = new List<Button>();

        public BanVe_ChonGhe(DTO_SuatChieu SuatChieu, DTO_Phim Phim)
        {
            InitializeComponent();
            this.Suatchieu = SuatChieu;
            this.Phim = Phim;
        }

        private void BanVe_ChonGhe_Load(object sender, EventArgs e)
        {
            lblThongTin.Text = "PBL3 Movie Theater Project | "
                + Suatchieu.PhongChieu + " | " + Phim.TenPhim;
            lblThoiGian.Text = Suatchieu.NgayGio.Date.ToString();
            LoadPhongChieu(Suatchieu.PhongChieu);
            listGhe = BLL_Ve.Instance.GetListVeBySuatChieu(Suatchieu.MaSuatChieu);
            LoadGhe(listGhe);
        }

        private void LoadGhe(List<DTO_Ve> listGhe)
        {
            panelChonGhe.Controls.Clear();
            for (int i = 0; i < listGhe.Count; i++)
            {
                Button btnSeat = new Button() { Width = SizeGhe + 20, Height = SizeGhe };
                btnSeat.Text = listGhe[i].ChoNgoi;
                if (listGhe[i].Status == true)
                    btnSeat.BackColor = Color.Red;
                else
                    btnSeat.BackColor = Color.White;
                btnSeat.Click += BtnSeat_Click;
                panelChonGhe.Controls.Add(btnSeat);

                btnSeat.Tag = listGhe[i];
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Button btnSeat = sender as Button;
            if (btnSeat.BackColor == Color.White)
            {             
                btnSeat.BackColor = Color.Yellow;
                listGheDaChon.Add(btnSeat);
            }
            else if (btnSeat.BackColor == Color.Yellow)
            {
                btnSeat.BackColor = Color.White;
                listGheDaChon.Remove(btnSeat);
            }
            else if (btnSeat.BackColor == Color.Red)
            {
                MessageBox.Show("Ghế số [" + btnSeat.Text + "] đã có người mua");
            }   
        }

        private void LoadPhongChieu(string phongChieu)
        {
            DTO_PhongChieu PhongChieu = BLL_PhongChieu.Instance.GetPhongChieuByName(phongChieu);
            int row = PhongChieu.SoHangGhe;
            int col = PhongChieu.SoGheTren1Hang;
            panelChonGhe.Size = new Size((SizeGhe + 20 + KhoangCachGhe) * col, (SizeGhe + KhoangCachGhe) * row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listGheDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế trước khi thanh toán!");
                return;
            }
            BanVe_LuuVeBan frm = new BanVe_LuuVeBan(Phim, Suatchieu, listGheDaChon);
            //frm.Show();
            frm.ShowDialog();
            //LoadGhe(listGhe);
            ReLoad();
        }

        private void ReLoad()
        {
            LoadPhongChieu(Suatchieu.PhongChieu);
            listGhe = BLL_Ve.Instance.GetListVeBySuatChieu(Suatchieu.MaSuatChieu);
            LoadGhe(listGhe);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
