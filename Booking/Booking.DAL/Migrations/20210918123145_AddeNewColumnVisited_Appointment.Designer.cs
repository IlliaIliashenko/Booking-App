﻿// <auto-generated />
using System;
using Booking.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Booking.DAL.Migrations
{
    [DbContext(typeof(BookingContext))]
    [Migration("20210918123145_AddeNewColumnVisited_Appointment")]
    partial class AddeNewColumnVisited_Appointment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Booking.DAL.Models.Authentication.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "9a688327-85e3-48e8-b1d9-7881884e5cb8",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "eef1dc51-2872-4315-96d5-2deb5d7c0cbc",
                            Name = "UserWithNoPermission",
                            NormalizedName = "USERWITHNOPERMISSION"
                        });
                });

            modelBuilder.Entity("Booking.DAL.Models.Authentication.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Booking.DAL.Models.Booking.ApartmentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Apartments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Аренда VIP 2-ух комнатной квартиры в Новострое",
                            Price = 9500m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Аренда 3-x комнатной квартиры в центре",
                            Price = 15500m
                        });
                });

            modelBuilder.Entity("Booking.DAL.Models.Booking.ApartmentPhotoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("ApartmentPhotos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApartmentId = 1,
                            Path = "ApartmentPhotos/apartment11.jpg"
                        },
                        new
                        {
                            Id = 2,
                            ApartmentId = 1,
                            Path = "ApartmentPhotos/apartment12.jpg"
                        },
                        new
                        {
                            Id = 3,
                            ApartmentId = 1,
                            Path = "ApartmentPhotos/apartment13.jpg"
                        });
                });

            modelBuilder.Entity("Booking.DAL.Models.Booking.AppointmentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Visited")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Booking.DAL.Models.Booking.DetailsEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValueType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DetailsEntities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Address",
                            ValueType = "System.String"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Floor",
                            ValueType = "System.Int32"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rooms",
                            ValueType = "System.Int32"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Size",
                            ValueType = "System.Int32"
                        });
                });

            modelBuilder.Entity("Booking.DAL.Models.Booking.DetailsToApartmentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApartmentEntityId")
                        .HasColumnType("int");

                    b.Property<int>("DetailsEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentEntityId");

                    b.HasIndex("DetailsEntityId");

                    b.ToTable("ApartmentDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApartmentEntityId = 1,
                            DetailsEntityId = 1,
                            Value = "Цілиноградська вулиця, 48-в, Харків, Харківська область, 61202"
                        },
                        new
                        {
                            Id = 2,
                            ApartmentEntityId = 1,
                            DetailsEntityId = 2,
                            Value = "2"
                        },
                        new
                        {
                            Id = 3,
                            ApartmentEntityId = 1,
                            DetailsEntityId = 3,
                            Value = "2"
                        },
                        new
                        {
                            Id = 4,
                            ApartmentEntityId = 1,
                            DetailsEntityId = 4,
                            Value = "87"
                        },
                        new
                        {
                            Id = 5,
                            ApartmentEntityId = 2,
                            DetailsEntityId = 1,
                            Value = "Сумська вулиця, 18-а, Харків, Харківська область, 61106"
                        },
                        new
                        {
                            Id = 6,
                            ApartmentEntityId = 2,
                            DetailsEntityId = 2,
                            Value = "3"
                        },
                        new
                        {
                            Id = 7,
                            ApartmentEntityId = 2,
                            DetailsEntityId = 3,
                            Value = "3"
                        },
                        new
                        {
                            Id = 8,
                            ApartmentEntityId = 2,
                            DetailsEntityId = 4,
                            Value = "105"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "Booking.Permission",
                            ClaimValue = "users.view",
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Booking.DAL.Models.Booking.ApartmentPhotoEntity", b =>
                {
                    b.HasOne("Booking.DAL.Models.Booking.ApartmentEntity", "Apartment")
                        .WithMany("ApartmentPhotos")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("Booking.DAL.Models.Booking.AppointmentEntity", b =>
                {
                    b.HasOne("Booking.DAL.Models.Booking.ApartmentEntity", "Apartment")
                        .WithMany("AppointmentEntities")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("Booking.DAL.Models.Booking.DetailsToApartmentEntity", b =>
                {
                    b.HasOne("Booking.DAL.Models.Booking.ApartmentEntity", "ApartmentEntity")
                        .WithMany("DetailsToApartmentEntities")
                        .HasForeignKey("ApartmentEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Booking.DAL.Models.Booking.DetailsEntity", "DetailsEntity")
                        .WithMany("DetailsToApartmentEntities")
                        .HasForeignKey("DetailsEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApartmentEntity");

                    b.Navigation("DetailsEntity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Booking.DAL.Models.Authentication.RoleEntity", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Booking.DAL.Models.Authentication.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Booking.DAL.Models.Authentication.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Booking.DAL.Models.Authentication.RoleEntity", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Booking.DAL.Models.Authentication.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Booking.DAL.Models.Authentication.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Booking.DAL.Models.Booking.ApartmentEntity", b =>
                {
                    b.Navigation("ApartmentPhotos");

                    b.Navigation("AppointmentEntities");

                    b.Navigation("DetailsToApartmentEntities");
                });

            modelBuilder.Entity("Booking.DAL.Models.Booking.DetailsEntity", b =>
                {
                    b.Navigation("DetailsToApartmentEntities");
                });
#pragma warning restore 612, 618
        }
    }
}