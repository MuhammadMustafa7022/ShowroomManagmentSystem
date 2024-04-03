using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models
{
    public class VehicleCategoryModel : IVehicleCategory
    {
        public readonly ApplicationDbContext Context;
        public VehicleCategoryModel(ApplicationDbContext _Context)
        {
            this.Context = _Context;
        }

        public async Task<ResponseDTO> GetVehicleCategory()
        {
            var Response = new ResponseDTO();

            try
            {
                Response.Response = await Context.VehicleCategorys.ToListAsync();
            }
            catch (Exception ex)
            {
                Response.ErrorMessage = ex.Message;
            }

            return Response;
        }

        public async Task<ResponseDTO> AddVehicleCategory(VehicleCategoryDTO VehicleCategoryDTO)
        {
            var Response = new ResponseDTO();

            try
            {
                var VehicleCategory = new VehicleCategory()
                {
                    CategoryName = VehicleCategoryDTO.CategoryName,
                    Description = VehicleCategoryDTO.Description,
                };

                await Context.VehicleCategorys.AddAsync(VehicleCategory);
                await Context.SaveChangesAsync();
                Response.Response = "Vehicle Category has been Inserted";
            }
            catch (Exception ex)
            {
                Response.ErrorMessage = ex.Message;
            }

            return Response;
        }

        public async Task<ResponseDTO> GetVehicleCategoryById(int Id)
        {
            var Response = new ResponseDTO();

            try
            {
                var Data = await Context.VehicleCategorys.Where(x => x.CategoryId == Id).FirstOrDefaultAsync();
                if (Data != null)
                {
                    Response.Response = Data;
                }
                else
                {
                    Response.StatusCode = 404;
                }
            }
            catch (Exception ex)
            {
                Response.ErrorMessage = ex.Message;
            }

            return Response;
        }

        public async Task<ResponseDTO> DeleteVehicleCategory(int Id)
        {
            var Response = new ResponseDTO();

            try
            {
                var Data = await Context.VehicleCategorys.Where(x=>x.CategoryId == Id).FirstOrDefaultAsync();

                if (Data != null)
                {
                    Context.VehicleCategorys.Remove(Data);
                    await Context.SaveChangesAsync();
                    Response.Response = "Vehicle Categorys has been Deleted";
                }
                else
                {
                    Response.StatusCode = 404;
                }
            }
            catch (Exception ex)
            {
                Response.ErrorMessage = ex.Message;
            }

            return Response;
        }

        public async Task<ResponseDTO> UpdateVehicleCategory(VehicleCategoryDTO VehicleCategoryDTO)
        {
            var Response = new ResponseDTO();

            try
            {
                var VehicleCategory = new VehicleCategory()
                {
                    CategoryId = VehicleCategoryDTO.CategoryId,
                    CategoryName = VehicleCategoryDTO.CategoryName,
                    Description = VehicleCategoryDTO.Description,
                };

                await Context.VehicleCategorys.AddAsync(VehicleCategory);
                await Context.SaveChangesAsync();
                Response.Response = "Vehicle Category has been Updated";
            }
            catch (Exception ex)
            {
                Response.ErrorMessage = ex.Message;
            }

            return Response;
        }
    }
}
