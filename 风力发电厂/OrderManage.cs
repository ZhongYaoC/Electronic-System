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
using System.Data.SqlClient;

namespace 风力发电厂
{
    public partial class OrderManage : Form
    {
        public OrderManage()
        {
            InitializeComponent();
            Init_gridview();
            Init_chart();
        }

        private void Init_gridview()
        {
            dataGridView1.DataSource = SupplierHelp.GetOrder();
        }

        private void Init_chart()
        {
            chart1.Series.Clear();
            SqlDataReader gg = DBhelp.ExecuteReader("select top(5) sernum,Order_num from order_list order by sernum desc");
            chart1.DataBindTable(gg, "sernum");
            gg.Close();
            
        }

        private void OrderManage_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ser_connecter.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        //delete order
        private void button2_Click(object sender, EventArgs e)
        {
            string sernum = ser_connecter.Text.ToString();
            try
            {
                OrderHelp.deleteorder(sernum);
                MessageBox.Show("删除订购单成功");
                Init_gridview();
                Init_chart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //获取被选中的供应商
        private string SupSelect()
        {
            string str = "";
            foreach (RadioButton ct in groupBox1.Controls)
            {
                if (ct.Checked)
                {
                    str = ct.Text + str;
                }
            }
            return str.Replace("\r\n","");
        }

        //获取被选中的零部件
        private string ComSelect()
        {
            string str = "";
            for (int i = 0;i<checkedListBox2.Items.Count;i++)
            {
                if(checkedListBox2.GetItemChecked(i))
                {
                    checkedListBox2.SetSelected(i,true);
                    str += checkedListBox2.SelectedItem.ToString()+"," ;
                }
                else
                {
                    str += ",";
                }
            }
            //MessageBox.Show(str);
            return str;
        }

        //下达订单
        private void button1_Click(object sender, EventArgs e)
        {
            string ComName1 = "";
            string ComName2 = "";
            string ComName3 = "";
            string ComName4 = "";
            string ComName5 = "";
            int orderNum = Convert.ToInt32(textBox1.Text);
            string supName = SupSelect();
            string[] Comstr = ComSelect().Split(',');
            for(int i = 0; i < 5; i++)
            {
                ComName1 = Comstr[0];
                ComName2 = Comstr[1];
                ComName3 = Comstr[2];
                ComName4 = Comstr[3];
                ComName5 = Comstr[4];
            }
            try
            {
                OrderHelp.addOrder(orderNum,supName,ComName1, ComName2, ComName3, ComName4, ComName5);
                MessageBox.Show("订购单下达成功");
                Init_gridview();
                Init_chart();
                textBox1.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
