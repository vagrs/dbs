using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dbs
{
    public partial class Default : Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text = Session["Name"].ToString();

            //HttpCookie cookie = this.Request.Cookies["Ticket"];
            //if (cookie != null)
            //{

            //    string ticketString = cookie.Value;
            //    System.Web.Security.FormsAuthenticationTicket ticket
            //        = System.Web.Security.FormsAuthentication.Decrypt(ticketString);
            //    string name = ticket.Name;
            //    this.Label1.Text = name;
            //}
            //else
            //{
            //    this.Label1.Text = "未登陆";

            //}


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //HttpCookie cookie = new HttpCookie("Ticket");
            //cookie.Expires = new DateTime(1999, 1, 1);
            //this.Response.Cookies.Add(cookie);
            /////指示浏览器重新请求
            ////
            //this.Response.Redirect("Default.aspx");
        }
    }
}