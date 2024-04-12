using System.ComponentModel.DataAnnotations;

namespace ShowroomManagmentAPI.Data
{
    public class TaxRate
    {
        [Key]
        public int PkId { get; set; }
        public bool TaxType { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }
        public string EffectiveDate { get; set; }
        public string Enddate { get; set; }
    }
}
