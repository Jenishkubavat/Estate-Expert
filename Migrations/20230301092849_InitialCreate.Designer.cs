﻿// <auto-generated />
using System;
using Estate_Expert.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Estate_Expert.Migrations
{
    [DbContext(typeof(EstateExpertDbContext))]
    [Migration("20230301092849_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Estate_Expert.Models.CityModel", b =>
                {
                    b.Property<int>("cityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cityID"));

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("cityCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cityID");

                    b.HasIndex("StateId");

                    b.ToTable("city");
                });

            modelBuilder.Entity("Estate_Expert.Models.SignInLogModel", b =>
                {
                    b.Property<int>("logId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("logId"));

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("logId");

                    b.HasIndex("userId");

                    b.ToTable("signInLogs");
                });

            modelBuilder.Entity("Estate_Expert.Models.StateModel", b =>
                {
                    b.Property<int>("stateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("stateId"));

                    b.Property<string>("stateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("stateId");

                    b.ToTable("state");
                });

            modelBuilder.Entity("Estate_Expert.Models.UserDetailsModel", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.Property<string>("conformPassword")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<int>("stateId")
                        .HasColumnType("int");

                    b.Property<string>("userAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userDiscription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userMobileNumber")
                        .HasColumnType("int");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("userPassword")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("userPhomeNumber")
                        .HasColumnType("int");

                    b.Property<string>("userType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.HasIndex("cityId");

                    b.HasIndex("stateId");

                    b.HasIndex("userName")
                        .IsUnique();

                    b.ToTable("userDetails");
                });

            modelBuilder.Entity("Estate_Expert.Models.CityModel", b =>
                {
                    b.HasOne("Estate_Expert.Models.StateModel", "state")
                        .WithMany("cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("state");
                });

            modelBuilder.Entity("Estate_Expert.Models.SignInLogModel", b =>
                {
                    b.HasOne("Estate_Expert.Models.UserDetailsModel", "logDetails")
                        .WithMany("signInLogs")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("logDetails");
                });

            modelBuilder.Entity("Estate_Expert.Models.UserDetailsModel", b =>
                {
                    b.HasOne("Estate_Expert.Models.CityModel", "userCity")
                        .WithMany("userCityDetails")
                        .HasForeignKey("cityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estate_Expert.Models.StateModel", "userState")
                        .WithMany("userStateDetails")
                        .HasForeignKey("stateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userCity");

                    b.Navigation("userState");
                });

            modelBuilder.Entity("Estate_Expert.Models.CityModel", b =>
                {
                    b.Navigation("userCityDetails");
                });

            modelBuilder.Entity("Estate_Expert.Models.StateModel", b =>
                {
                    b.Navigation("cities");

                    b.Navigation("userStateDetails");
                });

            modelBuilder.Entity("Estate_Expert.Models.UserDetailsModel", b =>
                {
                    b.Navigation("signInLogs");
                });
#pragma warning restore 612, 618
        }
    }
}