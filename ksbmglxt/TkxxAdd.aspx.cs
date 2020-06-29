using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class TkxxAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebData.CurrentMenu = "新增题库";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            string s_mc = mc.Text;
            string s_jg = jg.Text;
            string s_fs = fs.Text;

            new bll.TkxxBLL().AddTkxx(s_mc, s_jg, s_fs);
            Response.Write("<script>alert('新增成功！');window.location.href='Tkxx.aspx';</script>");

        }

    }
}