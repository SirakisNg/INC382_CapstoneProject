using System;
namespace Backend.Models
{
    public class DataTableV2Model
    {
        //public DataTableV2Context context;

        public int purchaseOrder_id { get; set; }
        public int paymentNo { get; set; }
        public int invoiceNo { get; set; }
        public int user_id { get; set; }
        public int price_id { get; set; }
    }
}
