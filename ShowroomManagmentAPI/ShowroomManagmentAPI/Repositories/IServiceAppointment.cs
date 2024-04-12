using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IServiceAppointment
    {
        public Task<ResponseDTO> GetServiceAppointment();
        public Task<ResponseDTO> AddServiceAppointment(ServiceAppointmentDTO serviceAppointmentDTO);
        public Task<ResponseDTO> DeleteServiceAppointment(int Id);
        public Task<ResponseDTO> GetServiceAppointmentById(int Id);
        public Task<ResponseDTO> UpdateServiceAppointment(ServiceAppointmentDTO serviceAppointmentDTO);
    }
}
