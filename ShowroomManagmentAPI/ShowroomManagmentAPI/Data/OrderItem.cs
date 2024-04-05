using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShowroomManagmentAPI.Data
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        [ForeignKey("SalesOrder")]
        public int FkSaleOrderID { get; set; }
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public SalesOrder SalesOrder { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
