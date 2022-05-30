//using System;
//using MySql.Data.MySqlClient;
//using Backend.Models;
//using System.Collections.Generic;

//namespace Backend.Models
//{
//    public class DataTableV2Context
//    {

//        //Database connection
//        public string ConnectionString { get; set; }
//        public DataTableV2Context(string connectionString)
//        {
//            this.ConnectionString = connectionString;
//        }
//        private MySqlConnection GetConnection()
//        {
//            return new MySqlConnection(ConnectionString);
//        }


//        public List<FinanceModel> getAllData()
//        {
//            List<FinanceModel> list = new List<FinanceModel>();
//            Console.WriteLine("info : " + DateTime.Today + " : Connect to the Database ... ");
//            using (MySqlConnection conn = GetConnection())
//            {
//                conn.Open();
//                MySqlCommand cmd = new($"SELECT * FROM TAS_Project.test where test_id = 1;", conn);
//                using (var reader = cmd.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        list.Add(new FinanceModel()
//                        {
//                            //purchaseOrder_id = Convert.ToInt32(reader["purchaseOrder_id"]),
//                            //paymentNo = Convert.ToInt32(reader["paymentNo"]),
//                            //invoiceNo = Convert.ToInt32(reader["invoiceNo"]),
//                            //user_id = Convert.ToInt32(reader["user_id"]),
//                            //price_id = Convert.ToInt32(reader["price_id"])
//                            test_id = Convert.ToInt32(reader["test_id"]),
//                            data = Convert.ToInt32(reader["data"]),

//                        });
//                    }
//                }
//                conn.Close();
//                return list;
//            }
            
//        }
//    }
//}
