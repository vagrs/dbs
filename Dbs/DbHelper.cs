using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Dbs
{
    public  class DbHelper
    {
        public static string ConnectionStrings
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings
                    ["petshop4"].ConnectionString;
            }
        }

        







    }
}



//public class DbHelper
//    {
//        public static string ConnectionString
//        {
//            get
//            {
//                return System.Configuration.ConfigurationManager.ConnectionStrings
//                    ["petshop4"].ConnectionString;
            
//            }
//        }


//    }