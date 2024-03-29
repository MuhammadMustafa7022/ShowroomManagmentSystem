﻿// <auto-generated />
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
