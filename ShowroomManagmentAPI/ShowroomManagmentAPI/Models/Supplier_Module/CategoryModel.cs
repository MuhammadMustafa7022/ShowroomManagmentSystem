using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Supplier_Module
{
    public class CategoryModel : ICategory
    {
        private readonly ApplicationDbContext context;

        public CategoryModel(ApplicationDbContext context)
        {
            this.context = context;
        }



        public async Task<ResponseDTO> GetCategory()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.Categories.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> AddCategory(CategoryDTO CategoryDTO)
        {
            var ResponseDTO = new ResponseDTO();

            try
            {
                var Category = new Category()
                {
                    CategoryName = CategoryDTO.CategoryName,
                    CategoryDiscription = CategoryDTO.CategoryDiscription,
                    
                };

                await context.Categories.AddAsync(Category);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Category Inserted";

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> GetCategoryById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Categories.Where(x => x.CategoryId == id).FirstOrDefaultAsync();
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

        public async Task<ResponseDTO> DeleteCategory(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Categories.Where(x => x.CategoryId == id).FirstOrDefaultAsync();
                if (Data != null)
                {
                    context.Categories.Remove(Data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "Category Deleted";
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

        public async Task<ResponseDTO> UpdateCategory(CategoryDTO CategoryDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Category = new Category()
                {
                    CategoryId  =CategoryDTO.CategoryId,
                    CategoryName = CategoryDTO.CategoryName,
                    CategoryDiscription = CategoryDTO.CategoryDiscription,
                };

                context.Categories.Update(Category);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Category Updated";

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

    }
}
