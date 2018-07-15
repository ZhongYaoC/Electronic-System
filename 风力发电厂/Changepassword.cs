using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace 风力发电厂
{
    public partial class Changepassword : Form
    {
        public Changepassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new_password.Text = "";
            makesure_new_password.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p1 = new_password.Text.ToString().Trim();
            string p2 = makesure_new_password.Text.ToString().Trim();
            if (p1.Equals("") || p2.Equals(""))
            {
                MessageBox.Show("密码不能为空！");
            }
            else
            {
                if (!p1.Equals(p2))
                {
                    MessageBox.Show("两次密码必须相同！");
                }
                else
                {
                    if(UserHelp.Change_pwd(UserHelp.uid, p1))
                    {
                        MessageBox.Show("修改密码成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改密码失败！");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
