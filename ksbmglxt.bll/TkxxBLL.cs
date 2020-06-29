using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ksbmglxt.bll
{
    public class TkxxBLL
    {

        public DataTable GetTkxxById(string s_id)
        {
            return new dal.TkxxDAL().GetTkxxById(s_id);
        }
        public int AddTkxx(string s_mc, string s_jg, string s_fs)
        {
            return new dal.TkxxDAL().AddTkxx(s_mc, s_jg, s_fs);
        }
        public int EditTkxx(string s_id, string s_mc, string s_jg, string s_fs)
        {
            return new dal.TkxxDAL().EditTkxx(s_id, s_mc, s_jg, s_fs);
        }

        public int DelTkxx(string s_id)
        {
            return new dal.TkxxDAL().DelTkxx(s_id);
        }
    }
}
