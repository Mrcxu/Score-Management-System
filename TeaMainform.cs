using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score_Management_System
{
    public partial class TeaMainform : Form
    {
        public TeaMainform()
        {
            InitializeComponent();
        }
        public Window_Tselect window_Tselect;
        public Window_TupdateAndDelete window_TupdateAndDelete;
        public Window_Tinsert window_Tinsert;
        public Window_Tchangepwd window_Tchangepwd;
        private void TeaMainform_Load(object sender, EventArgs e)
        {
            window_Tselect = new Window_Tselect();
            window_TupdateAndDelete = new Window_TupdateAndDelete();
            window_Tinsert = new Window_Tinsert();
            window_Tchangepwd = new Window_Tchangepwd();
            TgroupBox.Visible = false;
        }

        private void tselect_Click(object sender, EventArgs e)
        {
            TgroupBox.Visible = true;
            window_Tselect.Show();
            TgroupBox.Controls.Clear();
            TgroupBox.Controls.Add(window_Tselect);
        }

        private void tupdateanddelete_Click(object sender, EventArgs e)
        {
            TgroupBox.Visible = true;
            window_TupdateAndDelete.Show();
            TgroupBox.Controls.Clear();
            TgroupBox.Controls.Add(window_TupdateAndDelete);
        }

        private void tinsert_Click(object sender, EventArgs e)
        {
            TgroupBox.Visible = true;
            window_Tinsert.Show();
            TgroupBox.Controls.Clear();
            TgroupBox.Controls.Add(window_Tinsert);
        }

        private void tchangepwd_Click(object sender, EventArgs e)
        {
            TgroupBox.Visible = true;
            window_Tchangepwd.Show();
            TgroupBox.Controls.Clear();
            TgroupBox.Controls.Add(window_Tchangepwd);
        }

        private void tExit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要退出吗?", "退出系统", messButton);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
