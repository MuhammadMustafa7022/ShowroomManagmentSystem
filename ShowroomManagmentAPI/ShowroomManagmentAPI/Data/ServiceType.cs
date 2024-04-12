using System.ComponentModel.DataAnnotations;

namespace ShowroomManagmentAPI.Data
{
    public class ServiceType
    {
        [Key]
        public int PkId { get; set; }
        public bool TypeName { get; set; }

    }
}
