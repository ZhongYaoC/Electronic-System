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
            Init();
        }

        private void Init_gridview()
        {
            dataGridView1.DataSource = SupplierHelp.GetOrder();
        }

        private void Init()
        {
            chart1.Series.Clear();
            SqlDataReader gg = DBhelp.ExecuteReader("select top(5) sernum,Order_num from order_list");
            chart1.DataBindTable(gg, "sernum");
            gg.Close();
        }

        private void OrderManage_Load(object sender, EventArgs e)
        {

        }
    }
}
