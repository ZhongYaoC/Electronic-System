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
    public partial class SupplierManage : Form
    {
        public SupplierManage()
        {
            InitializeComponent();
            Init_gridview();
        }
        private void Init_gridview()
        {
            dataGridView1.DataSource = DBhelp.GetDataTable("select * from supplier_info");
        }

        private void ClearTextBox()
        {
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //query 
        private void button1_Click(object sender, EventArgs e)
        {
            string id = "";
            string name = "";
            string addr = "";
            try
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "供应商名称":
                        name = textBox1.Text.ToString();
                        break;
                    case "供应商ID":
                        id = textBox1.Text.ToString();
                        break;
                    case "供应商所在地":
                        addr = textBox1.Text.ToString();
                        break;
                    default:
                        MessageBox.Show("请勿修改选项");
                        break;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("请勿修改选项");
            }
            DataTable data= SupplierHelp.QuerySupplier(id,name,addr);
            if (data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("不存在该供应商");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        //add
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox3.Text.ToString();
                string addr = textBox4.Text.ToString();
                SupplierHelp.AddSupplier(name, addr);
                MessageBox.Show("增加成功");
                Init_gridview();
                ClearTextBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //update
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox2.Text.ToString();
                string name = textBox3.Text.ToString();
                string addr = textBox4.Text.ToString();
                SupplierHelp.UpdateSupplier(id,name,addr);
                MessageBox.Show("更新成功");
                Init_gridview();
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //delete
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox2.Text.ToString();
                SupplierHelp.DeleteSupplier(id);
                MessageBox.Show("删除成功");
                Init_gridview();
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
