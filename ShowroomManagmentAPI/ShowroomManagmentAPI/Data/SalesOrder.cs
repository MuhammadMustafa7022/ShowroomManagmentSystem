using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShowroomManagmentAPI.Data
{
    public class SalesOrder
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public string TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        [ForeignKey("Customer")]
        public int FkCustomerID { get; set; }
        [ForeignKey("Empolyee")]
        public int FkEmpolyeeID { get; set; }
        public Customer Customer { get; set; }
        public Employee Empolyee { get; set; }
    }
}
