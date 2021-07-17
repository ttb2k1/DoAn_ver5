﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_ver5.DTO;
using DoAn_ver5.DAL;

namespace DoAn_ver5.BLL
{
    class BLL_SuatChieu
    {
        private static BLL_SuatChieu _Instance;
        public static BLL_SuatChieu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_SuatChieu();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DTO_SuatChieu GetSuatChieuByMaSuatChieu(string MaSuatChieu)
        {
            DataRow row = DAL_SuatChieu.Instance.GetSuatChieuByMaSuatChieu(MaSuatChieu).Rows[0];
            return new DTO_SuatChieu
            {
                MaSuatChieu = row["MaSuatChieu"].ToString(),
                PhongChieu = row["TenPhongChieu"].ToString(),
                NgayGio = (DateTime)row["NgayGio"],
                //GiaVe = ()row["GiaVe"]
                GiaVe = float.Parse(row["GiaVe"].ToString())
            };
        }
        public DataTable GetSuatChieusByTenPhim(string tenPhim)
        {
            return DAL_SuatChieu.Instance.GetSuatChieusByTenPhim(tenPhim);
        }

        public DataTable GetDoanhThuByTimePeriod(string TenPhim, string TuNgay, string DenNgay)
        {
            return DAL_SuatChieu.Instance.GetDoanhThuByTimePeriod(TenPhim, TuNgay, DenNgay);
        }
    }
}
