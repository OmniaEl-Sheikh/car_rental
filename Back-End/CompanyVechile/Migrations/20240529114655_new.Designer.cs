﻿// <auto-generated />
using System;
using CompanyVechile.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompanyVechile.Migrations
{
    [DbContext(typeof(CompanyDBContext))]
    [Migration("20240529114655_new")]
    partial class @new
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Arabic_CI_AS")
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CompanyVechile.Models.Branches", b =>
                {
                    b.Property<int>("Branch_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Branch_ID"));

                    b.Property<string>("Branch_Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Branch_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Branch_ID");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("CompanyVechile.Models.EmployeePhone", b =>
                {
                    b.Property<string>("Employee_ID")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Employee_PhoneNumber")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Employee_ID", "Employee_PhoneNumber");

                    b.ToTable("EmployeePhones");
                });

            modelBuilder.Entity("CompanyVechile.Models.Employees", b =>
                {
                    b.Property<string>("Employee_ID")
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("Branch_ID")
                        .HasColumnType("int");

                    b.Property<string>("Employee_Birthday")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Employee_BuildingNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Employee_City")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Employee_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Employee_Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Employee_Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Employee_Street_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Employee_ID");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CompanyVechile.Models.EmployeesVehicle", b =>
                {
                    b.Property<string>("VehiclePlateNumber")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("VehiclePlateNumber", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeesVehicles");
                });

            modelBuilder.Entity("CompanyVechile.Models.Vehicle", b =>
                {
                    b.Property<string>("Vehicle_PlateNumber")
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("Branch_ID")
                        .HasColumnType("int");

                    b.Property<string>("License_ExpirationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("License_Registeration")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("License_SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Vehicle_BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Vehicle_ChassisNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Vehicle_Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Vehicle_Insurance")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Vehicle_LastAccident_Date")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Vehicle_LastRepair_Date")
                        .HasColumnType("nvarchar(40)");

                    b.Property<float?>("Vehicle_LastRepair_Price")
                        .HasColumnType("real");

                    b.Property<int>("Vehicle_ManufactureYear")
                        .HasColumnType("int");

                    b.Property<int?>("Vehicle_Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Vehicle_Owner")
                        .HasColumnType("nvarchar(40)");

                    b.Property<float?>("Vehicle_Price")
                        .HasColumnType("real");

                    b.Property<string>("Vehicle_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Vehicle_PlateNumber");

                    b.HasIndex("Branch_ID");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("CompanyVechile.Models.applicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CompanyVechile.Models.EmployeePhone", b =>
                {
                    b.HasOne("CompanyVechile.Models.Employees", "Employees")
                        .WithMany("EmployeePhones")
                        .HasForeignKey("Employee_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CompanyVechile.Models.Employees", b =>
                {
                    b.HasOne("CompanyVechile.Models.applicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CompanyVechile.Models.EmployeesVehicle", b =>
                {
                    b.HasOne("CompanyVechile.Models.Employees", "Employee")
                        .WithMany("EmployeesVehicles")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyVechile.Models.Vehicle", "Vehicle")
                        .WithMany("EmployeesVehicles")
                        .HasForeignKey("VehiclePlateNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("CompanyVechile.Models.Vehicle", b =>
                {
                    b.HasOne("CompanyVechile.Models.Branches", "Branch")
                        .WithMany("Vehicles")
                        .HasForeignKey("Branch_ID");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CompanyVechile.Models.applicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CompanyVechile.Models.applicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyVechile.Models.applicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CompanyVechile.Models.applicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyVechile.Models.Branches", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("CompanyVechile.Models.Employees", b =>
                {
                    b.Navigation("EmployeePhones");

                    b.Navigation("EmployeesVehicles");
                });

            modelBuilder.Entity("CompanyVechile.Models.Vehicle", b =>
                {
                    b.Navigation("EmployeesVehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
