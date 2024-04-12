using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Service_Managment_Module
{
    public class ServiceRecordModel : IServiceRecord
    {
        private readonly ApplicationDbContext context;
        public ServiceRecordModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseDTO> AddServiceRecord(ServiceRecordDTO serviceRecordDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var ServiceRecord = new ServiceRecord()
                {
                    ServiceDate = serviceRecordDTO.ServiceDate,
                    Description = serviceRecordDTO.Description,
                    FKServiceTypeId = serviceRecordDTO.FKServiceTypeId,
                    FKServiceAppointmentId = serviceRecordDTO.FKServiceAppointmentId,
                };
                await context.ServiceRecords.AddAsync(ServiceRecord);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Service Record Inserted";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> DeleteServiceRecord(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.ServiceRecords.Where(x => x.PkId == id).FirstOrDefaultAsync();
                if(Data != null)
                {
                    context.ServiceRecords.Remove(Data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "Service Record Inserted";
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
        public async Task<ResponseDTO> GetServiceRecord()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.ServiceRecords.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }   
        public async Task<ResponseDTO> GetServiceRecordById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.ServiceRecords.Where(x => x.PkId == id).FirstOrDefaultAsync();
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
        public async Task<ResponseDTO> UpdateServiceRecord(ServiceRecordDTO serviceRecordDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var ServiceRecord = new ServiceRecord()
                {
                    PkId = serviceRecordDTO.PkId,
                    ServiceDate = serviceRecordDTO.ServiceDate,
                    Description = serviceRecordDTO.Description,
                    FKServiceTypeId = serviceRecordDTO.FKServiceTypeId,
                    FKServiceAppointmentId = serviceRecordDTO.FKServiceAppointmentId,
                };
                context.ServiceRecords.Update(ServiceRecord);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Service Record Updated";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
