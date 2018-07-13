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
    public partial class Component_manage : Form
    {
        string cnum = "";
        public Component_manage()
        {
            InitializeComponent();
            Init_view();
        }

        private void Init_view()
        {
            dataGridView1.DataSource = CompHelp.Get_comtable();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cnum = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            comp_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CompHelp.Change_info(cnum, comp_name.Text))
            {
                MessageBox.Show("修改成功！");
                Init_view();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CompHelp.Delete_info(cnum))
            {
                MessageBox.Show("删除成功！");
                Init_view();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CompHelp.Insert_info(cname.Text))
            {
                MessageBox.Show("添加成功！");
                Init_view();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
