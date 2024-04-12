using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.DTOs;
using ShowroomManagmentAPI.Repositories;

namespace ShowroomManagmentAPI.Models.Transaction_Module
{
    public class TransactionModel : ITransaction
    {
        private readonly ApplicationDbContext context;
        public TransactionModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseDTO> AddTransaction(TransactionDTO transactionDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Transaction = new Transaction()
                {
                    TransactionType = transactionDTO.TransactionType,
                    Amount = transactionDTO.Amount,
                    Date = transactionDTO.Date,
                    FKPurchaseOrderId = transactionDTO.FKPurchaseOrderId,
                };
                await context.Transactions.AddAsync(Transaction);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Transaction Inserted";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
        public async Task<ResponseDTO> DeleteTransaction(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Transactions.Where(x => x.PkId == id).FirstOrDefaultAsync();
                if(Data != null)
                {
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Transaction Deleted";
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
        public async Task<ResponseDTO> GetTransaction()
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                ResponseDTO.Response = await context.Transactions.ToListAsync();
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;

        }
        public async Task<ResponseDTO> GetTransactionById(int id)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Data = await context.Transactions.Where(x => x.PkId == id).FirstOrDefaultAsync();
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
        public async Task<ResponseDTO> UpdateTransaction(TransactionDTO transactionDTO)
        {
            var ResponseDTO = new ResponseDTO();
            try
            {
                var Transaction = new Transaction()
                {
                    PkId = transactionDTO.PkId,
                    TransactionType = transactionDTO.TransactionType,
                    Amount = transactionDTO.Amount,
                    Date = transactionDTO.Date,
                    FKPurchaseOrderId = transactionDTO.FKPurchaseOrderId,
                };
                context.Transactions.Update(Transaction);
                await context.SaveChangesAsync();
                ResponseDTO.Response = "Transaction Updated";
            }
            catch (Exception ex)
            {
                ResponseDTO.ErrorMessage = ex.Message;
            }
            return ResponseDTO;
        }
    }
}
