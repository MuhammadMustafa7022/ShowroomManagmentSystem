using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface ISaleOrder
    {
        public Task<ResponseDTO> GetSaleOrder();
        public Task<ResponseDTO> AddSaleOrder(SalesOrderDTO salesOrderDTO);
        public Task<ResponseDTO> GetSaleOrderById(int Id);
        public Task<ResponseDTO> UpdateSaleOrder(SalesOrderDTO salesOrderDTO);
        public Task<ResponseDTO> DeleteSaleOrder(int Id);
    }
}
