using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Backend.Models;
using Backend.Utill;
using System.Linq;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;


namespace Backend.Models
{
    public class ManagementContext
    {
        public string ConnectionString { get; set; }

        //private DBConnect ConnectDB = new DBConnect();  //Database connection

        public ManagementContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }


        public List<ManagementModel> managements()
        {

            List<ManagementModel> list = new List<ManagementModel>();

            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tas_project.test where test_id = 1;", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ManagementModel()
                        {
                            test_id = Convert.ToInt32(reader["test_id"]),
                            data = Convert.ToInt32(reader["data"]),

                        });
                    }
                }
            }
            return list;
        }




    }
}
