using ShowroomManagmentAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.DTOs
{
    public class TransactionDTO
    {
        public int PkId { get; set; }
        public bool TransactionType { get; set; }
        public float Amount { get; set; }
        public string Date { get; set; }
        public int FKPurchaseOrderId { get; set; }
    }
}
