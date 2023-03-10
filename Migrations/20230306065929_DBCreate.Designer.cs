// <auto-generated />
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
    [Migration("20230306065929_DBCreate")]
    partial class DBCreate
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
                    b.Property<int>("SityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SityID"));

                    b.Property<string>("CityCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("SityID");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Estate_Expert.Models.EstateDetailModel", b =>
                {
                    b.Property<int>("EstateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstateId"));

                    b.Property<decimal?>("BalconiesSpace")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("EstateDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstateStatusId")
                        .HasColumnType("int");

                    b.Property<int>("EstateTypeId")
                        .HasColumnType("int");

                    b.Property<decimal?>("FloorSpace")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("NumberOfBalconies")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfBathrooms")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfBedrooms")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfGarages")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfParkingSpaces")
                        .HasColumnType("int");

                    b.Property<bool?>("PetAllowed")
                        .HasColumnType("bit");

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.HasKey("EstateId");

                    b.HasIndex("EstateStatusId");

                    b.HasIndex("EstateTypeId");

                    b.HasIndex("cityId");

                    b.ToTable("EstateDetail");
                });

            modelBuilder.Entity("Estate_Expert.Models.EstateStatusModel", b =>
                {
                    b.Property<int>("EstateStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstateStatusId"));

                    b.Property<string>("EstateStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstateStatusId");

                    b.ToTable("EstateStatus");
                });

            modelBuilder.Entity("Estate_Expert.Models.EstateTypeModel", b =>
                {
                    b.Property<int>("EstateTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstateTypeId"));

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstateTypeId");

                    b.ToTable("estateTypes");
                });

            modelBuilder.Entity("Estate_Expert.Models.InChargeModel", b =>
                {
                    b.Property<int>("InChargreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InChargreId"));

                    b.Property<int>("AgentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<int>("EstateId")
                        .HasColumnType("int");

                    b.HasKey("InChargreId");

                    b.HasIndex("AgentId");

                    b.HasIndex("EstateId");

                    b.ToTable("InChargeModel");
                });

            modelBuilder.Entity("Estate_Expert.Models.SignInLogModel", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogId"));

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LogId");

                    b.HasIndex("UserId");

                    b.ToTable("signInLogs");
                });

            modelBuilder.Entity("Estate_Expert.Models.StateModel", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateId"));

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId");

                    b.ToTable("state");
                });

            modelBuilder.Entity("Estate_Expert.Models.UserDetailsModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("UserAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserDiscription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserMobileNumber")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("UserPhomeNumber")
                        .HasColumnType("int");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.HasIndex("CityId");

                    b.HasIndex("StateId");

                    b.HasIndex("UserName")
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

            modelBuilder.Entity("Estate_Expert.Models.EstateDetailModel", b =>
                {
                    b.HasOne("Estate_Expert.Models.EstateStatusModel", "Status")
                        .WithMany("estatesDetails")
                        .HasForeignKey("EstateStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estate_Expert.Models.EstateTypeModel", "estateType")
                        .WithMany("estates")
                        .HasForeignKey("EstateTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estate_Expert.Models.CityModel", "estateCity")
                        .WithMany()
                        .HasForeignKey("cityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");

                    b.Navigation("estateCity");

                    b.Navigation("estateType");
                });

            modelBuilder.Entity("Estate_Expert.Models.InChargeModel", b =>
                {
                    b.HasOne("Estate_Expert.Models.UserDetailsModel", "AgentDetails")
                        .WithMany("inchargeagent")
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estate_Expert.Models.EstateDetailModel", "EstateDetail")
                        .WithMany("inchargeestate")
                        .HasForeignKey("EstateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AgentDetails");

                    b.Navigation("EstateDetail");
                });

            modelBuilder.Entity("Estate_Expert.Models.SignInLogModel", b =>
                {
                    b.HasOne("Estate_Expert.Models.UserDetailsModel", "logDetails")
                        .WithMany("signInLogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("logDetails");
                });

            modelBuilder.Entity("Estate_Expert.Models.UserDetailsModel", b =>
                {
                    b.HasOne("Estate_Expert.Models.CityModel", "userCity")
                        .WithMany("userCityDetails")
                        .HasForeignKey("CityId");

                    b.HasOne("Estate_Expert.Models.StateModel", "userState")
                        .WithMany("userStateDetails")
                        .HasForeignKey("StateId");

                    b.Navigation("userCity");

                    b.Navigation("userState");
                });

            modelBuilder.Entity("Estate_Expert.Models.CityModel", b =>
                {
                    b.Navigation("userCityDetails");
                });

            modelBuilder.Entity("Estate_Expert.Models.EstateDetailModel", b =>
                {
                    b.Navigation("inchargeestate");
                });

            modelBuilder.Entity("Estate_Expert.Models.EstateStatusModel", b =>
                {
                    b.Navigation("estatesDetails");
                });

            modelBuilder.Entity("Estate_Expert.Models.EstateTypeModel", b =>
                {
                    b.Navigation("estates");
                });

            modelBuilder.Entity("Estate_Expert.Models.StateModel", b =>
                {
                    b.Navigation("cities");

                    b.Navigation("userStateDetails");
                });

            modelBuilder.Entity("Estate_Expert.Models.UserDetailsModel", b =>
                {
                    b.Navigation("inchargeagent");

                    b.Navigation("signInLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
