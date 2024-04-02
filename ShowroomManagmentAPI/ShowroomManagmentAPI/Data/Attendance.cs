using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.Data
{
    public class Attendance
    {
        [Key]
        public int PkId { get; set; }
        public string Date { get; set; }
        public string TimeIn { get; set;}
        public string TimeOut { get; set; }
        [ForeignKey("Employee")]
        public int FKEmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
