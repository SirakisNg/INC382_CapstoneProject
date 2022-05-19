using Backend.Models;


namespace Backend.Models
{
    public class DataTableModel
    {
        public DataTableContext context;
        public int purchaseOrder_id { get; set; }
        public int paymentNo { get; set; }
        public int invoiceNo { get; set; }
        public int user_id { get; set; }
        public int price_id { get; set; }
    }

}
