using Backend.Models;

namespace Backend.Models
{
    public class FinanceList
    {
        //private FinanceModel context;

        public int orderID { get; set; }

        public string date { get; set; }

        public int cost { get; set; }

        public int price { get; set; }

        public int gasID { get; set; }
        public int bayFillID { get; set; }
    }
}
