using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Supplier_Module
{
    public class PurchaseOrderItemModel :IPurchaseOrderItem
    {
        private readonly ApplicationDbContext context;

        public PurchaseOrderItemModel(ApplicationDbContext context)
        {
            this.context = context;
        }



        public async Task<ResponseDTO> GetPurchaseOrderItem()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.PurchaseOrderItems.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> AddPurchaseOrderItem(PurchaseOrderItemDTO PurchaseOrderItemDTO)
        {
            var ResponseDTO = new ResponseDTO();

            try
            {
                var PurchaseOrderItem = new PurchaseOrderItem()
                {
                    ItemId = PurchaseOrderItemDTO.ItemId,
                    Qty = PurchaseOrderItemDTO.Qty,
                    UnitPrice = PurchaseOrderItemDTO.UnitPrice,
                    TotalPrice = PurchaseOrderItemDTO.TotalPrice,
                    FKPurchaseOrderId = PurchaseOrderItemDTO.FKPurchaseOrderId,
                    FkProductId = PurchaseOrderItemDTO.FkProductId,



                };

                await context.PurchaseOrderItems.AddAsync(PurchaseOrderItem);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "PurchaseOrderItem Inserted";

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> GetPurchaseOrderItemById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.PurchaseOrderItems.Where(x => x.ItemId == id).FirstOrDefaultAsync();
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

        public async Task<ResponseDTO> DeletePurchaseOrderItem(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.PurchaseOrderItems.Where(x => x.ItemId == id).FirstOrDefaultAsync();
                if (Data != null)
                {
                    context.PurchaseOrderItems.Remove(Data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "PurchaseOrderItem Deleted";
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

        public async Task<ResponseDTO> UpdatePurchaseOrderItem(PurchaseOrderItemDTO PurchaseOrderItemDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var PurchaseOrderItem = new PurchaseOrderItem()
                {
                    ItemId = PurchaseOrderItemDTO.ItemId,
                    Qty = PurchaseOrderItemDTO.Qty,
                    UnitPrice = PurchaseOrderItemDTO.UnitPrice,
                    TotalPrice = PurchaseOrderItemDTO.TotalPrice,
                    FKPurchaseOrderId = PurchaseOrderItemDTO.FKPurchaseOrderId,
                    FkProductId = PurchaseOrderItemDTO.FkProductId,
                };

                context.PurchaseOrderItems.Update(PurchaseOrderItem);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "PurchaseOrderItem Updated";

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
