using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BodySafe.Migrations
{
    public partial class Commy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeneficiariesT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficiariesT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessAddressT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessAddressT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationsT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationsT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LobbyistBusinessAddressT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LobbyistBusinessAddressT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BENEFICIARYT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiariesTId = table.Column<int>(nullable: true),
                    BusinessAddressId = table.Column<int>(nullable: true),
                    FiscalEnd = table.Column<string>(nullable: true),
                    FiscalStart = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TradeName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BENEFICIARYT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BENEFICIARYT_BeneficiariesT_BeneficiariesTId",
                        column: x => x.BeneficiariesTId,
                        principalTable: "BeneficiariesT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BENEFICIARYT_BusinessAddressT_BusinessAddressId",
                        column: x => x.BusinessAddressId,
                        principalTable: "BusinessAddressT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FirmT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessAddressId = table.Column<int>(nullable: true),
                    BusinessType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FiscalEnd = table.Column<string>(nullable: true),
                    FiscalStart = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TradeName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FirmT_BusinessAddressT_BusinessAddressId",
                        column: x => x.BusinessAddressId,
                        principalTable: "BusinessAddressT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistrantT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessAddressId = table.Column<int>(nullable: true),
                    EffectiveDate = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleInitials = table.Column<string>(nullable: true),
                    PositionTitle = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true),
                    PreviousPublicOfficeHoldLastDate = table.Column<string>(nullable: true),
                    PreviousPublicOfficeHoldPosition = table.Column<string>(nullable: true),
                    PreviousPublicOfficeHolder = table.Column<string>(nullable: true),
                    PreviousPublicOfficePositionProgramName = table.Column<string>(nullable: true),
                    RegistrationNUmber = table.Column<string>(nullable: true),
                    RegistrationNUmberWithSoNum = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Suffix = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrantT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrantT_BusinessAddressT_BusinessAddressId",
                        column: x => x.BusinessAddressId,
                        principalTable: "BusinessAddressT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommunicationDate = table.Column<string>(nullable: true),
                    CommunicationGroupId = table.Column<string>(nullable: true),
                    CommunicationMethod = table.Column<string>(nullable: true),
                    CommunicationsTId = table.Column<int>(nullable: true),
                    LobbyistBusiness = table.Column<string>(nullable: true),
                    LobbyistBusinessAddressId = table.Column<int>(nullable: true),
                    LobbyistFirstName = table.Column<string>(nullable: true),
                    LobbyistLastName = table.Column<string>(nullable: true),
                    LobbyistMiddleInitials = table.Column<string>(nullable: true),
                    LobbyistNumber = table.Column<string>(nullable: true),
                    LobbyistPositionTitle = table.Column<string>(nullable: true),
                    LobbyistPrefix = table.Column<string>(nullable: true),
                    LobbyistSuffix = table.Column<string>(nullable: true),
                    LobbyistType = table.Column<string>(nullable: true),
                    POH_Name = table.Column<string>(nullable: true),
                    POH_Office = table.Column<string>(nullable: true),
                    POH_Position = table.Column<string>(nullable: true),
                    POH_Type = table.Column<string>(nullable: true),
                    PreviousPublicOfficeHoldLastDate = table.Column<string>(nullable: true),
                    PreviousPublicOfficeHoldPosition = table.Column<string>(nullable: true),
                    PreviousPublicOfficeHolder = table.Column<string>(nullable: true),
                    PreviousPublicOfficePositionProgramName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunicationT_CommunicationsT_CommunicationsTId",
                        column: x => x.CommunicationsTId,
                        principalTable: "CommunicationsT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommunicationT_LobbyistBusinessAddressT_LobbyistBusinessAddressId",
                        column: x => x.LobbyistBusinessAddressId,
                        principalTable: "LobbyistBusinessAddressT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FirmsT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirmId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmsT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FirmsT_FirmT_FirmId",
                        column: x => x.FirmId,
                        principalTable: "FirmT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommsLobbActivity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiariesId = table.Column<int>(nullable: true),
                    CommunicationsId = table.Column<int>(nullable: true),
                    EffectiveDate = table.Column<string>(nullable: true),
                    FirmsId = table.Column<int>(nullable: true),
                    InitialApprovalDate = table.Column<string>(nullable: true),
                    Particulars = table.Column<string>(nullable: true),
                    ProposedEndDate = table.Column<string>(nullable: true),
                    ProposedStartDate = table.Column<string>(nullable: true),
                    RegistrantId = table.Column<int>(nullable: true),
                    SMNumber = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SubjectMatter = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommsLobbActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommsLobbActivity_BeneficiariesT_BeneficiariesId",
                        column: x => x.BeneficiariesId,
                        principalTable: "BeneficiariesT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommsLobbActivity_CommunicationsT_CommunicationsId",
                        column: x => x.CommunicationsId,
                        principalTable: "CommunicationsT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommsLobbActivity_FirmsT_FirmsId",
                        column: x => x.FirmsId,
                        principalTable: "FirmsT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommsLobbActivity_RegistrantT_RegistrantId",
                        column: x => x.RegistrantId,
                        principalTable: "RegistrantT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BENEFICIARYT_BeneficiariesTId",
                table: "BENEFICIARYT",
                column: "BeneficiariesTId");

            migrationBuilder.CreateIndex(
                name: "IX_BENEFICIARYT_BusinessAddressId",
                table: "BENEFICIARYT",
                column: "BusinessAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CommsLobbActivity_BeneficiariesId",
                table: "CommsLobbActivity",
                column: "BeneficiariesId");

            migrationBuilder.CreateIndex(
                name: "IX_CommsLobbActivity_CommunicationsId",
                table: "CommsLobbActivity",
                column: "CommunicationsId");

            migrationBuilder.CreateIndex(
                name: "IX_CommsLobbActivity_FirmsId",
                table: "CommsLobbActivity",
                column: "FirmsId");

            migrationBuilder.CreateIndex(
                name: "IX_CommsLobbActivity_RegistrantId",
                table: "CommsLobbActivity",
                column: "RegistrantId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunicationT_CommunicationsTId",
                table: "CommunicationT",
                column: "CommunicationsTId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunicationT_LobbyistBusinessAddressId",
                table: "CommunicationT",
                column: "LobbyistBusinessAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_FirmsT_FirmId",
                table: "FirmsT",
                column: "FirmId");

            migrationBuilder.CreateIndex(
                name: "IX_FirmT_BusinessAddressId",
                table: "FirmT",
                column: "BusinessAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrantT_BusinessAddressId",
                table: "RegistrantT",
                column: "BusinessAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BENEFICIARYT");

            migrationBuilder.DropTable(
                name: "CommsLobbActivity");

            migrationBuilder.DropTable(
                name: "CommunicationT");

            migrationBuilder.DropTable(
                name: "BeneficiariesT");

            migrationBuilder.DropTable(
                name: "FirmsT");

            migrationBuilder.DropTable(
                name: "RegistrantT");

            migrationBuilder.DropTable(
                name: "CommunicationsT");

            migrationBuilder.DropTable(
                name: "LobbyistBusinessAddressT");

            migrationBuilder.DropTable(
                name: "FirmT");

            migrationBuilder.DropTable(
                name: "BusinessAddressT");
        }
    }
}
