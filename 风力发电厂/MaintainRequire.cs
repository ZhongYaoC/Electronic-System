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
    public partial class MaintainRequire : Form
    {
        public MaintainRequire()
        {
            InitializeComponent();
            Init_gridview();
        }

        //维修需求显示
        private void Init_gridview()
        {
            dataGridView1.DataSource = MaintainHelper.GetMainTainPlan();
        }

        private void ClearTextBox()
        {
            M_id.Text = "";
            textBox2.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            M_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        //执行当前维护
        private void button1_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(M_id.Text.ToString());
            int duration = Convert.ToInt32(textBox2.Text.ToString());
            string start_date = dateTimePicker1.Value.ToString();
            try
            {
                MaintainHelper.Updateconfig(id, duration, start_date);
                MessageBox.Show("修改成功");
                Init_gridview();
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
