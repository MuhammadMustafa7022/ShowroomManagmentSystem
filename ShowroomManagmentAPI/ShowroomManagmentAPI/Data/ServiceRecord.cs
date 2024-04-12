using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.Data
{
    public class ServiceRecord
    {
        [Key]
        public int PkId { get; set; }
        public string ServiceDate { get; set; }
        public string Description { get; set; }
        [ForeignKey("ServiceType")]
        public int FKServiceTypeId { get; set; }
        [ForeignKey("ServiceAppointment")]
        public int FKServiceAppointmentId { get; set; }
        public ServiceType ServiceType { get; set; }
        public ServiceAppointment ServiceAppointment { get; set; }
    }
}
