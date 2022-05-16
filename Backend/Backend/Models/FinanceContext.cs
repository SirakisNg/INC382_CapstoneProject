using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Backend.Models;
using Backend.Utill;
using System.Linq;
using Google.Protobuf.Collections;

namespace Backend.Models
{
    public class FinanceContext
    {
        public string ConnectionString { get; set; }

        private DBConnect ConnectDB = new DBConnect();  //Database connection


        public  List<FinanceList> getAllOrder()
        {
            DataTable dt = ConnectDB.GetData($"SELECT * FROM TAS_Project.order;");

            //List < DataRow > data = dt.AsEnumerable().ToList();

            var data = new List<FinanceList>(dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
            {
                var values = row.ItemArray;
                var value = new FinanceList()
                {
                    orderID = Convert.ToInt32(values[0]),
                    date = values[1].ToString(),
                    cost = Convert.ToInt32(values[2]),
                    price = Convert.ToInt32(values[3]),
                    gasID = Convert.ToInt32(values[4]),
                    bayFillID = Convert.ToInt32(values[5]),
                };
                data.Add(value);
                
            }
            return data;
        }


    }
}
