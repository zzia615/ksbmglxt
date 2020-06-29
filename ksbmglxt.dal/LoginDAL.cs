using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ksbmglxt.dal
{
    public class LoginDAL
    {
        public LoginDAL()
        {
            SqlServerHelper Sql = new SqlServerHelper();
            if (!Sql.CheckTableExists("yhxx"))
            {
                string sql = "create table yhxx(" +
                    "yhzh nvarchar(20) not null primary key," +
                    "yhxm nvarchar(20) not null," +
                    "yhmm nvarchar(50) not null," +
                    "yhjs nvarchar(50) default '普通管理员' not null" +
                    ")";
                Sql.ExecuteSql(sql);
                sql = "insert into yhxx(yhzh,yhxm,yhmm) values('admin','admin','admin')";
                Sql.ExecuteSql(sql);
            }
        }
        public DataTable LoginSys(string s_yhzh,string s_yhmm)
        {
            string sql = string.Format("select * from yhxx where yhzh='{0}'" +
                "and yhmm='{1}'", s_yhzh, s_yhmm);
            return new SqlServerHelper().QuerySqlDataTable(sql);
        }
        public DataTable GetYhxxByYhzh(string s_yhzh)
        {
            string sql = "select * from yhxx where yhzh='" + s_yhzh + "'";
            return new SqlServerHelper().QuerySqlDataTable(sql);
        }
        public int AddYhxx(string s_yhzh,string s_yhxm,string s_yhmm, string s_yhjs)
        {
            string sql = string.Format("insert into yhxx(yhzh,yhxm,yhmm,yhjs)" +
                "values('{0}','{1}','{2}','{3}')", s_yhzh, s_yhxm, s_yhmm,s_yhjs);
            return new SqlServerHelper().ExecuteSql(sql);
        }

        public int EditYhxx(string s_yhzh, string s_yhxm, string s_yhmm, string s_yhjs)
        {
            string sql = string.Format("update yhxx set yhxm='{1}',yhmm='{2}',yhjs='{3}'" +
                " where yhzh='{0}'"
                , s_yhzh, s_yhxm, s_yhmm, s_yhjs);
            return new SqlServerHelper().ExecuteSql(sql);
        }

        public int DelYhxx(string s_yhzh)
        {
            string sql = string.Format("delete yhxx where yhzh='{0}'"
                , s_yhzh);
            return new SqlServerHelper().ExecuteSql(sql);
        }
    }
}
