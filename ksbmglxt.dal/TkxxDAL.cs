using System.Data;

namespace ksbmglxt.dal
{
    public class TkxxDAL
    {
        public TkxxDAL()
        {
            SqlServerHelper Sql = new SqlServerHelper();
            if (!Sql.CheckTableExists("tkxx"))
            {
                string sql = "create table tkxx(" +
                    "id int identity(1,1) not null primary key," +
                    "mc nvarchar(500) not null," +
                    "jg nvarchar(500) not null," +
                    "fs int not null" +
                    ")";
                Sql.ExecuteSql(sql);
            }
        }
        public DataTable GetTkxxById(string s_id)
        {
            string sql = "select * from Tkxx where id='" + s_id + "'";
            return new SqlServerHelper().QuerySqlDataTable(sql);
        }
        public int AddTkxx(string s_mc, string s_jg, string s_fs)
        {
            string sql = string.Format("insert into tkxx(mc,jg,fs)" +
                "values('{0}','{1}','{2}')", s_mc,  s_jg, s_fs);
            return new SqlServerHelper().ExecuteSql(sql);
        }

        public int EditTkxx(string s_id, string s_mc, string s_jg, string s_fs)
        {
            string sql = string.Format("update Tkxx set mc='{1}',jg='{2}',fs='{3}'" +
                " where id='{0}'"
                , s_id, s_mc, s_jg, s_fs);
            return new SqlServerHelper().ExecuteSql(sql);
        }

        public int DelTkxx(string s_id)
        {
            string sql = string.Format("delete Tkxx where id='{0}'"
                , s_id);
            return new SqlServerHelper().ExecuteSql(sql);
        }
    }
}
