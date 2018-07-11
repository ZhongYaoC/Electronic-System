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
    public partial class MaintainPlan : Form
    {
        public MaintainPlan()
        {
            InitializeComponent();
            Init_gridview();
        }

        //维修计划显示
        private void Init_gridview()
        {
            dataGridView1.DataSource = MaintainHelper.GetPlan();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
