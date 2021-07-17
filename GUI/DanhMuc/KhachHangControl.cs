using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.GUI
{
    public partial class KhachHangControl : UserControl
    {
        private static KhachHangControl _instance;
        public static KhachHangControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KhachHangControl();
                return _instance;
            }
        }
        public KhachHangControl()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
