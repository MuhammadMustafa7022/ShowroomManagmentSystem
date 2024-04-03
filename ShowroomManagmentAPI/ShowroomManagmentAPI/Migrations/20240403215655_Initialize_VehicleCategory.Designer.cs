﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShowroomManagmentAPI.Data;

#nullable disable

namespace ShowroomManagmentAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240403215655_Initialize_VehicleCategory")]
    partial class Initialize_VehicleCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
#pragma warning restore 612, 618
        }
    }
}
