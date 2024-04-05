using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.Data
{
    public class PurchaseOrderItem
    {
        [Key]
        public int ItemId { get; set; }
        public int Qty { get; set; }
        public float UnitPrice { get; set; }

        public float TotalPrice { get; set; }

        [ForeignKey("PurchaseOrdr")]
        public int FKPurchaseOrderId { get; set; }

        [ForeignKey("Product")]
        public int FkProductId { get; set; }

        public PurchaseOrdr PurchaseOrdr { get; set; }
        public  Product Product { get; set; }
    }
}
