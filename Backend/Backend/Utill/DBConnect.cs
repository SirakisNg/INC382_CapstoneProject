using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Backend.Utill
{
    public class DBConnect
    {
        private string ConnectionString = "Server = localhost; Database = tas_project; Uid = root; Pwd = password";
        public MySqlConnection myConnection;

        public DBConnect()
        {
            myConnection = new MySqlConnection(ConnectionString);
            myConnection.Open();
        }

        public DataTable GetData(string _sqlCommand)
        {
            MySqlCommand command = new MySqlCommand(_sqlCommand, myConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void ExecuteQuery(string _sqlCommand)
        {
            MySqlCommand command = new MySqlCommand("", myConnection);
            command.CommandText = _sqlCommand;
            command.CommandType = CommandType.Text;
            command.Connection = myConnection;
            command.ExecuteNonQuery();
        }

    }
}
