using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Supplier_Module
{



    public class SupplierModel : ISupplier
    {

        private readonly ApplicationDbContext context;

        public SupplierModel(ApplicationDbContext context)
        {
            this.context = context;
        }



        public async Task<ResponseDTO> GetSupplier()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.Suppliers.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> AddSupplier(SupplierDTO SupplierDTO)
        {
            var ResponseDTO = new ResponseDTO();

            try
            {
                var Supplier = new Supplier()
                {
                    Name = SupplierDTO.Name,
                    Email = SupplierDTO.Email,
                    Adress= SupplierDTO.Adress,
                    PhoneNum = SupplierDTO.PhoneNum
                };

                await context.Suppliers.AddAsync(Supplier);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Supplier Inserted";

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> GetSupplierById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Suppliers.Where(x => x.SupplierId == id).FirstOrDefaultAsync();
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

        public async Task<ResponseDTO> DeleteSupplier(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Suppliers.Where(x => x.SupplierId == id).FirstOrDefaultAsync();
                if (Data != null)
                {
                    context.Suppliers.Remove(Data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "Supplier Deleted";
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

        public async Task<ResponseDTO> UpdateSupplier(SupplierDTO SupplierDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Supplier = new Supplier()
                {
                    SupplierId = SupplierDTO.SupplierId,
                    Name = SupplierDTO.Name,
                    Email = SupplierDTO.Email,
                    Adress = SupplierDTO.Adress,
                    PhoneNum = SupplierDTO.PhoneNum,
                };

                context.Suppliers.Update(Supplier);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Supplier Updated";

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

       
    }

}