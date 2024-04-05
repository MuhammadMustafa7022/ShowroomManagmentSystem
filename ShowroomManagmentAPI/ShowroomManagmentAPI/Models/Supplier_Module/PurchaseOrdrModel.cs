using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Supplier_Module
{
    public class PurchaseOrdrModel : IPurchaseOrdr
    {


        private readonly ApplicationDbContext context;


        public PurchaseOrdrModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<ResponseDTO> GetPurchaseOrdr()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.PurchaseOrdrs.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> AddPurchaseOrdr(PurchaseOrdrDTO PurchaseOrdrDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {

                var PurchaseOrdr = new PurchaseOrdr()
                {
                    PurchaseOrderId=PurchaseOrdrDTO.PurchaseOrderId, 
                    OrderDate = PurchaseOrdrDTO.OrderDate,
                    TotalAmount = PurchaseOrdrDTO.TotalAmount,
                    PaymentStatus=PurchaseOrdrDTO.PaymentStatus,
                    FKSupplierId = PurchaseOrdrDTO.FKSupplierId,

                };

                await context.PurchaseOrdrs.AddAsync(PurchaseOrdr);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "PurchaseOrdr Inserted";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> GetPurchaseOrdrById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.PurchaseOrdrs.Where(x => x.PurchaseOrderId == id).FirstOrDefaultAsync();
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

        public async Task<ResponseDTO> DeletePurchaseOrdr(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.PurchaseOrdrs.Where(x => x.PurchaseOrderId == id).FirstOrDefaultAsync();


                if (Data != null)
                {
                    context.PurchaseOrdrs.Remove(Data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "PurchaseOrdr Deleted";
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

        public async Task<ResponseDTO> UpdatePurchaseOrdr(PurchaseOrdrDTO PurchaseOrdrDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var PurchaseOrdr = new PurchaseOrdr()
                {
                    PurchaseOrderId=PurchaseOrdrDTO.PurchaseOrderId,
                    OrderDate = PurchaseOrdrDTO.OrderDate,
                    TotalAmount = PurchaseOrdrDTO.TotalAmount,
                    PaymentStatus = PurchaseOrdrDTO.PaymentStatus,
                    FKSupplierId = PurchaseOrdrDTO.FKSupplierId,
                };

                context.PurchaseOrdrs.Update(PurchaseOrdr);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Product Updated";

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

      
    }
}
