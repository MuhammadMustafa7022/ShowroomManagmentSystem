using System.ComponentModel.DataAnnotations;

namespace ShowroomManagmentAPI.Data
{
    public class TaxExemption
    {
        [Key]
        public int PkId { get; set; }
        public bool ExemptionType { get; set; }
        public string Description { get; set; }
        public string ApplicableProduct { get; set; }
        public string EffectiveDate { get; set; }
        public string EndDate { get; set; }
    }
}
