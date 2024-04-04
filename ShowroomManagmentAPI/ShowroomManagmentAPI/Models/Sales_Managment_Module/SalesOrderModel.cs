using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Sales_Managment_Module
{
    public class SalesOrderModel : ISaleOrder
    {
        private readonly ApplicationDbContext context;

        public SalesOrderModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<ResponseDTO> AddSaleOrder(SalesOrderDTO salesOrderDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var salesOrder = new SalesOrder()
                {
                    OrderDate = salesOrderDTO.OrderDate,
                    TotalAmount = salesOrderDTO.TotalAmount,
                    PaymentMethod = salesOrderDTO.PaymentMethod,
                    FkCustomerID = salesOrderDTO.FkCustomerID,
                    FkEmpolyeeID = salesOrderDTO.FkEmpolyeeID

                };
                await context.SaleOrders.AddAsync(salesOrder);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Sale Order Inserted Successfully";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> DeleteSaleOrder(int Id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var data = await context.SaleOrders.Where(x => x.OrderId == Id).FirstOrDefaultAsync();
                if (data != null)
                {
                    context.SaleOrders.Remove(data);
                    await context.SaveChangesAsync();
                    ResponseDTO.Response = "Sale Order Deleted";
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

        public async Task<ResponseDTO> GetSaleOrder()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.SaleOrders.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }

        public async Task<ResponseDTO> GetSaleOrderById(int Id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var data = await context.SaleOrders.Where(x => x.OrderId == Id).FirstOrDefaultAsync();
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

        public async Task<ResponseDTO> UpdateSaleOrder(SalesOrderDTO salesOrderDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var salesOrder = new SalesOrder()
                {
                    OrderId = salesOrderDTO.OrderId,
                    OrderDate = salesOrderDTO.OrderDate,
                    TotalAmount = salesOrderDTO.TotalAmount,
                    PaymentMethod = salesOrderDTO.PaymentMethod,
                    FkCustomerID = salesOrderDTO.FkCustomerID,
                    FkEmpolyeeID = salesOrderDTO.FkEmpolyeeID

                };
                context.SaleOrders.Update(salesOrder);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Sale Order Updated";

            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
