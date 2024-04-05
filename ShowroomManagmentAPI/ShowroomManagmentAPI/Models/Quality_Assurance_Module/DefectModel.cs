using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Quality_Assurance_Module
{
    public class DefectModel : IDefect
    {
        private readonly ApplicationDbContext context;
        public DefectModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseDTO> AddDefect(DefectDTO defectDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var defect = new Defects()
                {
                    Description = defectDTO.Description,
                    Severity = defectDTO.Severity,
                    Status = defectDTO.Status,
                    FKInspectionId = defectDTO.FKInspectionId,
                    VehicleId = defectDTO.VehicleId,
                   
                };
                await context.Defects.AddAsync(defect);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Defect Inserted";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> DeleteDefect(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var data = await context.Defects.Where(x => x.DefectId == id).FirstOrDefaultAsync();
                if (data != null)
                {
                    context.Defects.Remove(data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "Defect Deleted";
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

        public async Task<ResponseDTO> GetDefect()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.Defects.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> GetDefectById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var data = await context.Defects.Where(x => x.DefectId == id).FirstOrDefaultAsync();
                if (data != null)
                {
                    ResponseDTO.Response = data;
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

        public async Task<ResponseDTO> UpdateDefect(DefectDTO defectDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var defect = new Defects()
                {
                    DefectId = defectDTO.DefectId,
                    Description = defectDTO.Description,
                    Severity = defectDTO.Severity,
                    Status = defectDTO.Status,
                    FKInspectionId = defectDTO.FKInspectionId,
                    VehicleId = defectDTO.VehicleId,

                };
                context.Defects.Update(defect);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Defect Updated";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
