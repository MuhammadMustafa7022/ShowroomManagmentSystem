using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Employee_Module
{
    public class AttendanceModel : IAttendance
    {
        private readonly ApplicationDbContext context;
        public AttendanceModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseDTO> GetAttendance()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.Attendances.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> AddAttendance(AttendanceDTO attendanceDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Attendance = new Attendance()
                {
                    Date = attendanceDTO.Date,
                    TimeIn = attendanceDTO.TimeIn,
                    TimeOut = attendanceDTO.TimeOut,
                    FKEmployeeId = attendanceDTO.FKEmployeeId
                };
                await context.Attendances.AddAsync(Attendance);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Attendance Inserted";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> GetAttendanceByEmployeeId(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Attendances.Where(x => x.FKEmployeeId == id).FirstOrDefaultAsync();
                if (Data != null)
                {
                    ResponseDTO.Response = Data;
                }
                else
                {
                    ResponseDTO.Response = 404;
                }
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> UpdateAttendance(AttendanceDTO attendanceDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Attendance = new Attendance()
                {
                    PkId = attendanceDTO.PkId,
                    Date = attendanceDTO.Date,
                    TimeIn = attendanceDTO.TimeIn,
                    TimeOut = attendanceDTO.TimeOut,
                    FKEmployeeId = attendanceDTO.FKEmployeeId,
                };
                context.Attendances.Update(Attendance);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Attendance Updated";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;

        }
    }
}
