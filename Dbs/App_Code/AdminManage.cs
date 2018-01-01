using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;





namespace Dbs.App_Code
{
    public class AdminManage
    {
        public int Login(string id, string pass)
        {

            DataBase db = new DataBase();
            //DataSet DS;

            string sql_login;
            sql_login="select count(*) from Users where UserId=@id and Pwd=@pass";
           // data.MakeInParam("@id",  SqlDbType.VarChar, 30, bookcasemanage.ID),
            SqlParameter[] prams ={
            db.MakeInParam("@id", SqlDbType.VarChar, 30, id),
            db.MakeInParam("@pass", SqlDbType.VarChar, 30,pass),
             };
          // DS = db.GetDataSet(arsql,SqlParameter[] values );
            int i=db.GetScalar(sql_login,prams);
            //db.Close();
               // .GetReader(sql_login,prams);
               // .ExecuteCommand(sql_login,prams);
            return i;
            //if (i == 1)
            //{
            //    Response.Write("<script>alert('登陆成功！')</script>");
            //}

            //else
            //{
            //    Response.Write("<script>alert('登陆失败！')</script>");
            //}
            


        }
    }
}