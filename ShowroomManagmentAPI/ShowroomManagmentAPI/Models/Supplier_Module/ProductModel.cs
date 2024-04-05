using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Supplier_Module
{
    public class ProductModel:IProduct
    {
        private readonly ApplicationDbContext context;

        public ProductModel(ApplicationDbContext context)
        {
            this.context = context;
        }



        public async Task<ResponseDTO> GetProduct()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.Products.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> AddProduct(ProductDTO ProductDTO)
        {
            var ResponseDTO = new ResponseDTO();

            try
            {
                var Product = new Product()
                {
                    ProductId = ProductDTO.ProductId,
                    Discription = ProductDTO.Discription,
                    FKCategoryId = ProductDTO.FKCategoryId,

                };

                await context.Products.AddAsync(Product);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Product Inserted";

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> GetProductById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Products.Where(x => x.ProductId == id).FirstOrDefaultAsync();
                if (Data != null)
                {
                    ResponseDTO.Response = Data;
                }
                else
                {
                    ResponseDTO.StatusCode = 404;
                }
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> DeleteProduct(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Products.Where(x => x.ProductId == id).FirstOrDefaultAsync();
                if (Data != null)
                {
                    context.Products.Remove(Data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "Product Deleted";
                }
                else
                {
                    ResponseDTO.StatusCode = 404;
                }
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> UpdateProduct(ProductDTO ProductDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Product = new Product()
                {
                    ProductId = ProductDTO.ProductId,
                    Discription = ProductDTO.Discription,
                    FKCategoryId = ProductDTO.FKCategoryId,
                };

                context.Products.Update(Product);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Product Updated";

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

       
    }
}
