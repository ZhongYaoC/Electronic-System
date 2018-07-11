
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
        public static DataTable QuerySupplier(string sup_id, string sup_name,string sup_addr)
        {
            StringBuilder querySup = new StringBuilder();
            querySup.Append("select * from supplier_info where ");
            querySup.Append("Supplier_id LIKE '%");
            querySup.Append(sup_id);
            querySup.Append("%' and Supplier_name LIKE '%");
            querySup.Append(sup_name);
            querySup.Append("%' and Supplier_addr LIKE '%");
            querySup.Append(sup_addr + "%'");
            DataTable dt = DBhelp.GetDataTable(querySup.ToString());

            return dt;
        }
        
        //新增供应商
        public static bool AddSupplier(string sup_name,string sup_addr)
        {
            StringBuilder addSup = new StringBuilder();
            addSup.Append("insert into supplier_info" +
                "(Supplier_name,Supplier_addr) values('");
            addSup.Append(sup_name +"', '");
            addSup.Append(sup_addr+"')");
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

        //delete supplier
        public static bool DeleteSupplier(string id)
        {
            StringBuilder deletestr = new StringBuilder();
            deletestr.Append("delete from supplier_info where Supplier_id = '");
            deletestr.Append(id+"'");
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

        //update supplier
        public static bool UpdateSupplier(string id,string name,string addr)
        {
            StringBuilder updatestr = new StringBuilder();
            updatestr.Append("update supplier_info set Supplier_name = '");
            updatestr.Append(name);
            updatestr.Append("' , Supplier_addr = '");
            updatestr.Append(addr + "'");
            updatestr.Append("where Supplier_id = '");
            updatestr.Append(id + "'");
            int row = DBhelp.ExecuteNonQuery(updatestr.ToString());
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable GetOrder()
        {
            string querystr = "select sernum,supplier_info.Supplier_name,component_info.Component_name,Order_num " +
                "from order_list " +
                "left join supplier_info on order_list.Supplier_id = supplier_info.Supplier_id " +
                "left join component_info on order_list.Component_id = component_info.Component_id";
            DataTable dt = DBhelp.GetDataTable(querystr);
            return dt;
        }

        /*
        select Component_id from component_info where Component_name='发电机' or Component_name='齿轮箱' or Component_name='风机叶片' or Component_name='液压装置' or Component_name='显示屏' 
         */
         
    }
}
