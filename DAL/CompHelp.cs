using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CompHelp
    {
        public static bool Change_info(string cnum, string cname)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("update component_info set ");
            stringBuilder.Append("Component_name='");
            stringBuilder.Append(cname + "' ");
            stringBuilder.Append("where Component_id='");
            stringBuilder.Append(cnum + "'");
            int rows = DBhelp.ExecuteNonQuery(stringBuilder.ToString());

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Delete_info(string cnum)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("delete from component_info where Component_id='");
            stringBuilder.Append(cnum+"'");
            int rows = DBhelp.ExecuteNonQuery(stringBuilder.ToString());

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Insert_info(string cname)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("insert into component_info(Component_name) values('");
            stringBuilder.Append(cname + "')");
            int rows = DBhelp.ExecuteNonQuery(stringBuilder.ToString());

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable Get_comtable()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select * from component_info");
            return DBhelp.GetDataTable(stringBuilder.ToString());
        }
    }
}
