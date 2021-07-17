using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DAL
{
    class DAL_Ve
    {
        private static DAL_Ve _Instance;
        public static DAL_Ve Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Ve();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetListVeBySuatChieu(string MaSuatChieu)
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.GheNgoi join dbo.SuatChieu on GheNgoi.MaSuatChieu = SuatChieu.MaSuatChieu";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        public void SetTrangThaiVe(string maVe)
        {
            string query = "update dbo.GheNgoi set TinhTrang = 'true' where MaGhe = '" + maVe + "'";
            DataProvider.Instance.ExcuteDB(query);
        }
    }
}
