using System.ComponentModel.DataAnnotations;

namespace ShowroomManagmentAPI.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDiscription { get; set; }
    }
}
