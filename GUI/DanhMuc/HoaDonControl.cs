using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.GUI.DanhMuc
{
    public partial class HoaDonControl : UserControl
    {
        private static HoaDonControl _instance;
        public static HoaDonControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HoaDonControl();
                return _instance;
            }
        }
        public HoaDonControl()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
