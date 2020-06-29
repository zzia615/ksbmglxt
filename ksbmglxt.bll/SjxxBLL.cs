using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ksbmglxt.bll
{
    public class SjxxBLL
    {

        public int EditSjUrl(string s_id, string s_url)
        {
            return new dal.SjxxDAL().EditSjUrl(s_id, s_url);
        }
        public DataTable GetSjxxById(string s_id)
        {
            return new dal.SjxxDAL().GetSjxxById(s_id);
        }
        public int AddSjxx(string s_mc, string s_lb, string s_sm)
        {
            return new dal.SjxxDAL().AddSjxx(s_mc,  s_lb,  s_sm);
        }
        public int EditSjxx(string s_id, string s_mc, string s_lb, string s_sm)
        {
            return new dal.SjxxDAL().EditSjxx(s_id, s_mc, s_lb, s_sm);
        }

        public int DelSjxx(string s_id)
        {
            return new dal.SjxxDAL().DelSjxx(s_id);
        }
    }
}
