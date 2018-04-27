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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            tip1.Text = "";
            tip2.Text = "";
            if (username.Text == ""&& pwd.Text == "" )
            {
                tip1.Text = "用户名不能为空！";
                tip2.Text = "密码不能为空！";
                return;
            }
            if (username.Text == "")
            {
                tip1.Text = "用户名不能为空！";
                return;
            }
            if (pwd.Text == "")
            {
                tip2.Text = "密码不能为空！";
                return;
            }
            DataSet dsname = DB.GetDs("select StuName from student");
            DataView dv1 = dsname.Tables[0].DefaultView;
            DataSet dspwd = DB.GetDs("select StuPwd from student");
            DataView dv2 = dspwd.Tables[0].DefaultView;
            DataSet dstname = DB.GetDs("select tname from teacher");
            DataView dv3 = dsname.Tables[0].DefaultView;
            DataSet dstpwd = DB.GetDs("select tpwd from teacher");
            DataView dv4 = dstpwd.Tables[0].DefaultView;


            for (int i = 0; i < dv1.Count; i++)
            {
                String stuname = Convert.ToString(dv1[i]["StuName"]);
                String password = Convert.ToString(dv2[i]["StuPwd"]);
                String tname = Convert.ToString(dv3[i]["tname"]);
                String tpwd = Convert.ToString(dv4[i]["tpwd"]);

                if (username.Text == stuname && pwd.Text == password && sturadio.Checked)
                {
                    MessageBox.Show("学生端登录成功！");
                    StuMainform mainform = new StuMainform();
                    mainform.Text = stuname + "已登录！";
                    this.Visible = false;
                    mainform.ShowDialog();
                    this.Close();
                }
                else if (username.Text == stuname && pwd.Text == password && teachradio.Checked)
                {
                    MessageBox.Show("没有权限！");
                    return;
                }
                else if (username.Text == tname && pwd.Text == tpwd && sturadio.Checked)
                {
                    MessageBox.Show("学生端登录成功！");
                    StuMainform mainform = new StuMainform();
                    mainform.Text = tname + "已登录！";
                    this.Visible = false;
                    mainform.ShowDialog();
                    this.Visible = true;
                }
                else if (username.Text == tname && pwd.Text == tpwd && teachradio.Checked)
                {
                    MessageBox.Show("教师端登录成功！");
                    TeaMainform teamainform = new TeaMainform();
                    teamainform.Text = tname + "已登录！";
                    this.Visible = false;
                    teamainform.ShowDialog();
                    this.Visible = true;
                }else
                {
                    if (i == dv1.Count - 1)
                    {
                        tip1.Text = "用户名或密码错误！";
                        return;
                    }
                }

            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            tip1.Text = "";
            tip2.Text = "";
            username.Text = "";
            pwd.Text = "";
        }
    }
}
