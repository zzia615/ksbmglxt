using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class ChangePwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebData.CurrentMenu = "修改密码";
            if (!IsPostBack)
            {
                string s_yhzh = Session[WebData.登录用户].AsString();
                if (!string.IsNullOrEmpty(s_yhzh))
                {
                    DataTable table = new bll.LoginBLL().GetYhxxByYhzh(s_yhzh);
                    if (table.Count() > 0)
                    {
                        yhzh.Text = table.Rows[0]["yhzh"].AsString();
                        yhxm.Text = table.Rows[0]["yhxm"].AsString();
                        yhjs.Text = table.Rows[0]["yhjs"].AsString();
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
            string s_yhmm1 = yhmm1.Text;
            string s_yhjs = yhjs.Text;
            if (s_yhmm != s_yhmm1)
            {
                Response.Write("<script>alert('两次密码输入不一致！');window.location.href='ChangePwd.aspx';</script>");
                return;
            }
            new bll.LoginBLL().EditYhxx(s_yhzh, s_yhxm, s_yhmm, s_yhjs);
            Response.Write("<script>alert('修改密码成功！');window.location.href='ChangePwd.aspx';</script>");
        }

    }
}