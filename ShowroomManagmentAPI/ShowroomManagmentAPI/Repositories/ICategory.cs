using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface ICategory
    {
        public Task<ResponseDTO> GetCategory();
        public Task<ResponseDTO> AddCategory(CategoryDTO categoryDTO);
        public Task<ResponseDTO> DeleteCategory(int Id);
        public Task<ResponseDTO> GetCategoryById(int Id);
        public Task<ResponseDTO> UpdateCategory(CategoryDTO CategoryDTO);
    }
}
