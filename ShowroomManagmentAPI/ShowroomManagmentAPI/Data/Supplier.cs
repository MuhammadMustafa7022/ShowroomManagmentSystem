using System.ComponentModel.DataAnnotations;

namespace ShowroomManagmentAPI.Data
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string PhoneNum { get; set; }
        
       
    }
}
