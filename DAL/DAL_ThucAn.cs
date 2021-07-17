using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DAL
{
    class DAL_ThucAn
    {
        private static DAL_ThucAn _Instance;
        public static DAL_ThucAn Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_ThucAn();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetAllThucAn()
        {
            DataTable dt = new DataTable();
            string query = @"select TTA.MaLoaiThucAn, TTA.TenThucAn, KC.TenKichCo, TAs.GiaBan from dbo.ThucAns TAs join dbo.TenThucAn TTA on TAs.MaThucAn = TTA.MaThucAn
            join dbo.KichCoThucAn KC on TAs.MaKichCo = KC.MaKichCo";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
    }
}
