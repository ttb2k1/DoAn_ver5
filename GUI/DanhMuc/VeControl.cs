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
    public partial class VeControl : UserControl
    {
        private static VeControl _instance;
        public static VeControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VeControl();
                return _instance;
            }
        }
        public VeControl()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
