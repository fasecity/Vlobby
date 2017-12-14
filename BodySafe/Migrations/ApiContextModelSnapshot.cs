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

            modelBuilder.Entity("CommsModel.BeneficiariesT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("BeneficiariesT");
                });

            modelBuilder.Entity("CommsModel.BENEFICIARYT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BeneficiariesTId");

                    b.Property<int?>("BusinessAddressId");

                    b.Property<string>("FiscalEnd");

                    b.Property<string>("FiscalStart");

                    b.Property<string>("Name");

                    b.Property<string>("TradeName");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("BeneficiariesTId");

                    b.HasIndex("BusinessAddressId");

                    b.ToTable("BENEFICIARYT");
                });

            modelBuilder.Entity("CommsModel.BusinessAddressT", b =>
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

                    b.ToTable("BusinessAddressT");
                });

            modelBuilder.Entity("CommsModel.COMMSLOBBROW", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BeneficiariesId");

                    b.Property<int?>("CommunicationsId");

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

                    b.HasIndex("CommunicationsId");

                    b.HasIndex("FirmsId");

                    b.HasIndex("RegistrantId");

                    b.ToTable("CommsLobbActivity");
                });

            modelBuilder.Entity("CommsModel.CommunicationsT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("CommunicationsT");
                });

            modelBuilder.Entity("CommsModel.CommunicationT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommunicationDate");

                    b.Property<string>("CommunicationGroupId");

                    b.Property<string>("CommunicationMethod");

                    b.Property<int?>("CommunicationsTId");

                    b.Property<string>("LobbyistBusiness");

                    b.Property<int?>("LobbyistBusinessAddressId");

                    b.Property<string>("LobbyistFirstName");

                    b.Property<string>("LobbyistLastName");

                    b.Property<string>("LobbyistMiddleInitials");

                    b.Property<string>("LobbyistNumber");

                    b.Property<string>("LobbyistPositionTitle");

                    b.Property<string>("LobbyistPrefix");

                    b.Property<string>("LobbyistSuffix");

                    b.Property<string>("LobbyistType");

                    b.Property<string>("POH_Name");

                    b.Property<string>("POH_Office");

                    b.Property<string>("POH_Position");

                    b.Property<string>("POH_Type");

                    b.Property<string>("PreviousPublicOfficeHoldLastDate");

                    b.Property<string>("PreviousPublicOfficeHoldPosition");

                    b.Property<string>("PreviousPublicOfficeHolder");

                    b.Property<string>("PreviousPublicOfficePositionProgramName");

                    b.HasKey("Id");

                    b.HasIndex("CommunicationsTId");

                    b.HasIndex("LobbyistBusinessAddressId");

                    b.ToTable("CommunicationT");
                });

            modelBuilder.Entity("CommsModel.FirmsT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FirmId");

                    b.HasKey("Id");

                    b.HasIndex("FirmId");

                    b.ToTable("FirmsT");
                });

            modelBuilder.Entity("CommsModel.FirmT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BusinessAddressId");

                    b.Property<string>("BusinessType");

                    b.Property<string>("Description");

                    b.Property<string>("FiscalEnd");

                    b.Property<string>("FiscalStart");

                    b.Property<string>("Name");

                    b.Property<string>("TradeName");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("BusinessAddressId");

                    b.ToTable("FirmT");
                });

            modelBuilder.Entity("CommsModel.LobbyistBusinessAddressT", b =>
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

                    b.ToTable("LobbyistBusinessAddressT");
                });

            modelBuilder.Entity("CommsModel.RegistrantT", b =>
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

                    b.ToTable("RegistrantT");
                });

            modelBuilder.Entity("CommsModel.BENEFICIARYT", b =>
                {
                    b.HasOne("CommsModel.BeneficiariesT")
                        .WithMany("BENEFICIARY")
                        .HasForeignKey("BeneficiariesTId");

                    b.HasOne("CommsModel.BusinessAddressT", "BusinessAddress")
                        .WithMany()
                        .HasForeignKey("BusinessAddressId");
                });

            modelBuilder.Entity("CommsModel.COMMSLOBBROW", b =>
                {
                    b.HasOne("CommsModel.BeneficiariesT", "Beneficiaries")
                        .WithMany()
                        .HasForeignKey("BeneficiariesId");

                    b.HasOne("CommsModel.CommunicationsT", "Communications")
                        .WithMany()
                        .HasForeignKey("CommunicationsId");

                    b.HasOne("CommsModel.FirmsT", "Firms")
                        .WithMany()
                        .HasForeignKey("FirmsId");

                    b.HasOne("CommsModel.RegistrantT", "Registrant")
                        .WithMany()
                        .HasForeignKey("RegistrantId");
                });

            modelBuilder.Entity("CommsModel.CommunicationT", b =>
                {
                    b.HasOne("CommsModel.CommunicationsT")
                        .WithMany("Communication")
                        .HasForeignKey("CommunicationsTId");

                    b.HasOne("CommsModel.LobbyistBusinessAddressT", "LobbyistBusinessAddress")
                        .WithMany()
                        .HasForeignKey("LobbyistBusinessAddressId");
                });

            modelBuilder.Entity("CommsModel.FirmsT", b =>
                {
                    b.HasOne("CommsModel.FirmT", "Firm")
                        .WithMany()
                        .HasForeignKey("FirmId");
                });

            modelBuilder.Entity("CommsModel.FirmT", b =>
                {
                    b.HasOne("CommsModel.BusinessAddressT", "BusinessAddress")
                        .WithMany()
                        .HasForeignKey("BusinessAddressId");
                });

            modelBuilder.Entity("CommsModel.RegistrantT", b =>
                {
                    b.HasOne("CommsModel.BusinessAddressT", "BusinessAddress")
                        .WithMany()
                        .HasForeignKey("BusinessAddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
