using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;


namespace MvcMovie.Models
{
    public class DBContext
    {
        public string ConnectionString { get; set; }
        

        public MusicStoreContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
