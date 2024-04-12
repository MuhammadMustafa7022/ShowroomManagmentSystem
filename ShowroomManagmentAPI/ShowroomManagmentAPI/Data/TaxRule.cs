using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.Data
{
    public class TaxRule
    {
        [Key]
        public int PkId { get; set; }
        public string Description { get; set; }
        public string ApplicableProduct { get; set; }
        [ForeignKey("TaxRate")]
        public int FKTaxRateId { get; set; }
        [ForeignKey("TaxExemption")]
        public int FKTaxExemption { get; set; }
        public TaxRate TaxRate { get; set; }
        public TaxExemption TaxExemption { get; set; }

    }
}
