using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IAttendance
    {
        public Task<ResponseDTO> GetAttendance();
        public Task<ResponseDTO> AddAttendance(AttendanceDTO attendanceDTO);
        public Task<ResponseDTO> GetAttendanceByEmployeeId(int id);
        public Task<ResponseDTO> UpdateAttendance(AttendanceDTO attendanceDTO);
    }
}
