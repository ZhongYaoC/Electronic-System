using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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

    }
}
