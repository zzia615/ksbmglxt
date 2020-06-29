using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;

            string s_yhzh = name.Text;
            string s_pwd = pwd.Text;

            DataTable table = new bll.LoginBLL().LoginSys(s_yhzh, s_pwd);

            if (table.Count() > 0)
            {
                Session[WebData.登录用户] = s_yhzh;
                Session[WebData.登录账号] = table.Rows[0]["yhxm"].AsString();
                Response.Write("<script>alert('登录成功！');window.location.href='Default.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('用户密码失败！');</script>");
            }
        }
    }
}