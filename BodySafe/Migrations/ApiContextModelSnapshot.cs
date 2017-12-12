﻿// <auto-generated />
using BodySafe;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BodySafe.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ViewModels.LobbyCat.Beneficiaries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Beneficiaries");
                });

            modelBuilder.Entity("ViewModels.LobbyCat.BENEFICIARY", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BeneficiariesId");

                    b.Property<int?>("BusinessAddressId");

                    b.Property<string>("FiscalEnd");

                    b.Property<string>("FiscalStart");

                    b.Property<string>("Name");

                    b.Property<string>("TradeName");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("BeneficiariesId");

                    b.HasIndex("BusinessAddressId");

                    b.ToTable("BENEFICIARY");
                });

            modelBuilder.Entity("ViewModels.LobbyCat.BusinessAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Phone");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.HasKey("Id");

                    b.ToTable("BusinessAddress");
                });

            modelBuilder.Entity("ViewModels.LobbyCat.Firm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BusinessAddressId");

                    b.Property<string>("BusinessType");

                    b.Property<string>("Description");

                    b.Property<int?>("FirmsId");

                    b.Property<string>("FiscalEnd");

                    b.Property<string>("FiscalStart");

                    b.Property<string>("Name");

                    b.Property<string>("TradeName");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("BusinessAddressId");

                    b.HasIndex("FirmsId");

                    b.ToTable("Firm");
                });

            modelBuilder.Entity("ViewModels.LobbyCat.Firms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Firms");
                });

            modelBuilder.Entity("ViewModels.LobbyCat.Registrant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BusinessAddressId");

                    b.Property<string>("EffectiveDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleInitials");

                    b.Property<string>("PositionTitle");

                    b.Property<string>("Prefix");

                    b.Property<string>("PreviousPublicOfficeHoldLastDate");

                    b.Property<string>("PreviousPublicOfficeHoldPosition");

                    b.Property<string>("PreviousPublicOfficeHolder");

                    b.Property<string>("PreviousPublicOfficePositionProgramName");

                    b.Property<string>("RegistrationNUmber");

                    b.Property<string>("RegistrationNUmberWithSoNum");

                    b.Property<string>("Status");

                    b.Property<string>("Suffix");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("BusinessAddressId");

                    b.ToTable("Registrant");
                });

            modelBuilder.Entity("ViewModels.LobbyCat.ROW", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BeneficiariesId");

                    b.Property<string>("EffectiveDate");

                    b.Property<int?>("FirmsId");

                    b.Property<string>("InitialApprovalDate");

                    b.Property<string>("Particulars");

                    b.Property<string>("ProposedEndDate");

                    b.Property<string>("ProposedStartDate");

                    b.Property<int?>("RegistrantId");

                    b.Property<string>("SMNumber");

                    b.Property<string>("Status");

                    b.Property<string>("SubjectMatter");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("BeneficiariesId");

                    b.HasIndex("FirmsId");

                    b.HasIndex("RegistrantId");

                    b.ToTable("LobbyActivity");
                });

            modelBuilder.Entity("ViewModels.LobbyCat.BENEFICIARY", b =>
                {
                    b.HasOne("ViewModels.LobbyCat.Beneficiaries")
                        .WithMany("BENEFICIARY")
                        .HasForeignKey("BeneficiariesId");

                    b.HasOne("ViewModels.LobbyCat.BusinessAddress", "BusinessAddress")
                        .WithMany()
                        .HasForeignKey("BusinessAddressId");
                });

            modelBuilder.Entity("ViewModels.LobbyCat.Firm", b =>
                {
                    b.HasOne("ViewModels.LobbyCat.BusinessAddress", "BusinessAddress")
                        .WithMany()
                        .HasForeignKey("BusinessAddressId");

                    b.HasOne("ViewModels.LobbyCat.Firms")
                        .WithMany("Firm")
                        .HasForeignKey("FirmsId");
                });

            modelBuilder.Entity("ViewModels.LobbyCat.Registrant", b =>
                {
                    b.HasOne("ViewModels.LobbyCat.BusinessAddress", "BusinessAddress")
                        .WithMany()
                        .HasForeignKey("BusinessAddressId");
                });

            modelBuilder.Entity("ViewModels.LobbyCat.ROW", b =>
                {
                    b.HasOne("ViewModels.LobbyCat.Beneficiaries", "Beneficiaries")
                        .WithMany()
                        .HasForeignKey("BeneficiariesId");

                    b.HasOne("ViewModels.LobbyCat.Firms", "Firms")
                        .WithMany()
                        .HasForeignKey("FirmsId");

                    b.HasOne("ViewModels.LobbyCat.Registrant", "Registrant")
                        .WithMany()
                        .HasForeignKey("RegistrantId");
                });
#pragma warning restore 612, 618
        }
    }
}