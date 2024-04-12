using ShowroomManagmentAPI.DTOs;

namespace ShowroomManagmentAPI.Repositories
{
    public interface ITransaction
    {
        public Task<ResponseDTO> GetTransaction();
        public Task<ResponseDTO> AddTransaction(TransactionDTO transactionDTO);
        public Task<ResponseDTO> GetTransactionById(int id);
        public Task<ResponseDTO> DeleteTransaction(int id);
        public Task<ResponseDTO> UpdateTransaction(TransactionDTO transactionDTO);
    }
}
