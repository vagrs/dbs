using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CM = System.Configuration.ConfigurationManager;
using System.Web.Configuration;
using System.Configuration;


namespace Dbs
{
    public partial class Page11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string appString = string.Format("<b>KEY:{0}</b><br><b>VALUE:{1}</b>", "SP", CM.AppSettings["SP"]);
        }

        protected void Btn_query_Click(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
                DataBase db = new DataBase();
                DataSet ds = db.GetAllBook("products");
                // Response.Write(ds.row)
                gvBookInfo.DataSource = ds;
                gvBookInfo.DataKeyNames = new string[] { "productid" };
                gvBookInfo.DataBind();


            //}
                //gvBind();
        }
        private void gvBind()
        {
            DataBase db = new DataBase();
            DataSet ds =  db.GetAllBook("products");
          // Response.Write(ds.row)
            gvBookInfo.DataSource = ds;
            gvBookInfo.DataKeyNames = new string[] { "productid" };
            gvBookInfo.DataBind();
        }

        protected void gvBookInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void gvBookInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvBookInfo.PageIndex = e.NewPageIndex;
            gvBind(); 
        }
        protected void gvBookInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //bookmanage.BookCode = gvBookInfo.DataKeys[e.RowIndex].Value.ToString();
            //bookmanage.DeleteBook(bookmanage);
            //Response.Write("<script>alert('图书信息删除成功')</script>");
            //gvBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {    
            Configuration cfa = WebConfigurationManager.OpenWebConfiguration("~");
            cfa.AppSettings.Settings["SP"].Value = "name";
            cfa.Save(); 
        }
    }
}