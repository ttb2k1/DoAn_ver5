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
    public partial class ThucAnControl : UserControl
    {
        private static ThucAnControl _instance;
        public static ThucAnControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ThucAnControl();
                return _instance;
            }
        }
        public ThucAnControl()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThucAn_ThemThucAn frm = new ThucAn_ThemThucAn();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
