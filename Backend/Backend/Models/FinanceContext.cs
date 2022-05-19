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
    public class FinanceContext
    {
        public string ConnectionString { get; set; }

        //private DBConnect ConnectDB = new DBConnect();  //Database connection


        public FinanceContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<FinanceModel> getAllOrder()
        {

            List<FinanceModel> list = new List<FinanceModel>();

            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM TAS_Project.test where test_id = 1;", conn);


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new FinanceModel()
                        {
                            //orderID = Convert.ToInt32(reader["orderID"]),
                            //date = reader["date"].ToString(),
                            //cost = Convert.ToInt32(reader["cost"]),
                            //price = Convert.ToInt32(reader["price"]),
                            //gasID = Convert.ToInt32(reader["gasID"]),
                            //bayFillID = Convert.ToInt32(reader["bayFillID"]),

                            test_id = Convert.ToInt32(reader["test_id"]),
                            data = Convert.ToInt32(reader["data"]),

                        });
                    }
                }
                conn.Close();
            }
            return list;
        }

        public List<InventoryModel> getInventory(string startDate, string endDate)
        {

            List<InventoryModel> list = new List<InventoryModel>();

            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {


                string sql = $"SELECT Inventory.inventory_id,Inventory.side,Gas.type,Inventory.Volume,Inventory.Price,Inventory.Date FROM TAS_Project.Inventory INNER JOIN Gas ON Inventory.gas_id = Gas.gas_id;";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new InventoryModel()
                        {
                            //orderID = Convert.ToInt32(reader["orderID"]),
                            //date = reader["date"].ToString(),
                            //cost = Convert.ToInt32(reader["cost"]),
                            //price = Convert.ToInt32(reader["price"]),
                            //gasID = Convert.ToInt32(reader["gasID"]),
                            //bayFillID = Convert.ToInt32(reader["bayFillID"]),

                            inventory_id = Convert.ToInt32(reader["inventory_id"]),
                            side = Convert.ToInt32(reader["side"]),
                            type = reader["type"].ToString(),
                            volume = Convert.ToInt32(reader["Volume"]),
                            price = Convert.ToInt32(reader["Price"]),
                            date = reader["Date"].ToString()

                        });
                    }
                }
                conn.Close();
            }
            return list;
        }

        public List<InventoryModel> getInventoryByDate(string startDate, string endDate)
        {

            List<InventoryModel> list = new List<InventoryModel>();

            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {


                string sql = $"SELECT Inventory.inventory_id,Inventory.side,Gas.type,Inventory.Volume,Inventory.Price,Inventory.Date FROM TAS_Project.Inventory INNER JOIN Gas ON Inventory.gas_id = Gas.gas_id WHERE date >= '{startDate} 00:00:00 AM' AND date <= '{endDate} 00:00:00 AM';";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new InventoryModel()
                        {
                            //orderID = Convert.ToInt32(reader["orderID"]),
                            //date = reader["date"].ToString(),
                            //cost = Convert.ToInt32(reader["cost"]),
                            //price = Convert.ToInt32(reader["price"]),
                            //gasID = Convert.ToInt32(reader["gasID"]),
                            //bayFillID = Convert.ToInt32(reader["bayFillID"]),

                            inventory_id = Convert.ToInt32(reader["inventory_id"]),
                            side = Convert.ToInt32(reader["side"]),
                            type = reader["type"].ToString(),
                            volume = Convert.ToInt32(reader["Volume"]),
                            price = Convert.ToInt32(reader["Price"]),
                            date = reader["Date"].ToString()

                        });
                    }
                }
                conn.Close();
            }
            return list;
        }




    }
}
