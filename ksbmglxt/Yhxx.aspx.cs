﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class Yhxx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebData.CurrentMenu = "用户管理";
            if (Session[WebData.登录用户类别].AsString() != "系统管理员")
            {
                GridView1.Columns[4].Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s_tjlb = tjlb.Value;
            string s_tjnr = tjnr.Text;
            string sql = "select * from Yhxx where 1=1";
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