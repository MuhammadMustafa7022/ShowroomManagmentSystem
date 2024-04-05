using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.Data
{
    public class Product
    {

        [Key]
        public int ProductId { get; set; }
        public string Discription { get; set; }


        [ForeignKey("Category")]
        public int FKCategoryId { get; set; }

        public Category Category{ get; set; }

    }
}
