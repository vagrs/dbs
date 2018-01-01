using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dbs.App_Code;


namespace Dbs
{
    public partial class Loginin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void B_L_Click(object sender, EventArgs e)
        {
            string ls_name = this.T_Name.Text;
            string ls_pw = this.T_PS.Text;
            AdminManage am = new AdminManage();
            int i = am.Login(ls_name, ls_pw);
            if (i == 1)
            {
                Session["name"] = ls_name;
                //Response.Redirect("Default.aspx");
                //Response.Redirect("Page1.aspx");
                Response.Redirect("SignIn.aspx");

            }
            else
            {
                Response.Write("<script>alert('管理员原密码输入不正确！')</script>");

            }
        }
    }
}