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
            Console.WriteLine("info : " + DateTime.Today + " : query form " + startDate + "to" + endDate);

            List<InventoryModel> list = new List<InventoryModel>();

            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT Inventory.inventory_id,Inventory.side,Gas.type,Inventory.Volume,Inventory.Price,Inventory.Date FROM TAS_Project.Inventory INNER JOIN Gas ON Inventory.gas_id = Gas.gas_id WHERE date >= '" + startDate + " 00:00:00 AM' AND date <= '" + endDate + " 12:59:59 PM';";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new InventoryModel()
                        {
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

        public List<InventorySumModel> getInventory_sum(string startDate, string endDate)
        {
            Console.WriteLine("info : " + DateTime.Today + " : query form " + startDate + "to" + endDate);

            List<InventorySumModel> list = new List<InventorySumModel>();

            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT SUM(Price)FROM TAS_Project.Inventory WHERE side = '1' AND date >= '{startDate} 00:00:00 AM' AND date <= '{endDate} 12:59:59 PM';";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new InventorySumModel()
                        {
                            Debit = Convert.ToInt32(reader["SUM(Price)"]),
                            //Cradit = Convert.ToInt32(reader["inventory_id"])
                        });
                    }
                }
                conn.Close();
            }
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT SUM(Price)FROM TAS_Project.Inventory WHERE side = '2' AND date >= '{startDate} 00:00:00 AM' AND date <= '{endDate} 12:59:59 PM';";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new InventorySumModel()
                        {
                            //Debit = Convert.ToInt32(reader["inventory_id"]),
                            Cradit = Convert.ToInt32(reader["SUM(Price)"])
                        });
                    }
                }
                conn.Close();
            }
            return list;
        }

        public List<InventoryModel> getInventory_id(int id)
        {
            Console.WriteLine($"info : " + DateTime.Today + $" : inventory id {id}");
            List<InventoryModel> list = new List<InventoryModel>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT Inventory.inventory_id,Inventory.side,Gas.type,Inventory.Volume,Inventory.Price,Inventory.Date FROM TAS_Project.Inventory INNER JOIN Gas ON Inventory.gas_id = Gas.gas_id WHERE Inventory.inventory_id = {id};";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new InventoryModel()
                        {
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
                Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database success ");
            }
            return list;
        }










    }
}
