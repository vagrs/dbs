using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dbs.Module
{
   //注册httpapplication的事件处理
    public class MyModule:System.Web.IHttpModule
    {
        //public void Dispose()
        //{

        //}
        ////init专门用来注册HTTPAPPLICATIO事件
        //public void Init

        public void Dispose()
        {
            
        }

        public void Init(HttpApplication application)
        {
           // application.AuthenticateRequest += new EventHandler(Application_AuthenticateRequest);
            application.AcquireRequestState += new EventHandler(Application_AcquireRequestState);
               // .AuthenticateRequest += new EventHandler(Application_AuthenticateRequest);

        }
        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            //HttpSessionState
           //     Session["Name"]  = HttpContext.Current.Session; // new HttpSessionStateBase();
            //if (HttpContext.Current.Session = null)
            
            //if (System.Web.HttpContext.Current.Session["Name"]  )


           //if( Session["Name"].ToString() = null)
           //{


           //}
            
        }
        //protected void Application_AuthenticateRequest(object sender, EventArgs e)
        //{
        //    HttpRequest request = HttpContext.Current.Request;
        //    HttpCookie cookie = request.Cookies["Ticket"];
        //    if (cookie != null)
        //    {

        //        string ticketString = cookie.Value;
        //        System.Web.Security.FormsAuthenticationTicket ticket
        //            = System.Web.Security.FormsAuthentication.Decrypt(ticketString);
        //        string name = ticket.Name;
        //       // this.Label1.Text = name;
        //    }
        //    else
        //    {
        //        //this.Label1.Text = "未登陆";

        //    }
        //}
    }
}