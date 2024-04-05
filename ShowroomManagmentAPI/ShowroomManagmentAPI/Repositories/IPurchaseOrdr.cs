using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IPurchaseOrdr
    {


        public Task<ResponseDTO> GetPurchaseOrdr();
        public Task<ResponseDTO> AddPurchaseOrdr(PurchaseOrdrDTO PurchaseOrdrDTO);
        public Task<ResponseDTO> GetPurchaseOrdrById(int id);
        public Task<ResponseDTO> DeletePurchaseOrdr(int id);
        public Task<ResponseDTO> UpdatePurchaseOrdr(PurchaseOrdrDTO PurchaseOrdrDTO);
    }
}
