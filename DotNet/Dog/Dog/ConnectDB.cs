using System;
using MySql.Data.MySqlClient;
using System.Data;



namespace Dog
{
    

    public class ConnectDB
    {
        private string ConString = "Server = localhost; Database = test; Uid = root; Pwd = password;";
        public MySqlConnection myConnection;

        public ConnectDB()
        {
            myConnection = new MySqlConnection(ConString);
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

        public void ExecuteQuery(string _sqlcommand)
        {
            MySqlCommand command = new MySqlCommand("", myConnection);
            command.CommandText = _sqlcommand;
            command.CommandType = CommandType.Text;
            command.Connection = myConnection;
            command.ExecuteNonQuery();
        }
        
        
    }
}
