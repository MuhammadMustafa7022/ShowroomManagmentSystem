﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowroomManagmentAPI.Data
{
    public class Vehicle
    {
        [Key]
        public int VehiicleId { get; set; }
        public string ModelName { get; set; }
        public string Manufacturer {  get; set; }
        public string Year { get; set;}
        public string Color { get; set; }
        public string Mileage { get; set; }
        [MaxLength(17)]
        public string VIN {  get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Features { get; set; }
        public string WheelCount { get; set; }
        public string EngineType { get; set; }
        public string ProfileImagePath { get; set; }
        [ForeignKey("VehicleCategory")]
        public int FKCategoryId { get; set; }
        public VehicleCategory VehicleCategory { get; set; }
    }
}
