
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShowroomManagmentAPI.Data
{
    public class PurchaseOrdr
    {
        [Key]
        public int PurchaseOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentStatus { get; set; }

        [ForeignKey("Supplier")]
        public int FKSupplierId { get; set; }

        public Supplier Supplier { get; set; }


    }
}
