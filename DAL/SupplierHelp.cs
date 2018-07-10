
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupplierHelp
    {
        //查询供应商信息
        public static DataTable QuerySupplier(string sup_id)
        {
            StringBuilder querySup = new StringBuilder();
            querySup.Append("select * from supplier_info where ");
            querySup.Append("Supplier_id LIKE '%");
            querySup.Append(sup_id);
            querySup.Append("%'");
            DataTable dt = DBhelp.GetDataTable(querySup.ToString());

            return dt;
        }
        
        //新增供应商
        public static bool AddSupplier(string sup_name,string sup_addr)
        {
            StringBuilder addSup = new StringBuilder();
            addSup.Append("insert into supplier_info" +
                "(Supplier_name,Supplier_addr) values(");
            addSup.Append(sup_name +",");
            addSup.Append(sup_addr+")");
            int row = DBhelp.ExecuteNonQuery(addSup.ToString());
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
