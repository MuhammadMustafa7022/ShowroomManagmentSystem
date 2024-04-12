using ShowroomManagmentAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.DTOs
{
    public class UserDTO
    {
        public int PkId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int FKRoleId { get; set; }
    }
}
