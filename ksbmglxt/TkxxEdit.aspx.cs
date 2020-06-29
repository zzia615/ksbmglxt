using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class TkxxEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebData.CurrentMenu = "修改题库";
            if (!IsPostBack)
            {
                string s_id = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(s_id))
                {
                    DataTable table = new bll.TkxxBLL().GetTkxxById(s_id);
                    if (table.Count() > 0)
                    {
                        id.Text = table.Rows[0]["id"].AsString();
                        mc.Text = table.Rows[0]["mc"].AsString();
                        jg.Text = table.Rows[0]["jg"].AsString();
                        fs.Text = table.Rows[0]["fs"].AsString();
                    }
                    else
                    {
                        Response.Write("<script>alert('题库信息不存在！');window.location.href='Sjxx.aspx';</script>");
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            string s_id = id.Text;
            string s_mc = mc.Text;
            string s_jg = jg.Text;
            string s_fs = fs.Text;

            new bll.TkxxBLL().EditTkxx(s_id,s_mc, s_jg, s_fs);
            Response.Write("<script>alert('修改成功！');window.location.href='Tkxx.aspx';</script>");

        }

    }
}