namespace ShowroomManagmentAPI.DTOs
{
    public class PurchaseOrdrDTO
    {
        public int PurchaseOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
        public int FKSupplierId { get; set; }
    }
}
