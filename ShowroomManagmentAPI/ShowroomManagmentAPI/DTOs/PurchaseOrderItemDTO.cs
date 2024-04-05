namespace ShowroomManagmentAPI.DTOs
{
    public class PurchaseOrderItemDTO
    {
    public int ItemId { get; set; }
    public int Qty { get; set; }
    public float UnitPrice { get; set; }
    
    public float TotalPrice { get; set; }

    public  int FKPurchaseOrderId {get; set;}

    public int FkProductId { get; set;}
 
    }
}
