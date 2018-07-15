using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderHelp
    {
        public static bool deleteorder(string sernum)
        {
            StringBuilder deletestr = new StringBuilder();
            deletestr.Append("delete from order_list where sernum = '");
            deletestr.Append(sernum + "'");
            int row = DBhelp.ExecuteNonQuery(deletestr.ToString());
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      
        public static bool addOrder(int orderNum,string supName,string ComName1, string ComName2, string ComName3, string ComName4, string ComName5)
        {
            StringBuilder addstr = new StringBuilder();
            addstr.Append("insert into order_list select Su.Supplier_id, Co.Component_id, Order_num = ");
            addstr.Append(orderNum);
            addstr.Append(" from( select Supplier_id from supplier_info where Supplier_name = '");
            addstr.Append(supName);
            addstr.Append("') as Su, (select Component_id from component_info where Component_name='");
            addstr.Append(ComName1+ "' or Component_name='");
            addstr.Append(ComName2+ "' or Component_name='");
            addstr.Append(ComName3+ "' or Component_name='");
            addstr.Append(ComName4+ "' or Component_name='");
            addstr.Append(ComName5+ "' )as Co");
            int row = DBhelp.ExecuteNonQuery(addstr.ToString());
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
