using ShowroomManagmentAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShowroomManagmentAPI.DTOs
{
    public class InspectorDTO
    {
        public int PkId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public int FkDepartmentId { get; set; }
    }
}
