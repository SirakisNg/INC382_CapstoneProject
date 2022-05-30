using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Backend.Models;
using Microsoft.AspNetCore.Http;
using Backend.Utill;
using System.Data;
using MySql.Data.MySqlClient;



namespace Backend.Models
{
    public class DataTableContext
    {
        public string ConnectionString { get; set; }

        private DBConnect ConnectDB = new DBConnect();  //Database connection

        public DataTableContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<DataTableModel> showTable()
        {
            List<DataTableModel> list = new List<DataTableModel>();
            DataTable dt = ConnectDB.GetData($"SELECT * FROM TAS_Project.PurchaseOrder;");
            //Console.Write(dt.Rows[0]["purchaseOrder_id"].ToString());
            list.Add(new DataTableModel()
            {

                purchaseOrder_id = Convert.ToInt32(dt.Rows[0]["purchaseOrder_id"]),
                paymentNo = Convert.ToInt32(dt.Rows[0]["paymentNo"]),
                invoiceNo = Convert.ToInt32(dt.Rows[0]["invoiceNo"]),
                user_id = Convert.ToInt32(dt.Rows[0]["user_id"]),
                price_id = Convert.ToInt32(dt.Rows[0]["price_id"]),

            });
            return list;
        }


        public List<DataTableModel> getAllData()
        {
            List<DataTableModel> list = new List<DataTableModel>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM TAS_Project.PurchaseOrder;", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DataTableModel()
                        {
                            purchaseOrder_id = Convert.ToInt32(reader["purchaseOrder_id"]),
                            paymentNo = Convert.ToInt32(reader["paymentNo"]),
                            invoiceNo = Convert.ToInt32(reader["invoiceNo"]),
                            user_id = Convert.ToInt32(reader["user_id"]),
                            price_id = Convert.ToInt32(reader["price_id"])
                        });
                    }
                }
                conn.Close();
            }
            return list;
        }


        public List<DataTableModel> getTable()
        {
            List<DataTableModel> list = new List<DataTableModel>();
            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM TAS_Project.PurchaseOrder;", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DataTableModel()
                        {
                            purchaseOrder_id = Convert.ToInt32("1234"),
                            paymentNo = Convert.ToInt32("1234"),
                            invoiceNo = Convert.ToInt32("12344"),
                            user_id = Convert.ToInt32("1234"),
                            price_id = Convert.ToInt32("1234"),
                        });
                    }
                }
                conn.Close();
            }
            return list;
        }


    }
}
