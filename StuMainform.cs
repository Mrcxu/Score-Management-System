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
    public partial class StuMainform : Form
    {
        public StuMainform()
        {
            InitializeComponent();
        }
        public Window_Stumark window_Stumark;
        public Window_Stuupdate window_Stuupdate;
        public Window_Stuinsert window_Stuinsert;
        public Window_Stuchangepwd window_Stuchangepwd;
        private void StuMainform_Load(object sender, EventArgs e)
        {
            window_Stumark = new Window_Stumark();
            window_Stuupdate = new Window_Stuupdate();
            window_Stuinsert = new Window_Stuinsert();
            window_Stuchangepwd = new Window_Stuchangepwd();
            StugroupBox.Visible = false;
        }

        private void stuMark_Click(object sender, EventArgs e)
        {
            StugroupBox.Visible = true;
            window_Stumark.Show();
            StugroupBox.Controls.Clear();
            StugroupBox.Controls.Add(window_Stumark);
        }

        private void stuUpdate_Click(object sender, EventArgs e)
        {
            StugroupBox.Visible = true;
            window_Stuupdate.Show();
            StugroupBox.Controls.Clear();
            StugroupBox.Controls.Add(window_Stuupdate);
        }

        private void stuInsert_Click(object sender, EventArgs e)
        {
            StugroupBox.Visible = true;
            window_Stuinsert.Show();
            StugroupBox.Controls.Clear();
            StugroupBox.Controls.Add(window_Stuinsert);
        }

        private void stuChangepwd_Click(object sender, EventArgs e)
        {
            StugroupBox.Visible = true;
            window_Stuchangepwd.Show();
            StugroupBox.Controls.Clear();
            StugroupBox.Controls.Add(window_Stuchangepwd);
        }

        private void stuExit_Click(object sender, EventArgs e)
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
