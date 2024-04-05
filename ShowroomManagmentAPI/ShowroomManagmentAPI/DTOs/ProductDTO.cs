namespace ShowroomManagmentAPI.DTOs
{
    public class ProductDTO
    {

        public int ProductId { get; set; }
        public string Discription { get; set; }

        public int  FKCategoryId { get; set; }
    }
}
