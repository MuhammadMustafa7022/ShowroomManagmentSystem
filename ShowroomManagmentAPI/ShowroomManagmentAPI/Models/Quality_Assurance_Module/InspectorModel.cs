using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Quality_xyz_Module
{
    public class InspectorModel : IInspector
    {
        private readonly ApplicationDbContext context;
        public InspectorModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseDTO> GetInspector()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.Inspectors.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> AddInspector(InspectorDTO inspectorDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Inspector = new Inspector()
                {
                    Name = inspectorDTO.Name,
                    ContactNumber = inspectorDTO.ContactNumber,
                    FkDepartmentId = inspectorDTO.FkDepartmentId,
                };
                await context.Inspectors.AddAsync(Inspector);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Inspector Inserted";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> DeleteInspector(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Inspectors.Where(x => x.PkId == id).FirstOrDefaultAsync();
                if(Data != null)
                {
                    context.Inspectors.Remove(Data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "Inspector Deleted";
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
        public async Task<ResponseDTO> GetInspectorById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Inspectors.Where(x => x.PkId == id).FirstOrDefaultAsync();
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
        public async Task<ResponseDTO> UpdateInspector(InspectorDTO inspectorDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Inspector = new Inspector()
                {
                    PkId = inspectorDTO.PkId,
                    Name = inspectorDTO.Name,
                    ContactNumber = inspectorDTO.ContactNumber,
                    FkDepartmentId = inspectorDTO.FkDepartmentId,
                };
                context.Inspectors.Update(Inspector);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Inspector Updated";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
