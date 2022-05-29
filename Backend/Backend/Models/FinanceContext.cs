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

        // Inventory ----------------------------------------------------------------------------------------------

        // All Inventory with join table (not use)
        public List<InventoryModel> getInventory(string startDate, string endDate)
        {
            Console.WriteLine("info : " + DateTime.Today + " : query form " + startDate + "to" + endDate);

            List<InventoryModel> list = new List<InventoryModel>();

            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT Inventory.inventory_id,Inventory.side,Gas.type,Inventory.Volume,Inventory.Price,Inventory.Date FROM TAS_Project.Inventory INNER JOIN Gas ON Inventory.gas_id = Gas.gas_id WHERE date >= '" + startDate + " 00:00:00 AM' AND date <= '" + endDate + " 00:00:00 AM';";
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

        // All Inventory
        public List<Inventory_V2Model> GetAllInventory()
        {
            List<Inventory_V2Model> list = new List<Inventory_V2Model>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT * FROM TAS_Project.Inventory_v2;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Inventory_V2Model()
                        {
                            Inventory_id = Convert.ToInt32(reader["inventoryV2_id"]),
                            Date = reader["date"].ToString(),
                            Time = reader["time"].ToString(),
                            GasType = reader["gasType"].ToString(),
                            Volume = Convert.ToDouble(reader["volume"]),
                            Purchase = Convert.ToDouble(reader["purchase"]),
                            COG = Convert.ToDouble(reader["cog"]),
                        });
                    }
                }
                conn.Close();
                Console.WriteLine("info : " + DateTime.Today + " : Database connection success ");
            }
            return list;
        }

        //Sum inventory
        public List<InventorySumModel> getInventory_sum(string startDate, string endDate)
        {
            Console.WriteLine("info : " + DateTime.Today + " : query form " + startDate + "to" + endDate);

            List<InventorySumModel> list = new List<InventorySumModel>();

            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT SUM(Price)FROM TAS_Project.Inventory WHERE side = '1' AND date >= '2022-01-01 00:00:00 AM' AND date <= '2022-01-04 00:00:00 AM';";
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
                string sql = $"SELECT SUM(Price)FROM TAS_Project.Inventory WHERE side = '2' AND date >= '2022-01-01 00:00:00 AM' AND date <= '2022-01-04 00:00:00 AM';";
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

        // search inventory by id
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

        //Add new inventory item
        public void addInventory(string GasType, Double Volume, Double Purchase, Double COG)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string Date = DateTime.Today.ToString();
                string Time = DateTime.Today.ToString();
                conn.Open();
                Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
                string sql = $"INSERT INTO TAS_Project.Inventory_v2 (date, time, gasType, volume, purchase, cog) VALUES ('" + Date + "', '" + Time + "', '" + GasType + "', '" + Volume + "','" + Purchase + "','" + COG + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Close();
                Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database success ");
            }

            return;
        }

        // Pruchase order ----------------------------------------------------------------------------------------------
        public List<PurchaseOrderModel> getPurcahseOrder()
        {
            Console.WriteLine($"info : " + DateTime.Today + $" : get PurchaseOrder");
            List<PurchaseOrderModel> list = new List<PurchaseOrderModel>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT purchaseOrder_id,date,time,gasType,quantity,pricePerLitter,quantity*pricePerLitter as totalCost FROM TAS_Project.purchaseOrder";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PurchaseOrderModel()
                        {
                            PurchaseOrder_id = Convert.ToInt32(reader["purchaseOrder_id"]),
                            Date = reader["date"].ToString(),
                            Time = reader["time"].ToString(),
                            Type = reader["gasType"].ToString(),
                            Quantity = Convert.ToDouble(reader["quantity"]),
                            PricePerLitter = Convert.ToDouble(reader["pricePerLitter"]),
                            TotalCost = Convert.ToDouble(reader["totalCost"])
                        });
                    }
                }
                conn.Close();
                Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database success ");
            }

            return list;
        }

        // Invoice ----------------------------------------------------------------------------------------------
        public List<InvoiceModel> getInvoive()
        {
            Console.WriteLine($"info : " + DateTime.Today + $" : get Invoice");
            List<InvoiceModel> list = new List<InvoiceModel>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT invoice_id,date,time,gasType,quantity,pricePerLitter,quantity*pricePerLitter as totalCost FROM TAS_Project.invoice";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new InvoiceModel()
                        {
                            Invoice_id = Convert.ToInt32(reader["invoice_id"]),
                            Date = reader["date"].ToString(),
                            Time = reader["time"].ToString(),
                            Type = reader["gasType"].ToString(),
                            Quantity = Convert.ToDouble(reader["quantity"]),
                            PricePerLitter = Convert.ToDouble(reader["pricePerLitter"]),
                            TotalCost = Convert.ToDouble(reader["totalCost"])
                        });
                    }
                }
                conn.Close();
                Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database success ");
            }

            return list;
        }

        // Search invoice by id
        public List<InvoiceModel> getInvoiveById(int id)
        {
            Console.WriteLine($"info : " + DateTime.Today + $" : get Invoice id : " + id + "");
            List<InvoiceModel> list = new List<InvoiceModel>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT invoice_id,date,time,gasType,quantity,pricePerLitter,quantity*pricePerLitter as totalCost FROM TAS_Project.invoice WHERE invoice_id = {id}";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new InvoiceModel()
                        {
                            Invoice_id = Convert.ToInt32(reader["invoice_id"]),
                            Date = reader["date"].ToString(),
                            Time = reader["time"].ToString(),
                            Type = reader["gasType"].ToString(),
                            Quantity = Convert.ToDouble(reader["quantity"]),
                            PricePerLitter = Convert.ToDouble(reader["pricePerLitter"]),
                            TotalCost = Convert.ToDouble(reader["totalCost"])
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
