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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = user_name.Text.ToString();
            string passw = pwd.Text.ToString();
            string repassw = repwd.Text.ToString();

            if (uname.Equals("")||passw.Equals("")||repwd.Equals(""))
            {
                MessageBox.Show("请完善信息！");
            }
            else
            {
                if (!passw.Equals(repassw))
                {
                    MessageBox.Show("两次密码不同");
                }
                else
                {
                    if (UserHelp.Insert_uinfo(uname, passw))
                    {
                        MessageBox.Show("录入成功！您申请的账号为:"+UserHelp.Get_num(uname, passw));
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("录入失败！");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
