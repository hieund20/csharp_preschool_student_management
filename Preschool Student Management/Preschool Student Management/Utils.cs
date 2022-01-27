using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Preschool_Student_Management
{
    class Utils
    {
        //Encript and decript password
        private static byte[] key = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        private static byte[] iv = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

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

        //Encrypt
        public static string Crypt(string text)
        {
            SymmetricAlgorithm algorithm = DES.Create();
            ICryptoTransform transform = algorithm.CreateEncryptor(key, iv);
            byte[] inputbuffer = Encoding.Unicode.GetBytes(text);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            return Convert.ToBase64String(outputBuffer);
        }

        //Decrypt
        public static string Decrypt(string text)
        {
            SymmetricAlgorithm algorithm = DES.Create();
            ICryptoTransform transform = algorithm.CreateDecryptor(key, iv);
            byte[] inputbuffer = Convert.FromBase64String(text);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            return Encoding.Unicode.GetString(outputBuffer);
        }
    }
}
