using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Sales_Managment_Module
{
    public class OrderItemModel : IOrderItem
    {
        private readonly ApplicationDbContext context;

        public OrderItemModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<ResponseDTO> AddOrderItem(OrderItemDTO orderItemDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var orderitem = new OrderItem()
                {
                    Quantity = orderItemDTO.Quantity,
                    Price = orderItemDTO.Price,
                    FkSaleOrderID = orderItemDTO.FkSaleOrderID,
                    VehicleId = orderItemDTO.VehicleId

                };
                await context.OrderItems.AddAsync(orderitem);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Order Item Inserted Successfully";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> DeleteOrderItem(int Id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var data = await context.OrderItems.Where(x => x.OrderItemId == Id).FirstOrDefaultAsync();
                if (data != null)
                {
                    context.OrderItems.Remove(data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "Order Item Deleted";
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

        public async Task<ResponseDTO> GetOrderItem()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.OrderItems.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> GetOrderItemById(int Id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var data = await context.OrderItems.Where(x => x.OrderItemId == Id).FirstOrDefaultAsync();
                if (data != null)
                {
                    ResponseDTO.Response = data;
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

        public async Task<ResponseDTO> UpdateOrderItem(OrderItemDTO orderItemDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var orderitem = new OrderItem()
                {
                    OrderItemId = orderItemDTO.OrderItemId,
                    Quantity = orderItemDTO.Quantity,
                    Price = orderItemDTO.Price,
                    FkSaleOrderID = orderItemDTO.FkSaleOrderID,
                    VehicleId = orderItemDTO.VehicleId

                };
                context.OrderItems.Update(orderitem);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Order Item Updated";

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
