using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Preschool_Student_Management
{
    class DBMySQLUtils
    {
        public static MySqlConnection getDBConnection(string host, int port, string database, string username, string password)
        {
            string connectionQuery = "Server=" + host + ";Database=" + database +
                ";port=" + port + ";User id=" + username + ";password=" + password;
            MySqlConnection connection = new MySqlConnection(connectionQuery);

            return connection;
        }
    }
}
