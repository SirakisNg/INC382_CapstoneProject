using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Backend.Models;
using Backend.Utill;
using System.Linq;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json.Linq;

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
        public string sDate = "2022-03-01";
        public string eDate = "2022-03-31";
        public List<Inventory_V2Model> getInventory(string startDate, string endDate)
        {
            if (startDate == null)
            {
                startDate = "2022-03-01";
                endDate = "2022-03-31";

            }

            Console.WriteLine("info : " + DateTime.Today + " : query form " + startDate + "to" + endDate);

            List<Inventory_V2Model> list = new List<Inventory_V2Model>();

            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT * FROM TAS_Project.data_inventory WHERE date >= '" + startDate + "' AND date <= '" + endDate + "';";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Inventory_V2Model()
                        {
                            Inventory_id = Convert.ToInt32(reader["inventory_id"]),
                            Date = reader["date"].ToString(),
                            Time = reader["time"].ToString(),
                            GasType = reader["gasType"].ToString(),
                            Volume = Convert.ToDouble(reader["volume"]),
                            COG = Convert.ToDouble(reader["cost_of_goods_sold"]),
                            price = Convert.ToDouble(reader["price"]),
                            purchase = Convert.ToDouble(reader["purchase"]),
                            InventoryD = Convert.ToDouble(reader["inventoryD"]),
                            InventoryG = Convert.ToDouble(reader["inventoryG"]),

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
                string sql = $"SELECT * FROM TAS_Project.data_inventory;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Inventory_V2Model()
                        {
                            Inventory_id = Convert.ToInt32(reader["inventory_id"]),
                            Date = reader["date"].ToString(),
                            Time = reader["time"].ToString(),
                            GasType = reader["gasType"].ToString(),
                            Volume = Convert.ToDouble(reader["volume"]),
                            COG = Convert.ToDouble(reader["cost_of_goods_sold"]),
                            price = Convert.ToDouble(reader["price"]),
                            purchase = Convert.ToDouble(reader["purchase"]),
                            InventoryD = Convert.ToDouble(reader["inventoryD"]),
                            InventoryG = Convert.ToDouble(reader["inventoryG"]),
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

        // General ledger ----------------------------------------------------------------------------------------------

        //Account recieveable
        public List<GLARModel> GetGLAR()
        {
            List<GLARModel> list = new List<GLARModel>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT * FROM TAS_Project.GLAR;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new GLARModel()
                        {
                            GLAR_id = Convert.ToInt32(reader["glar_id"]),
                            Date = reader["date"].ToString(),
                            Time = reader["time"].ToString(),
                            PONo = Convert.ToInt32(reader["poNo"]),
                            Description = reader["description"].ToString(),
                            Debit = Convert.ToDouble(reader["debit"]),
                            Credit = Convert.ToDouble(reader["credit"]),
                            Balance = Convert.ToDouble(reader["balance"]),
                        });
                    }
                }
                conn.Close();
                Console.WriteLine("info : " + DateTime.Today + " : Database connection success ");
            }
            return list;
        }

        //Cash
        public List<GLCModel> GetGLC()
        {
            List<GLCModel> list = new List<GLCModel>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT * FROM TAS_Project.GLC;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new GLCModel()
                        {
                            GLC_id = Convert.ToInt32(reader["glc_id"]),
                            Date = reader["date"].ToString(),
                            Time = reader["time"].ToString(),
                            Description = reader["description"].ToString(),
                            Debit = Convert.ToDouble(reader["debit"]),
                            Credit = Convert.ToDouble(reader["credit"]),
                            Balance = Convert.ToDouble(reader["balance"]),
                        });
                    }
                }
                conn.Close();
                Console.WriteLine("info : " + DateTime.Today + " : Database connection success ");
            }
            return list;
        }

        //Account Palable
        public List<GLAPModel> GetGLAP()
        {
            List<GLAPModel> list = new List<GLAPModel>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT * FROM TAS_Project.GLC;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new GLAPModel()
                        {
                            GLAP_id = Convert.ToInt32(reader["glap_id"]),
                            Date = reader["date"].ToString(),
                            Time = reader["time"].ToString(),
                            Description = reader["description"].ToString(),
                            Debit = Convert.ToDouble(reader["debit"]),
                            Credit = Convert.ToDouble(reader["credit"]),
                            Balance = Convert.ToDouble(reader["balance"]),
                        });
                    }
                }
                conn.Close();
                Console.WriteLine("info : " + DateTime.Today + " : Database connection success ");
            }
            return list;
        }

        //Account Inventory
        public List<GLIModel> GetGLI()
        {
            List<GLIModel> list = new List<GLIModel>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT * FROM TAS_Project.GLC;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new GLIModel()
                        {
                            GLI_id = Convert.ToInt32(reader["gli_id"]),
                            Date = reader["date"].ToString(),
                            Time = reader["time"].ToString(),
                            poNo = Convert.ToInt32(reader["poNo"]),
                            Description = reader["description"].ToString(),
                            Debit = Convert.ToDouble(reader["debit"]),
                            Credit = Convert.ToDouble(reader["credit"]),
                            Balance = Convert.ToDouble(reader["balance"]),
                        });
                    }
                }
                conn.Close();
                Console.WriteLine("info : " + DateTime.Today + " : Database connection success ");
            }
            return list;
        }

        //Operation----------------------------------------------------------------------------------------------

        //public List<CycleModel> AverageCycleTime()
        public int AverageCycleTime()
        {
            List<CycleModel> list = new List<CycleModel>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT * FROM TAS_Project.Operation_CycleTime;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CycleModel()
                        {
                            Cycle = reader["CycleTime"].ToString(),
                        });
                    }
                }
                conn.Close();
                Console.WriteLine("info : " + DateTime.Today + " : Database connection success ");
            }
            foreach (var data in list)
            {
                //Console.WriteLine(data.Cycle);
            }

            return 55;

            //return list;
        }

        //Average volume


        public async Task<List<TagValue>> getDieselVolDailyAsync(DateTime selDate)
        {
            // try
            // {
            Console.WriteLine(@$"Connecting to PI..." + selDate + "");
            var credentrials = new NetworkCredential("group1", "inc.382");
            HttpClientHandler clientHandler = new HttpClientHandler { Credentials = credentrials };
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyerrors) => { return true; }; // access to https
            HttpClient client = new HttpClient(clientHandler);

            Console.WriteLine("Connecting...");

            DateTime today = DateTime.Now;
            // DateTime month = new DateTime (2022,4,29);
            TimeSpan value = today.Subtract(selDate);
            // TimeSpan value = today.Subtract(month);

            string starttime = Convert.ToString(Convert.ToInt32(value.TotalDays));
            string endtime = Convert.ToString(Convert.ToInt32(value.TotalDays) - 1);
            string itemURL = $@"https://202.44.12.146:1443/piwebapi/streams/F1DP9bkh7eqdMUSKGalDzu9F3wyhUAAAUE1TU1ZcQIAWMSOWMDAWLVMZLURBVEEwMjA/recorded?starttime=*-" + starttime + "d&endtime=*-" + endtime + "d";
            //string itemURL = $@"https://202.44.12.146:1443/piwebapi/streams/F1DP9bkh7eqdMUSKGalDzu9F3wyhUAAAUE1TU1ZcQIAWMSOWMDAWLVMZLURBVEEwMjA/recorded?starttime=*-50d&endtime=*-20d";
            HttpResponseMessage response = await client.GetAsync(itemURL);
            string content = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(content);
            //var data = JsonConvert.DeserializeObject<JArray>(content);
            var data = (JArray)JObject.Parse(content)["Items"];
            //JArray jsonArray = JArray.Parse(content);
            //dynamic data = JObject.Parse(jsonArray[0].ToString());
            //var data = JsonConvert.DeserializeObject<object>(content);


            //var result = new List<TagValue>();
            List<TagValue> list = new List<TagValue>();

            // foreach (var item in data)
            // {

            //     // var dataPair = new TagValue()
            //     // {
            //     //     Values = item["Value"].Value<string>(),
            //     //     TimeStamp = item["Timestamp"].Value<DateTime>()
            //     // };
            //     // result.Add(dataPair);


            //     list.Add(new TagValue()
            //     {
            //         //Cycle = reader["CycleTime"].ToString(),
            //         Values = item["Value"].Value<string>(),
            //         TimeStamp = item["Timestamp"].Value<DateTime>()
            //     });
            // }
            return list;
        }


        // }
        // catch (Exception ex)
        // {
        //     return StatusCode(500, new { message = ex.Message });
        // }

        //Data table ------------------------------------------------------

        public List<DataTable_V2Model> getDataTableV2(string myInput)
        {

            Console.WriteLine(myInput);
            List<DataTable_V2Model> list = new List<DataTable_V2Model>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = $"SELECT * FROM tas_project.data_table;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DataTable_V2Model()
                        {
                            ponumber = Convert.ToInt32(reader["ponumber"]),
                            Plate_number = reader["Plate_number"].ToString(),
                            Enter_Sale = reader["Enter_Sale"].ToString(),
                            Sales_Service_Time = reader["Sales_Service_Time"].ToString(),
                            Exit_Sale = reader["Exit_Sale"].ToString(),
                            Enter_Inbound_weighbridge = reader["Enter_Inbound_weighbridge"].ToString(),
                            in_weight_service_time = reader["in_weight_service_time"].ToString(),
                            Exit_Inbound_weighbridge = reader["Exit_Inbound_weighbridge"].ToString(),
                            Enter_bayloading = reader["Enter_bayloading"].ToString(),
                            bayloaing_service_time = reader["bayloaing_service_time"].ToString(),
                            Exit_bayloading = reader["Exit_bayloading"].ToString(),
                            Enter_outbound_weighbridge = reader["Enter_outbound_weighbridge"].ToString(),
                            outbound_weighbridge_servicetime = reader["outbound_weighbridge_servicetime"].ToString(),
                            Exit_outbound_weighbridge = reader["Exit_outbound_weighbridge"].ToString(),
                            exit_gate = reader["exit_gate"].ToString()
                        });
                    }
                    conn.Close();
                    Console.WriteLine("info : " + DateTime.Today + " : Database connection success ");
                }
                return list;
            }









        }






    }







}

