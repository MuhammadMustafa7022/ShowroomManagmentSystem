using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.Data
{
    public class Inspector
    {
        [Key]
        public int PkId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        [ForeignKey("Department")]
        public int FkDepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
