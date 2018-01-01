using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Dbs
{
    public  class DataBase
    {
        private  SqlConnection connection;
        //public  SqlConnection Connection
        //{
        //    get
        //    {
        //        string connectionString = DbHelper.ConnectionStrings;
        //        if (connection == null)
        //        {
        //            connection = new SqlConnection(connectionString);
        //            connection.Open();
        //        }
        //        else if (connection.State == System.Data.ConnectionState.Closed)
        //        {
        //            connection.Open();
        //        }
        //        else if (connection.State == System.Data.ConnectionState.Broken)
        //        {
        //            connection.Close();
        //            connection.Open();
        //        }
        //        return connection;
        //    }
        //}
        public void Open()
        {
           // get
            {
                string connectionString = DbHelper.ConnectionStrings;
                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
              //  return connection;
            }

        }

        #region  关闭连接
        ///// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void Close()
        {
            if (connection  != null)
                connection.Close();
        }
        #endregion

        //#region 释放数据库连接资源
        ///// <summary>
        ///// 释放资源
        ///// </summary>
        //public void Dispose()
        //{
        //    // 确认连接是否已经关闭
        //    if (connection != null)
        //    {
        //        connection.Dispose();
        //        connection = null;
        //    }
        //}
        //#endregion



        public  int ExecuteCommand(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql,connection);
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            return result;

        }

        //public int ExecuteCommand(string safeSql)
        //{
        //    SqlCommand cmd = new SqlCommand(safeSql, Connection);
        //    int result = cmd.ExecuteNonQuery();
        //    Connection.Close();
        //    return result;
        //}

        //public static int ExecuteCommand(string sql, params SqlParameter[] values)
        //{
        //    SqlCommand cmd = new SqlCommand(sql, Connection);
        //    cmd.Parameters.AddRange(values);
        //    return cmd.ExecuteNonQuery();
        //}

        public int ExecuteCommand(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteNonQuery();
        }

        //public static int GetScalar(string safeSql)
        //{
        //    SqlCommand cmd = new SqlCommand(safeSql, Connection);
        //    int result = Convert.ToInt32(cmd.ExecuteScalar());
        //    return result;
        //}

        public int GetScalar(string sql, params SqlParameter[] values)
        {
            this.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddRange(values);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return result;
        }

        //public static SqlDataReader GetReader(string safeSql)
        //{
        //    SqlCommand cmd = new SqlCommand(safeSql, Connection);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    return reader;
        //}

        public SqlDataReader GetReader(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddRange(values);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        //public static DataTable GetDataSet(string safeSql)
        //{
        //    DataSet ds = new DataSet();
        //    SqlCommand cmd = new SqlCommand(safeSql, Connection);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(ds);
        //    return ds.Tables[0];
        //}

        public  DataTable GetDataSet(string sql, params SqlParameter[] values)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddRange(values);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
        public DataSet RunProcReturn(string procName, string tbName)
        {
            SqlDataAdapter dap = CreateDataAdaper(procName, null);
            DataSet ds = new DataSet();
            dap.Fill(ds, tbName);
            this.Close();
            //得到执行成功返回值
            return ds;
        }
        private SqlDataAdapter CreateDataAdaper(string procName, SqlParameter[] prams)
        {
            this.Open();
            //this. Connection();
            //this.connection();
            SqlDataAdapter dap = new SqlDataAdapter(procName, connection);
            dap.SelectCommand.CommandType = CommandType.Text;  //执行类型：命令文本
            if (prams != null)
            {
                foreach (SqlParameter parameter in prams)
                    dap.SelectCommand.Parameters.Add(parameter);
            }
            //加入返回参数
            dap.SelectCommand.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4,
                ParameterDirection.ReturnValue, false, 0, 0,
                string.Empty, DataRowVersion.Default, null));

            return dap;
        }
        public DataSet GetAllBook(string tbName)
        {
            return (this.RunProcReturn("select * from Products ORDER BY productid", tbName));
        }

        ///// <summary>
        ///// 简单防sql注入程序
        ///// </summary>
        ///// <param name="str"></param>
        ///// <returns></returns>
        //public static string Sqlstring(string str)
        //{
        //    str = str.Replace("&", "&amp;");
        //    str = str.Replace("<", "&lt;");
        //    str = str.Replace(">", "&gt");
        //    str = str.Replace("'", "''");
        //    str = str.Replace("*", "");
        //    str = str.Replace("\n", "<br/>");
        //    str = str.Replace("\r\n", "<br/>");
        //    //str = str.Replace("?","");
        //    str = str.Replace("select", "");
        //    str = str.Replace("insert", "");
        //    str = str.Replace("update", "");
        //    str = str.Replace("delete", "");
        //    str = str.Replace("create", "");
        //    str = str.Replace("drop", "");
        //    str = str.Replace("delcare", "");
        //    str = str.Replace("--", "");
        //    str = str.Replace("@", "");

        //    if (str.Trim().ToString() == "") { str = "null"; }

        //    return str;
        //}
        public SqlParameter MakeParam(string ParamName, SqlDbType DbType, Int32 Size, ParameterDirection Direction, object Value)
        {
            SqlParameter param;

            if (Size > 0)
                param = new SqlParameter(ParamName, DbType, Size);
            else
                param = new SqlParameter(ParamName, DbType);
            param.Direction = Direction;
            if (!(Direction == ParameterDirection.Output && Value == null))
                param.Value = Value;
            return param;
        }

        public SqlParameter MakeInParam(string ParamName, SqlDbType DbType, int Size, object Value)
        {
            return MakeParam(ParamName, DbType, Size, ParameterDirection.Input, Value);
        }



    }
}