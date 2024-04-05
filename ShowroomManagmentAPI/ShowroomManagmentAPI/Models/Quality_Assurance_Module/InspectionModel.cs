using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Quality_Assurance_Module
{
    public class InspectionModel : IInspection
    {
        private readonly ApplicationDbContext context;
        public InspectionModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseDTO> GetInspection()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.Inspections.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> AddInspection(InspectionDTO inspectionDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Inspection = new Inspection()
                {
                    InspectionType = inspectionDTO.InspectionType,
                    Result = inspectionDTO.Result,
                    FKInspectorId = inspectionDTO.FKInspectorId,
                    VehicleId = inspectionDTO.VehicleId,
                };
                await context.Inspections.AddAsync(Inspection);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Inspection Inserted";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> GetInspectionById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var data = await context.Inspections.Where(x => x.PkId == id).FirstOrDefaultAsync();
                if(data != null)
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
        public async Task<ResponseDTO> DeleteInspection(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var data = await context.Inspections.Where(x=>x.PkId == id).FirstOrDefaultAsync();
                if(data != null)
                {
                    context.Inspections.Remove(data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "Inspection Deleted";
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
        public async Task<ResponseDTO> UpdateInspection(InspectionDTO inspectionDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Inspection = new Inspection()
                {
                    PkId = inspectionDTO.PkId,
                    InspectionType = inspectionDTO.InspectionType,
                    Result = inspectionDTO.Result,
                    FKInspectorId = inspectionDTO.FKInspectorId,
                    VehicleId = inspectionDTO.VehicleId,
                };
                context.Inspections.Update(Inspection);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Inspection Updated";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
