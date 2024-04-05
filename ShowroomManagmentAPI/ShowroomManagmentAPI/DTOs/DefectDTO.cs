using ShowroomManagmentAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.DTOs
{
    public class DefectDTO
    {
        public int DefectId { get; set; }
        public string Description { get; set; }
        public string Severity { get; set; }
        public int Status { get; set; }
        public int FKInspectionId { get; set; }
        public int VehicleId { get; set; }
       
    }
}
