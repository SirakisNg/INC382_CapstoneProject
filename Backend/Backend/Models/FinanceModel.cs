using System;
using Backend.Models;


namespace Backend.Models
{
    public class FinanceModel
    {

        public int test_id { get; set; }
        public int data { get; set; }

    }
    public class InventoryModel
    {
        public int inventory_id { get; set; }
        public int side { get; set; }
        public string type { get; set; }
        public int volume { get; set; }
        public int price { get; set; }
        public string date { get; set; }

    }
    public class InventorySumModel
    {
        public int Debit { get; set; }
        public int Cradit { get; set; }
    }


}
