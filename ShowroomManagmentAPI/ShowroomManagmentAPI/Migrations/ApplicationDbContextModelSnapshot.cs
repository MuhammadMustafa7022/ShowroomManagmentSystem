﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShowroomManagmentAPI.Data;

#nullable disable

namespace ShowroomManagmentAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Attendance", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"), 1L, 1);

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FKEmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("TimeIn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeOut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkId");

                    b.HasIndex("FKEmployeeId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Campaign", b =>
                {
                    b.Property<int>("CampaignID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampaignID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CampaignID");

                    b.ToTable("Campaign");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.CampaignChannelMapping", b =>
                {
                    b.Property<int>("MappingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MappingID"), 1L, 1);

                    b.Property<int>("FKCampaignID")
                        .HasColumnType("int");

                    b.Property<int>("FKChannelID")
                        .HasColumnType("int");

                    b.HasKey("MappingID");

                    b.HasIndex("FKCampaignID");

                    b.HasIndex("FKChannelID");

                    b.ToTable("CampaignChannelMappings");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.CampaignCustomerSegmentMapping", b =>
                {
                    b.Property<int>("MappingCustomerSegmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MappingCustomerSegmentID"), 1L, 1);

                    b.Property<int>("FKCampaignID")
                        .HasColumnType("int");

                    b.Property<int>("FKSegmentID")
                        .HasColumnType("int");

                    b.HasKey("MappingCustomerSegmentID");

                    b.HasIndex("FKCampaignID");

                    b.HasIndex("FKSegmentID");

                    b.ToTable("CampaignCustomerSegmentMappings");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryDiscription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Channel", b =>
                {
                    b.Property<int>("ChannelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChannelID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ChannelID");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.CustomerSegment", b =>
                {
                    b.Property<int>("SegmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SegmentID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SegmentID");

                    b.ToTable("CustomerSegments");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Defects", b =>
                {
                    b.Property<int>("DefectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DefectId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FKInspectionId")
                        .HasColumnType("int");

                    b.Property<string>("Severity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("DefectId");

                    b.HasIndex("FKInspectionId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Defects");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Department", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Employee", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cnic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FKDepartment")
                        .HasColumnType("int");

                    b.Property<int>("FKRole")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkId");

                    b.HasIndex("FKDepartment");

                    b.HasIndex("FKRole");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Inspection", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"), 1L, 1);

                    b.Property<int>("FKInspectorId")
                        .HasColumnType("int");

                    b.Property<string>("InspectionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Result")
                        .HasColumnType("bit");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("PkId");

                    b.HasIndex("FKInspectorId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Inspector", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"), 1L, 1);

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FkDepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkId");

                    b.HasIndex("FkDepartmentId");

                    b.ToTable("Inspectors");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"), 1L, 1);

                    b.Property<int>("FkSaleOrderID")
                        .HasColumnType("int");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("FkSaleOrderID");

                    b.HasIndex("VehicleId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FKCategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("FKCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Promotion", b =>
                {
                    b.Property<int>("PromotionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PromotionID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PromotionID");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.PurchaseOrderItem", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"), 1L, 1);

                    b.Property<int>("FKPurchaseOrderId")
                        .HasColumnType("int");

                    b.Property<int>("FkProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.HasKey("ItemId");

                    b.HasIndex("FKPurchaseOrderId");

                    b.HasIndex("FkProductId");

                    b.ToTable("PurchaseOrderItems");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.PurchaseOrdr", b =>
                {
                    b.Property<int>("PurchaseOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseOrderId"), 1L, 1);

                    b.Property<int>("FKSupplierId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PurchaseOrderId");

                    b.HasIndex("FKSupplierId");

                    b.ToTable("PurchaseOrdrs");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Role", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RollName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("permissions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.SalesOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int>("FkCustomerID")
                        .HasColumnType("int");

                    b.Property<int>("FkEmpolyeeID")
                        .HasColumnType("int");

                    b.Property<string>("OrderDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalAmount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.HasIndex("FkCustomerID");

                    b.HasIndex("FkEmpolyeeID");

                    b.ToTable("SaleOrders");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.TaxExemption", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"), 1L, 1);

                    b.Property<string>("ApplicableProduct")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EffectiveDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ExemptionType")
                        .HasColumnType("bit");

                    b.HasKey("PkId");

                    b.ToTable("TaxExemptions");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.TaxRate", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EffectiveDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enddate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TaxType")
                        .HasColumnType("bit");

                    b.HasKey("PkId");

                    b.ToTable("TaxRates");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.TaxRule", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"), 1L, 1);

                    b.Property<string>("ApplicableProduct")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FKTaxExemption")
                        .HasColumnType("int");

                    b.Property<int>("FKTaxRateId")
                        .HasColumnType("int");

                    b.HasKey("PkId");

                    b.HasIndex("FKTaxExemption");

                    b.HasIndex("FKTaxRateId");

                    b.ToTable("TaxRules");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Vehicle", b =>
                {
                    b.Property<int>("VehiicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehiicleId"), 1L, 1);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FKCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Features")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mileage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.Property<string>("WheelCount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehiicleId");

                    b.HasIndex("FKCategoryId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.VehicleCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("VehicleCategorys");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Attendance", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("FKEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.CampaignChannelMapping", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.Campaign", "Campaign")
                        .WithMany()
                        .HasForeignKey("FKCampaignID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowroomManagmentAPI.Data.Channel", "Channel")
                        .WithMany()
                        .HasForeignKey("FKChannelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");

                    b.Navigation("Channel");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.CampaignCustomerSegmentMapping", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.Campaign", "Campaign")
                        .WithMany()
                        .HasForeignKey("FKCampaignID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowroomManagmentAPI.Data.CustomerSegment", "CustomerSegment")
                        .WithMany()
                        .HasForeignKey("FKSegmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");

                    b.Navigation("CustomerSegment");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Defects", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.Inspection", "Inspection")
                        .WithMany()
                        .HasForeignKey("FKInspectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowroomManagmentAPI.Data.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inspection");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Employee", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.Department", "Department")
                        .WithMany()
                        .HasForeignKey("FKDepartment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowroomManagmentAPI.Data.Role", "Role")
                        .WithMany()
                        .HasForeignKey("FKRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Inspection", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.Inspector", "Inspector")
                        .WithMany()
                        .HasForeignKey("FKInspectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowroomManagmentAPI.Data.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inspector");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Inspector", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.Department", "Department")
                        .WithMany()
                        .HasForeignKey("FkDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.OrderItem", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.SalesOrder", "SalesOrder")
                        .WithMany()
                        .HasForeignKey("FkSaleOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowroomManagmentAPI.Data.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SalesOrder");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Product", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("FKCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.PurchaseOrderItem", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.PurchaseOrdr", "PurchaseOrdr")
                        .WithMany()
                        .HasForeignKey("FKPurchaseOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowroomManagmentAPI.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("FkProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("PurchaseOrdr");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.PurchaseOrdr", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("FKSupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.SalesOrder", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("FkCustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowroomManagmentAPI.Data.Employee", "Empolyee")
                        .WithMany()
                        .HasForeignKey("FkEmpolyeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Empolyee");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.TaxRule", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.TaxExemption", "TaxExemption")
                        .WithMany()
                        .HasForeignKey("FKTaxExemption")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowroomManagmentAPI.Data.TaxRate", "TaxRate")
                        .WithMany()
                        .HasForeignKey("FKTaxRateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaxExemption");

                    b.Navigation("TaxRate");
                });

            modelBuilder.Entity("ShowroomManagmentAPI.Data.Vehicle", b =>
                {
                    b.HasOne("ShowroomManagmentAPI.Data.VehicleCategory", "VehicleCategory")
                        .WithMany()
                        .HasForeignKey("FKCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
