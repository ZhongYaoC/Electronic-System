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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = textBox1.Text.ToString();
            string pwd = textBox2.Text.ToString();
            string limit = "";
            if (uid.Equals("") && pwd.Equals(""))
            {
                MessageBox.Show("账号密码不能为空！");
            }
            else if (uid.Equals(""))
            {
                MessageBox.Show("账号不能为空！");
            }
            else if (pwd.Equals(""))
            {
                MessageBox.Show("密码不能为空！");
            }
            else
            {
                switch (comboBox1.SelectedItem.ToString().Trim())
                {
                    case "普通员工":
                        limit = "0";
                        break;
                    case "高级工程师":
                        limit = "1";
                        break;
                    case "系统管理员":
                        limit = "2";
                        break;
                    default:
                        MessageBox.Show("身份选择异常！");
                        break;
                }
                if (!limit.Equals(""))
                {
                    if(UserHelp.User_Login(uid, pwd, limit))
                    {

                        Form form = new FormMain();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("密码错误！");
                    }
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
