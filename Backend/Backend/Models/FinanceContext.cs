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


        // public List<FinanceModel> getAllOrder()
        // {
        //     DataTable dt = ConnectDB.GetData("SELECT * FROM PurchaseOrder;");
        //     Console.WriteLine("info : " + DateTime.Today + " : Database connected");

        //     //List < DataRow > data = dt.AsEnumerable().ToList();

        //     var data = new List<FinanceModel>(dt.Rows.Count);
        //     foreach (DataRow row in dt.Rows)
        //     {
        //         var values = row.ItemArray;
        //         var value = new FinanceModel()
        //         {
        //             orderID = Convert.ToInt32(values[0]),
        //             date = values[1].ToString(),
        //             cost = Convert.ToInt32(values[2]),
        //             price = Convert.ToInt32(values[3]),
        //             gasID = Convert.ToInt32(values[4]),
        //             bayFillID = Convert.ToInt32(values[5]),
        //         };
        //         data.Add(value);
        //         string dataType = data.GetType().ToString();

        //     }
        //     return data;
        // }

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
            }
            Console.WriteLine(list[0]);
            foreach (FinanceModel item in list)
            {
                Console.WriteLine(item);
            }
            return list;
        }




    }
}
