using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// 所有的aspx.cs页面必须继承的基类,用于全局判断用户是否登陆.
/// </summary>
public class Base : Page
{
    public Base()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }
    protected override void OnInit(EventArgs e)
    {
        if (Session["name"] == null)
        {
            Response.Write("<script>alert('请先登陆！')</script>");
            Response.Redirect("~/Loginin.aspx");
        }
        base.OnInit(e);
    }
    protected override void OnError(EventArgs e)
    {
        string errorMsg = String.Empty;
        Exception currentError = Server.GetLastError();
        errorMsg += "来自页面的异常处理<br />";
        errorMsg += "系统发生错误:<br />";
        errorMsg += "错误地址:" + Request.Url + "<br />";
        errorMsg += "错误信息:" + currentError.Message + "<br />";
        Session["error"] = errorMsg;
        Server.ClearError();//清除异常(否则将引发全局的Application_Error事件)
        Response.Redirect("~/resources/500.aspx");
        base.OnError(e);
    }
}