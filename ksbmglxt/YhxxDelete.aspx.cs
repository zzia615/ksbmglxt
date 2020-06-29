using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class YhxxDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_yhzh = Request.QueryString["yhzh"];
            if (!string.IsNullOrEmpty(s_yhzh))
            {
                new bll.LoginBLL().DelYhxx(s_yhzh);
                Response.Write("<script>alert('删除成功！');window.location.href='Yhxx.aspx';</script>");
                return;
            }
            Response.Write("<script>alert('删除不合法！');window.location.href='Yhxx.aspx';</script>");

        }
    }
}