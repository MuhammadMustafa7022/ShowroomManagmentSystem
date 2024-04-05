using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IPurchaseOrderItem
    {
        public Task<ResponseDTO> GetPurchaseOrderItem();
        public Task<ResponseDTO> AddPurchaseOrderItem(PurchaseOrderItemDTO PurchaseOrderItemDTO);
        public Task<ResponseDTO> DeletePurchaseOrderItem(int Id);
        public Task<ResponseDTO> GetPurchaseOrderItemById(int Id);
        public Task<ResponseDTO> UpdatePurchaseOrderItem(PurchaseOrderItemDTO PurchaseOrderItemDTO);
    }
}
