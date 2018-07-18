using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class MachineHelp
    {
        public static DataTable Get_fanview()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select Machine_id,数据载入时间,功率,额定风速,扫风面积,抗最大风速 from machine_data");
            return DBhelp.GetDataTable(stringBuilder.ToString());
        }

        public static DataTable Get_fanview(string fid)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select Machine_id,数据载入时间,功率,额定风速,扫风面积,抗最大风速 from machine_data");
            stringBuilder.Append(" where Machine_id = " + fid);
            return DBhelp.GetDataTable(stringBuilder.ToString());
        }
    }
}
