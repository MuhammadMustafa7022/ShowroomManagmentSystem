using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.Data
{
    public class Defect
    {
        [Key]
        public int DefectId { get; set; }
        public string Description { get; set; }
        public string Severity { get; set; }
        public int Status { get; set; }
        [ForeignKey("Inspection")]
        public int FKInspectionId { get; set; }
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public Inspection Inspection { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
