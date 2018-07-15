using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MaintainHelper
    {
        //查询config中mal为0的所有数据
        public static DataTable GetMainTainPlan()
        {
            StringBuilder querystr = new StringBuilder();
            querystr.Append("select Meter_id as 机器ID,Meter_type as 机器类型,Meter_addr as 所处位置,Meter_malfunc as 是否故障 from config");
            DataTable dt =  DBhelp.GetDataTable(querystr.ToString());
            return dt;
        }

        public static DataTable GetPlan()
        {
            StringBuilder querystr = new StringBuilder();
            querystr.Append("select Meter_id as 维护机器ID, isnull(convert(varchar(50),计划维护时长),'故障还未申报') as 计划维护时长,isnull(convert(varchar(50),开始维护时间),' ') as 开始维护时间 from config where Meter_malfunc = 0");
            DataTable dt = DBhelp.GetDataTable(querystr.ToString());
            return dt;
        }

        //故障申报
        public static bool Updateconfig(long id,int duration,string start_time)
        {
            /* ex:
                update config 
                set 计划维护时长 = 10,
                开始维护时间 = '2018-07-11',
                Meter_malfunc = 0
                where Meter_id = 2018071007;
             */
            StringBuilder updatestr = new StringBuilder();
            updatestr.Append("update config set 计划维护时长 = ");
            updatestr.Append(duration);
            updatestr.Append(", 开始维护时间 = '");
            updatestr.Append(start_time);
            updatestr.Append("' , Meter_malfunc = 0 ");
            updatestr.Append("where Meter_id = ");
            updatestr.Append(id);
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

        //查询施工状况
        public static DataTable GetAccomplish()
        {
            StringBuilder querystr = new StringBuilder();
            querystr.Append("select Meter_id as 维护机器ID,isnull(convert(varchar(50),DATEDIFF(DY,开始维护时间,convert(date,GETDATE(),23))),'未开工') as 已施工天数 from config where Meter_malfunc = 0");
            DataTable dt = DBhelp.GetDataTable(querystr.ToString());
            return dt;
        }

        //修改机器故障状态
        public static bool UpdateMalfunc(long id)
        {
            StringBuilder updatestr = new StringBuilder();
            updatestr.Append("update config set Meter_malfunc = 1,计划维护时长=null,开始维护时间=null ");
            updatestr.Append("where Meter_id = ");
            updatestr.Append(id);
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

        public static SqlDataReader Statistic()
        {
            /*
             * 维护中 select count(*) from config where Meter_malfunc=0 and 开始维护时间 is not null
             * 正常select count(*) from config where Meter_malfunc=1
             * 所有select count(*) from config
             * 故障select count(*) from config where Meter_malfunc=0
             */
            StringBuilder querystr = new StringBuilder();
            querystr.Append("select count(*) from config");
            return DBhelp.ExecuteReader(querystr.ToString());
        }
    }
}
