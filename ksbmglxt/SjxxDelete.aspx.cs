using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class SjxxDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s_id = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(s_id))
                {
                    new bll.SjxxBLL().DelSjxx(s_id);
                    Response.Write("<script>alert('删除成功！');window.location.href='Sjxx.aspx';</script>");
                    return;
                }
                Response.Write("<script>alert('删除不合法！');window.location.href='Sjxx.aspx';</script>");
            }
        }
    }
}