using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.Data
{
    public class Transaction
    {
        [Key]
        public int PkId { get; set; }
        public bool TransactionType { get; set; }
        public float Amount { get; set; }
        public string Date { get; set; }
        [ForeignKey("purchaseOrdr")]
        public int FKPurchaseOrderId { get; set; }
        public PurchaseOrdr purchaseOrdr { get; set; }

    }
}
