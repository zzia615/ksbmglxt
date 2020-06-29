using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class YhxxEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebData.CurrentMenu = "修改用户";
            if (!IsPostBack)
            {
                string s_yhzh = Request.QueryString["yhzh"];
                if (!string.IsNullOrEmpty(s_yhzh))
                {
                    DataTable table = new bll.LoginBLL().GetYhxxByYhzh(s_yhzh);
                    if (table.Count() > 0)
                    {
                        yhzh.Text = table.Rows[0]["yhzh"].AsString();
                        yhxm.Text = table.Rows[0]["yhxm"].AsString();
                        yhmm.Text = table.Rows[0]["yhmm"].AsString();
                        yhjs.Value = table.Rows[0]["yhjs"].AsString();
                    }
                    else
                    {
                        Response.Write("<script>alert('用户信息不存在！');window.location.href='Yhxx.aspx';</script>");
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            string s_yhzh = yhzh.Text;
            string s_yhxm = yhxm.Text;
            string s_yhmm = yhmm.Text;
            string s_yhjs = yhjs.Value;

            new bll.LoginBLL().EditYhxx(s_yhzh, s_yhxm, s_yhmm, s_yhjs);
            Response.Write("<script>alert('修改成功！');window.location.href='Yhxx.aspx';</script>");
        }

    }
}