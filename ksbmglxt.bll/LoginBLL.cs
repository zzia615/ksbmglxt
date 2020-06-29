using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ksbmglxt.bll
{
    public class LoginBLL
    {
        public LoginBLL()
        {
            new dal.LoginDAL();
            new dal.SjxxDAL();
            new dal.TkxxDAL();
        }
        public DataTable LoginSys(string s_yhzh, string s_yhmm)
        {
            return new dal.LoginDAL().LoginSys(s_yhzh, s_yhmm);
        }
        public DataTable GetYhxxByYhzh(string s_yhzh)
        {
            return new dal.LoginDAL().GetYhxxByYhzh(s_yhzh);
        }
        public int AddYhxx(string s_yhzh,string s_yhxm, string s_yhmm, string s_yhjs)
        {
            return new dal.LoginDAL().AddYhxx(s_yhzh, s_yhxm, s_yhmm,s_yhjs);
        }
        public int EditYhxx(string s_yhzh, string s_yhxm, string s_yhmm,string s_yhjs)
        {
            return new dal.LoginDAL().EditYhxx(s_yhzh, s_yhxm, s_yhmm, s_yhjs);
        }
        public int DelYhxx(string s_yhzh)
        {
            return new dal.LoginDAL().DelYhxx(s_yhzh);
        }
    }
}
