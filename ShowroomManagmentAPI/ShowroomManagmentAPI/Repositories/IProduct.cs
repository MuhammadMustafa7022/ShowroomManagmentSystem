using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IProduct
    {
        public Task<ResponseDTO> GetProduct();
        public Task<ResponseDTO> AddProduct(ProductDTO ProductDTO);
        public Task<ResponseDTO> DeleteProduct(int Id);
        public Task<ResponseDTO> GetProductById(int Id);
        public Task<ResponseDTO> UpdateProduct(ProductDTO ProductDTO);

    }
}
