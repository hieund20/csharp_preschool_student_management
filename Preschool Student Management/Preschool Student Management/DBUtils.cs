﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Preschool_Student_Management
{
    class DBUtils
    {
        public static MySqlConnection getDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "preschool_student_management_db";
            string username = "root";
            string password = "Duchieu200301";

            return DBMySQLUtils.getDBConnection(host, port, database, username, password);
        }
    }
}
