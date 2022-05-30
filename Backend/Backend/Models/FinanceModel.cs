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
    public class PurchaseOrderModel
    {
        public int PurchaseOrder_id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public Double Quantity { get; set; }
        public Double PricePerLitter { get; set; }
        public Double TotalCost { get; set; }
    }
    public class InvoiceModel
    {
        public int Invoice_id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public Double Quantity { get; set; }
        public Double PricePerLitter { get; set; }
        public Double TotalCost { get; set; }
    }

    public class Inventory_V2Model
    {
        public int Inventory_id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string GasType { get; set; }
        public Double Volume { get; set; }
        public Double Purchase { get; set; }
        public Double COG { get; set; }
    }
    public class GLARModel
    {
        public int GLAR_id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int PONo { get; set; }
        public string Description { get; set; }
        public Double Debit { get; set; }
        public Double Credit { get; set; }
        public Double Balance { get; set; }
    }

    public class GLCModel
    {
        public int GLC_id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public Double Debit { get; set; }
        public Double Credit { get; set; }
        public Double Balance { get; set; }
    }

    public class GLAPModel
    {
        public int GLAP_id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public Double Debit { get; set; }
        public Double Credit { get; set; }
        public Double Balance { get; set; }
    }

    public class GLIModel
    {
        public int GLI_id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int poNo { get; set; }
        public string Description { get; set; }
        public Double Debit { get; set; }
        public Double Credit { get; set; }
        public Double Balance { get; set; }
    }

}
