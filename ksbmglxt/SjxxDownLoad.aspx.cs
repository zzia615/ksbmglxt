using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class SjxxDownLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_id = Request.QueryString["id"];
            DataTable table = new bll.SjxxBLL().GetSjxxById(s_id);
            if (table.Count() >= 0)
            {
                string s_url = table.Rows[0]["url"].AsString();
                string s_path = MapPath(s_url);

                System.IO.FileInfo fi = new System.IO.FileInfo(s_path);
                Response.Clear();
                Response.ClearHeaders();
                Response.Buffer = false;
                Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(Path.GetFileName(s_path), System.Text.Encoding.UTF8));
                Response.AppendHeader("Content-Length", fi.Length.ToString());
                Response.ContentType = "application/octet-stream";
                Response.WriteFile(s_path);
                Response.Flush();
                Response.End();
            }

        }
    }
}