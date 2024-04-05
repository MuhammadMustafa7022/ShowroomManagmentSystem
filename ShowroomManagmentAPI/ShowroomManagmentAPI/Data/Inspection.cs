using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.Data
{
    public class Inspection
    {
        [Key]
        public int PkId { get; set; }
        public string InspectionType { get; set; }
        public bool Result { get; set; }
        [ForeignKey("Inspector")]
        public int FKInspectorId { get; set; }
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public Inspector Inspector  { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
