using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public static class ConnectionFactory
    {
        static SqlConnection GetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();

            return sqlConnection;
        }
        
    }
}