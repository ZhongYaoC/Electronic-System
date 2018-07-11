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
    public partial class OrderManage : Form
    {
        public OrderManage()
        {
            InitializeComponent();
            Init_gridview();
        }

        private void Init_gridview()
        {
            dataGridView1.DataSource = SupplierHelp.GetOrder();
        }
    }
}
