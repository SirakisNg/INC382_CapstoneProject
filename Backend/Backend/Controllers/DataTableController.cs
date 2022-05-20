//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using Backend.Models;
//using Microsoft.AspNetCore.Http;
//using Backend.Utill;
//using System.Data;

//namespace Backend.Controllers
//{
//    public class DataTableController : Controller
//    {
//        private readonly ILogger<DataTableController> _logger;
//        public DataTableController(ILogger<DataTableController> logger) => _logger = logger;


//        private DBConnect ConnectDB = new DBConnect(); //Database connection

//        public string Index()
//        {
//            Console.WriteLine("info : " + DateTime.Today + " : Data table access test success ...");
//            return "This is a DataTable test response";
//        }



//        public IActionResult Table()
//        {
//            DataTableV2Context context = HttpContext.RequestServices.GetService(typeof(Backend.Models.DataTableV2Context)) as DataTableV2Context;
//            //Console.WriteLine(context.showTable());
//            Console.WriteLine("info : " + DateTime.Today + " : Get table data");

//            return View(context.getAllData());
//        }


//        public List<DataTableModel> TableV2()
//        {
//            List<DataTableModel> dataList = new List<DataTableModel>();
//            DataTable dt = ConnectDB.GetData($"SELECT * FROM TAS_Project.PurchaseOrder;");
//            Console.Write(dt.Rows[0]["purchaseOrder_id"].ToString());
//            for (int i = 0; i < dt.Rows.Count; i++)
//            {
//                dataList.Add(new DataTableModel()
//                {
//                    purchaseOrder_id = Convert.ToInt32(dt.Rows[i]["purchaseOrder_id"]),
//                    paymentNo = Convert.ToInt32(dt.Rows[i]["paymentNo"]),
//                    invoiceNo = Convert.ToInt32(dt.Rows[i]["invoiceNo"]),
//                    user_id = Convert.ToInt32(dt.Rows[i]["user_id"]),
//                    price_id = Convert.ToInt32(dt.Rows[i]["price_id"]),
//                });
//            }
//            Console.WriteLine(dataList.GetType());
//            foreach (var op in dataList)
//            {
//                if (!string.IsNullOrEmpty(TempData["null"].ToString()))
//                    Console.Write(op + " ");
//            }
//            return dataList;
//        }
//    }
//}
