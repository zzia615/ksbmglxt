using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class YhxxAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebData.CurrentMenu = "新增用户";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            string s_yhzh = yhzh.Text;
            string s_yhxm = yhxm.Text;
            string s_yhmm = yhmm.Text;
            string s_yhjs = yhjs.Value;

            new bll.LoginBLL().AddYhxx(s_yhzh, s_yhxm, s_yhmm,s_yhjs);
            Response.Write("<script>alert('新增成功！');window.location.href='Yhxx.aspx';</script>");

        }

    }
}