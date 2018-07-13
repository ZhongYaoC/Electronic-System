using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UserHelp
    {
        public static string uid;

        public static void Set_uid(string ruid)
        {
            uid = ruid;
        }

        /*
         用户登陆方法，检查用户名，密码，和身份
         密码正确返回 true 错误返回 false
             */
        public static bool User_Login(string uid, string pwd, string limit)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select * from user_info");
            stringBuilder.Append(" where ");
            stringBuilder.Append("User_id='");
            stringBuilder.Append(uid);
            stringBuilder.Append("' and User_pwd=");
            stringBuilder.Append(pwd);
            stringBuilder.Append(" and User_limit=");
            stringBuilder.Append(limit);
            SqlDataReader sqlDataReader = DBhelp.ExecuteReader(stringBuilder.ToString());
            if (sqlDataReader.Read())
            {
                sqlDataReader.Close();
                return true;
            }
            else
            {
                sqlDataReader.Close();
                return false;
            }
        }

        /*
         用户信息录入
             */
        public static bool Insert_uinfo(string uname, string pwd)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("insert into user_info(User_name,User_pwd,User_limit) values('");
            stringBuilder.Append(uname+"','");
            stringBuilder.Append(pwd + "','");
            stringBuilder.Append(0 + "')");
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

        /*
         修改用户权限和密码
             */
        public static bool Change_info(string uid, string pwd, string limit)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("update user_info set ");
            stringBuilder.Append("User_pwd='");
            stringBuilder.Append(pwd+"', User_limit='");
            stringBuilder.Append(limit+"' ");
            stringBuilder.Append("where User_id='");
            stringBuilder.Append(uid+"'");
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

        /*
         删除用户信息
             */
        public static bool Delete_info(string uid)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("delete from user_info where User_id='");
            stringBuilder.Append(uid+"'");
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

        /*
         获取用户账号
             */
        public static string Get_num(string uname, string pwd)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select * from user_info");
            stringBuilder.Append(" where ");
            stringBuilder.Append("User_name='");
            stringBuilder.Append(uname);
            stringBuilder.Append("' and User_pwd=");
            stringBuilder.Append(pwd);
            SqlDataReader sqlDataReader = DBhelp.ExecuteReader(stringBuilder.ToString());
            if (sqlDataReader.Read())
            {
                string num = sqlDataReader[0].ToString();
                sqlDataReader.Close();
                return num;
            }
            else
            {
                sqlDataReader.Close();
                return null;
            }
        }

        public static DataTable Get_userable()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select * from user_info");
            return DBhelp.GetDataTable(stringBuilder.ToString());
        }
    }
}
