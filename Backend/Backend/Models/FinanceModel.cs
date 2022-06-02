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
        public Double PricePerLitter { get; set; }
        public Double Volume { get; set; }
        public Double price { get; set; }
    }

    public class Inventory_V2Model
    {
        public int Inventory_id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string GasType { get; set; }
        public Double Volume { get; set; }
        public Double COG { get; set; }
        public Double price { get; set; }
        public Double purchase { get; set; }
        public Double InventoryD { get; set; }
        public Double InventoryG { get; set; }

    }



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

public class CycleModel
{
    public string Cycle { get; set; }
    public int DAVVolume { get; set; }
    public int SAVVolume { get; set; }
}

public class TagValue
{
    public string Values { get; set; }
    public DateTime TimeStamp { get; set; }
}

public class DataTable_V2Model
{
    public int ponumber { get; set; }
    public string Plate_number { get; set; }
    public string Enter_Sale { get; set; }
    public string Sales_Service_Time { get; set; }
    public string Exit_Sale { get; set; }
    public string Enter_Inbound_weighbridge { get; set; }
    public string in_weight_service_time { get; set; }
    public string Exit_Inbound_weighbridge { get; set; }
    public string Enter_bayloading { get; set; }
    public string bayloaing_service_time { get; set; }
    public string Exit_bayloading { get; set; }
    public string Enter_outbound_weighbridge { get; set; }
    public string outbound_weighbridge_servicetime { get; set; }
    public string Exit_outbound_weighbridge { get; set; }
    public string exit_gate { get; set; }
}

public class FJModel
{
    public int no { get; set; }
    public string Date { get; set; }
    public string Title { get; set; }
    public Double Debit { get; set; }
    public Double Credit { get; set; }

}


