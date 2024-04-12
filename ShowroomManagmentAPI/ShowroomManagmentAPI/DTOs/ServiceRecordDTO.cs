using ShowroomManagmentAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.DTOs
{
    public class ServiceRecordDTO
    {
        public int PkId { get; set; }
        public string ServiceDate { get; set; }
        public string Description { get; set; }
        public int FKServiceTypeId { get; set; }
        public int FKServiceAppointmentId { get; set; }
    }
}
