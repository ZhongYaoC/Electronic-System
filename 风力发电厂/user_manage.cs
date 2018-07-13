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
    public partial class User_manage : Form
    {
        string limit = "";
        public User_manage()
        {
            InitializeComponent();
            Init_view();
        }

        private void Init_view()
        {
            Manage_view.DataSource = UserHelp.Get_userable();
        }

        private void User_manage_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = Manage_view.Rows[e.RowIndex].Cells[1].Value.ToString();
            pwd.Text = Manage_view.Rows[e.RowIndex].Cells[2].Value.ToString();
            limit = Manage_view.Rows[e.RowIndex].Cells[3].Value.ToString();
            switch (limit)
            {
                case "0":
                    radioButton1.Checked = true;
                    break;
                case "1":
                    radioButton2.Checked = true;
                    break;
                case "2":
                    radioButton3.Checked = true;
                    break;
                default:
                    MessageBox.Show("权限异常！");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = label2.Text.ToString();
            if(radioButton1.Checked == true)
            {
                limit = "0";
            }
            else if(radioButton2.Checked == true)
            {
                limit = "1";
            }
            else
            {
                limit = "2";
            }

            if (UserHelp.Change_info(uname, pwd.Text.ToString(), limit))
            {
                MessageBox.Show("修改成功！");
                Init_view();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
    }
}
