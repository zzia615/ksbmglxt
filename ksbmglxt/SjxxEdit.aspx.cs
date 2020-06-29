using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class SjxxEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebData.CurrentMenu = "修改试卷";
            if (!IsPostBack)
            {
                string s_id = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(s_id))
                {
                    DataTable table = new bll.SjxxBLL().GetSjxxById(s_id);
                    if (table.Count() > 0)
                    {
                        id.Text = table.Rows[0]["id"].AsString();
                        mc.Text = table.Rows[0]["mc"].AsString();
                        lb.Text = table.Rows[0]["lb"].AsString();
                        sm.Text = table.Rows[0]["sm"].AsString();
                    }
                    else
                    {
                        Response.Write("<script>alert('试卷信息不存在！');window.location.href='Sjxx.aspx';</script>");
                    }
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            string s_id = id.Text;
            string s_mc = mc.Text;
            string s_lb = lb.Text;
            string s_sm = sm.Text;

            new bll.SjxxBLL().EditSjxx(s_id,s_mc, s_lb, s_sm);
            Response.Write("<script>alert('修改成功！');window.location.href='Sjxx.aspx';</script>");

        }

    }
}