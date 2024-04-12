using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.Data
{
    public class ServiceAppointment
    {
        [Key]
        public int PkId { get; set; }
        public string AppointmentDate { get; set; }
        public string Description { get; set;}
        [ForeignKey("Customer")]
        public int FKCustomerId { get; set; }
        [ForeignKey("Vehicle")]
        public int FKVehicleId { get; set; }
        [ForeignKey("Employee")]
        public int FKEmployeeId { get; set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        public Employee Employee { get; set; }
    }
}
