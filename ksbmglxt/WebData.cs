using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class WebData
{
    public const string 登录用户 = "LoginUser";
    public const string 登录用户名 = "LoginUserName";
    public const string 登录用户类别 = "LoginUserType";
    /// <summary>
    /// 登录用户
    /// </summary>
    public static string LoginUser { get; set; }
    /// <summary>
    /// 登录账号
    /// </summary>
    public static string LoginUserName { get; set; }
    /// <summary>
    /// 登录用户类别
    /// </summary>
    public static string LoginUserType{ get; set; }
    /// <summary>
    /// 系统名称
    /// </summary>
    public const string SystemTitle = "考试报名管理系统";
    /// <summary>
    /// 当前打开的菜单名
    /// </summary>
    public static string CurrentMenu { get; set; }
    /// <summary>
    /// 系统菜单
    /// </summary>
    public static Dictionary<string,string> SysMenu
    {
        get
        {
            Dictionary<string, string> _menu = new Dictionary<string, string>();
            _menu.Add("首页", "Default.aspx");
            _menu.Add("用户管理", "Yhxx.aspx");
            _menu.Add("试卷管理", "Sjxx.aspx");
            _menu.Add("题库管理", "Tkxx.aspx");
            _menu.Add("修改密码", "ChangePwd.aspx");
            return _menu;
        }
    }
}