using System.ComponentModel.DataAnnotations;

namespace ShowroomManagmentAPI.Data
{
    public class VehicleCategory
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
