using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.Data
{
    public class User
    {
        public int PkId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        [ForeignKey("Role")]
        public int FKRoleId { get; set; }
        public Role Role { get; set; }
    }
}
