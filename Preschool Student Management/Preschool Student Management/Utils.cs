using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preschool_Student_Management
{
    class Utils
    {
        //SELECT QUERY
        //Using second parameter is column name
        public static List<string> selectQuery(string query, string columnName)
        {
            List<string> resultList = new List<string>();

            MySqlConnection connection = DBUtils.getDBConnection();
            connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = query;

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    resultList.Add(reader[columnName].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when execute select query: " + ex);
            }
            return resultList;
        }

        //INSERT QUERY
        public static void insertQuery(string query)
        {
            MySqlConnection connection = DBUtils.getDBConnection();
            connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = query;

                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when execute insert query: " + ex);
            }
        }

        //DELETE QUERY
        public static void deleteQuery(string query)
        {
            MySqlConnection connection = DBUtils.getDBConnection();
            connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = query;

                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when execute delete query: " + ex);
            }
        }
    }
}
