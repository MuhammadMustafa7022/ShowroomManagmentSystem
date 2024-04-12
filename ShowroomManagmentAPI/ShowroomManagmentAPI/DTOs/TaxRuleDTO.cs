using ShowroomManagmentAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.DTOs
{
    public class TaxRuleDTO
    {
        public int PkId { get; set; }
        public string Description { get; set; }
        public string ApplicableProduct { get; set; }
        public int FKTaxRateId { get; set; }
        public int FKTaxExemption { get; set; }
    }
}