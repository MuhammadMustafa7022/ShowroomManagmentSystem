﻿using Microsoft.EntityFrameworkCore;

namespace ShowroomManagmentAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vehicle> Vehicles {  get; set; } 
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Campaign> Campaign { get; set; } 
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<CustomerSegment> CustomerSegments { get; set; }

        public DbSet<CampaignChannelMapping> CampaignChannelMappings { get; set; }
        public DbSet<CampaignCustomerSegmentMapping> CampaignCustomerSegmentMappings { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PurchaseOrdr> PurchaseOrdrs { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Defects> Defects { get; set; }
        public DbSet<VehicleCategory> VehicleCategorys { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<SalesOrder> SaleOrders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        // Nabeel working



















        // ubaid working





















        // mustafa working







        public DbSet<TaxRate> TaxRates { get; set; }
        public DbSet<TaxExemption> TaxExemptions { get; set; }
        public DbSet<TaxRule> TaxRules { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<ServiceAppointment> ServiceAppointments { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<ServiceRecord> ServiceRecords { get; set; }




















    }
}
