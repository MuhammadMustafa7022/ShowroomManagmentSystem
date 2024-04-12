using ShowroomManagmentAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.DTOs
{
    public class ServiceAppointmentDTO
    {
        public int PkId { get; set; }
        public string AppointmentDate { get; set; }
        public string Description { get; set; }
        public int FKCustomerId { get; set; }
        public int FKVehicleId { get; set; }
        public int FKEmployeeId { get; set; }
    }
}
