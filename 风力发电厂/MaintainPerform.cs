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
    public partial class MaintainPerform : Form
    {
        public MaintainPerform()
        {
            InitializeComponent();
            Init_gridview();
        }

        //施工状况显示
        private void Init_gridview()
        {
            dataGridView1.DataSource = MaintainHelper.GetAccomplish();
        }

        //提前完工
        private void button1_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(textBox1.Text);
            try
            {
                MaintainHelper.UpdateMalfunc(id);
                MessageBox.Show("该机器已维护完成");
                Init_gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
