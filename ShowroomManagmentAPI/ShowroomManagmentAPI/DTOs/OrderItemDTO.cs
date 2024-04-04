using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.DTOs
{
    public class OrderItemDTO
    {
        public int OrderItemId { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public int FkSaleOrderID { get; set; }
        public int VehicleId { get; set; }
    }
}
