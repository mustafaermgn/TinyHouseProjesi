using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyHouseProjesi
{
    internal class SqlCon
    {
        readonly static string connectionString = ("DATA SOURCE = .\\SQLEXPRESS;INITIAL CATALOG = TinyHouseProject;INTEGRATED SECURITY=TRUE");
       
        public static SqlConnection Connect()
        {
            return new SqlConnection(connectionString);
        }

    }
}
