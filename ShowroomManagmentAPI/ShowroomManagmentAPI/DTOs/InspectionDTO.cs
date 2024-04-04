using ShowroomManagmentAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.DTOs
{
    public class InspectionDTO
    {
        public int PkId { get; set; }
        public string InspectionType { get; set; }
        public bool Result { get; set; }
        public int FKInspectorId { get; set; }
        public int VehicleId { get; set; }
    }
}
