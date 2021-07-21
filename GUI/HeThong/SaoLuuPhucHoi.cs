using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_ver5.BLL;

namespace DoAn_ver5.GUI.HeThong
{
    public partial class SaoLuuPhucHoi : Form
    {
        public SaoLuuPhucHoi()
        {
            InitializeComponent();
        }

        private void btnDuyetSaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDuyetSaoLuu.Text = fbd.SelectedPath;
                btnDuyetSaoLuu.Enabled = true;
            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            if (txtDuyetSaoLuu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đường dẫn sao lưu.");
            }
            else
            {
                if (BLL_BackupAndRestore.Instance.Backup(txtDuyetSaoLuu.Text) == true)
                {
                    MessageBox.Show("Sao lưu thành công !!!");
                }
                else
                {
                    MessageBox.Show("Sao lưu thất bại.");
                }
            }
        }

        private void btnDuyetPhucHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDuyetKhoiPhuc.Text = ofd.FileName;
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (txtDuyetKhoiPhuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đường dẫn sao lưu.");
            }
            else
            {
                if (BLL_BackupAndRestore.Instance.Restore(txtDuyetKhoiPhuc.Text) == true)
                {
                    MessageBox.Show("Khôi phục thành công !!!");
                }
                else
                {
                    MessageBox.Show("Khôi phục thất bại.");
                }
            }
        }
    }
}
