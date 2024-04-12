using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Service_Managment_Module
{
    public class ServiceTypeModel : IServiceType
    {
        private readonly ApplicationDbContext context;
        public ServiceTypeModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseDTO> AddServiceType(ServiceTypeDTO serviceTypeDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var ServiceType = new ServiceType()
                {
                    TypeName = serviceTypeDTO.TypeName,
                };
                await context.ServiceTypes.AddAsync(ServiceType);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Service Type Inserted";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> DeleteServiceType(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.ServiceTypes.Where(x => x.PkId == id).FirstOrDefaultAsync();
                if (Data != null)
                {
                    context.ServiceTypes.Remove(Data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "Service Type Inserted";
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
        public async Task<ResponseDTO> GetServiceType()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.ServiceTypes.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> GetServiceTypeById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.ServiceTypes.Where(x => x.PkId == id).FirstOrDefaultAsync();
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
        public async Task<ResponseDTO> UpdateServiceType(ServiceTypeDTO serviceTypeDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var ServiceType = new ServiceType()
                {
                    PkId = serviceTypeDTO.PkId,
                    TypeName = serviceTypeDTO.TypeName,
                };
                context.ServiceTypes.Update(ServiceType);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Service Type Updated";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO; ;
        }
    }
}
