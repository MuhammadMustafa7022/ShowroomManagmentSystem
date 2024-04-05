using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface IOrderItem
    {
        public Task<ResponseDTO> GetOrderItem();
        public Task<ResponseDTO> AddOrderItem(OrderItemDTO orderItemDTO);
        public Task<ResponseDTO> GetOrderItemById(int Id);
        public Task<ResponseDTO> UpdateOrderItem(OrderItemDTO orderItemDTO);
        public Task<ResponseDTO> DeleteOrderItem(int Id);
    }
}
