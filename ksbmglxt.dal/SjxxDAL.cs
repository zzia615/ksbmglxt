using System.Data;

namespace ksbmglxt.dal
{
    public class SjxxDAL
    {
        public SjxxDAL()
        {
            SqlServerHelper Sql = new SqlServerHelper();
            if (!Sql.CheckTableExists("sjxx"))
            {
                string sql = "create table sjxx(" +
                    "id int identity(1,1) not null primary key," +
                    "mc nvarchar(50) not null," +
                    "lb nvarchar(50) not null," +
                    "sm nvarchar(50) null," +
                    "url nvarchar(500) null" +
                    ")";
                Sql.ExecuteSql(sql);
            }
        }
        public DataTable GetSjxxById(string s_id)
        {
            string sql = "select * from sjxx where id='" + s_id + "'";
            return new SqlServerHelper().QuerySqlDataTable(sql);
        }
        public int AddSjxx(string s_mc, string s_lb, string s_sm)
        {
            string sql = string.Format("insert into sjxx(mc,lb,sm)" +
                "values('{0}','{1}','{2}')", s_mc,  s_lb,  s_sm);
            return new SqlServerHelper().ExecuteSql(sql);
        }

        public int EditSjxx(string s_id, string s_mc, string s_lb, string s_sm)
        {
            string sql = string.Format("update sjxx set mc='{1}',lb='{2}',sm='{3}'" +
                " where id='{0}'"
                , s_id, s_mc, s_lb,s_sm);
            return new SqlServerHelper().ExecuteSql(sql);
        }
        public int EditSjUrl(string s_id, string s_url)
        {
            string sql = string.Format("update sjxx set url='{1}'" +
                " where id='{0}'"
                , s_id, s_url);
            return new SqlServerHelper().ExecuteSql(sql);
        }
        public int DelSjxx(string s_id)
        {
            string sql = string.Format("delete sjxx where id='{0}'"
                , s_id);
            return new SqlServerHelper().ExecuteSql(sql);
        }
    }
}
