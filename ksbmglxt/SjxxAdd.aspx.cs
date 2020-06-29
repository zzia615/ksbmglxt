using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class SjxxAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebData.CurrentMenu = "新增试卷";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            string s_mc = mc.Text;
            string s_lb = lb.Text;
            string s_sm = sm.Text;

            new bll.SjxxBLL().AddSjxx(s_mc, s_lb, s_sm);
            Response.Write("<script>alert('新增成功！');window.location.href='Sjxx.aspx';</script>");

        }

    }
}