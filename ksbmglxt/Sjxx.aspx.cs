using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class Sjxx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebData.CurrentMenu = "试卷管理";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s_tjlb = tjlb.Value;
            string s_tjnr = tjnr.Text;
            string sql = "sjxx.*,ROW_NUMBER() OVER (ORDER BY sjxx.id ASC) AS xh from sjxx where 1=1";
            if(!string.IsNullOrEmpty(s_tjlb)&&
                !string.IsNullOrEmpty(s_tjnr))
            {
                sql += " and " + s_tjlb + " like N'%" + s_tjnr + "%'";
            }
            SqlDataSource1.SelectCommand = sql;
            GridView1.DataBind();
        }
    }
}