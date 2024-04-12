using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Service_Managment_Module
{
    public class ServiceAppointmentModel : IServiceAppointment
    {
        private readonly ApplicationDbContext context;
        public ServiceAppointmentModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseDTO> AddServiceAppointment(ServiceAppointmentDTO serviceAppointmentDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var ServiceAppointment = new ServiceAppointment()
                {
                    AppointmentDate = serviceAppointmentDTO.AppointmentDate,
                    Description = serviceAppointmentDTO.Description,
                    FKCustomerId = serviceAppointmentDTO.FKCustomerId,
                    FKVehicleId = serviceAppointmentDTO.FKVehicleId,
                    FKEmployeeId = serviceAppointmentDTO.FKEmployeeId,
                };
                await context.ServiceAppointments.AddAsync(ServiceAppointment);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Service Appointment Inserted";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> DeleteServiceAppointment(int Id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.ServiceAppointments.Where(x => x.PkId == Id).FirstOrDefaultAsync();
                if(Data != null)
                {
                    context.ServiceAppointments.Remove(Data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "Service Appointment Deleted";
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
        public async Task<ResponseDTO> GetServiceAppointment()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.ServiceAppointments.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> GetServiceAppointmentById(int Id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.ServiceAppointments.Where(x => x.PkId == Id).FirstOrDefaultAsync();
                if(Data  != null)
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
        public async Task<ResponseDTO> UpdateServiceAppointment(ServiceAppointmentDTO serviceAppointmentDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var ServiceAppointment = new ServiceAppointment()
                {
                    PkId = serviceAppointmentDTO.PkId,
                    AppointmentDate = serviceAppointmentDTO.AppointmentDate,
                    Description = serviceAppointmentDTO.Description,
                    FKCustomerId = serviceAppointmentDTO.FKCustomerId,
                    FKVehicleId = serviceAppointmentDTO.FKVehicleId,
                    FKEmployeeId = serviceAppointmentDTO.FKEmployeeId,
                };
                context.ServiceAppointments.Update(ServiceAppointment);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Service Appointment Updated";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
