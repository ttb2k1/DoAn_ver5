using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_ver5.DTO;

namespace DoAn_ver5.DAL
{
    class DAL_Phim
    {
        private static DAL_Phim _Instance;
        public static DAL_Phim Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Phim();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public DataTable GetPhimByDate(DateTime date)
        {
            DataTable dt = new DataTable();
            string query = "exec USP_GetPhimByDateHaveParam @date";
            dt = DataProvider.Instance.ExecuteQueryParam(query, new object[] { date });
            return dt;
        }
        public DataTable GetAllPhim()
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.Phim";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }       
        public DataTable GetPhimByTenPhim(string TenPhim)
        {
            DataTable dt = new DataTable();
            string query = "select * from dbo.Phim where TenPhim = N'" + TenPhim + "'";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        //public DataTable GetPhimByTimePeriod(DateTime time1, DateTime time2)
        //{
        //    DataTable dt = new DataTable();
        //    string query = 
        //}
    }
}
