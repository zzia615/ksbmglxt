using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ksbmglxt
{
    public partial class SjxxUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebData.CurrentMenu = "文件上传";
            sjid.Text = Request.QueryString["id"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            string s_sjid = sjid.Text;

            string s_path = Server.MapPath("Upload/");
            if (!Directory.Exists(s_path))
            {
                Directory.CreateDirectory(s_path);
            }
            var tmp = FileUpload1.FileName.Split('.');
            string ext = "." + tmp[tmp.Length - 1];
            string s_file_url = "/Upload/" + Guid.NewGuid().ToString() + ext;
            string s_file = Server.MapPath(s_file_url);
            //保存图像
            FileUpload1.SaveAs(s_file);
            new bll.SjxxBLL().EditSjUrl(s_sjid, s_file_url);
            Response.Write("<script>alert('上传成功！');window.location.href='Sjxx.aspx';</script>");

        }

    }
}