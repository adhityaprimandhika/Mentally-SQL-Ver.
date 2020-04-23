using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentally_DB_Library
{
    public class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=account_db");

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public DataTable Read_1()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `account`",connection);

            adapter.Fill(table);
            return table;
        }

        public DataTable Read_2()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `history`", connection);

            adapter.Fill(table);
            return table;
        }
    }
}
