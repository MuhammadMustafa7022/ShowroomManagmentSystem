﻿namespace ShowroomManagmentAPI.DTOs
{
    public class TaxRateDTO
    {
        public int PkId { get; set; }
        public bool TaxType { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }
        public string EffectiveDate { get; set; }
        public string EndDate { get; set; }
    }
}
