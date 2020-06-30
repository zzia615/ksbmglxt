using System.Data;
using System.Data.SqlClient;

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
                "values(@mc,@jg,@fs)");
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@mc",s_mc),
                new SqlParameter("@jg",s_jg),
                new SqlParameter("@fs",s_fs)
            };
            return new SqlServerHelper().ExecuteSql(sql, parameters);
        }

        public int EditTkxx(string s_id, string s_mc, string s_jg, string s_fs)
        {
            string sql = string.Format("update Tkxx set mc=@mc,jg=@jg,fs=@fs" +
                " where id=@id");
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@mc",s_mc),
                new SqlParameter("@jg",s_jg),
                new SqlParameter("@fs",s_fs),
                new SqlParameter("@id",int.Parse(s_id))
            };
            return new SqlServerHelper().ExecuteSql(sql, parameters);
        }

        public int DelTkxx(string s_id)
        {
            string sql = string.Format("delete Tkxx where id='{0}'"
                , s_id);
            return new SqlServerHelper().ExecuteSql(sql);
        }
    }
}
