using ShowroomManagmentAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShowroomManagmentAPI.DTOs
{
    public class SalesOrderDTO
    {  
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public string TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public int FkCustomerID { get; set; }
        public int FkEmpolyeeID { get; set; }
     
    }
}
