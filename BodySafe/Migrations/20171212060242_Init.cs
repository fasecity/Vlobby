using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BodySafe.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beneficiaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessAddress",
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
                    table.PrimaryKey("PK_BusinessAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Firms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BENEFICIARY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiariesId = table.Column<int>(nullable: true),
                    BusinessAddressId = table.Column<int>(nullable: true),
                    FiscalEnd = table.Column<string>(nullable: true),
                    FiscalStart = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TradeName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BENEFICIARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BENEFICIARY_Beneficiaries_BeneficiariesId",
                        column: x => x.BeneficiariesId,
                        principalTable: "Beneficiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BENEFICIARY_BusinessAddress_BusinessAddressId",
                        column: x => x.BusinessAddressId,
                        principalTable: "BusinessAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registrant",
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
                    table.PrimaryKey("PK_Registrant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registrant_BusinessAddress_BusinessAddressId",
                        column: x => x.BusinessAddressId,
                        principalTable: "BusinessAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Firm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessAddressId = table.Column<int>(nullable: true),
                    BusinessType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FirmsId = table.Column<int>(nullable: true),
                    FiscalEnd = table.Column<string>(nullable: true),
                    FiscalStart = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TradeName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Firm_BusinessAddress_BusinessAddressId",
                        column: x => x.BusinessAddressId,
                        principalTable: "BusinessAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Firm_Firms_FirmsId",
                        column: x => x.FirmsId,
                        principalTable: "Firms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LobbyActivity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiariesId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_LobbyActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LobbyActivity_Beneficiaries_BeneficiariesId",
                        column: x => x.BeneficiariesId,
                        principalTable: "Beneficiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LobbyActivity_Firms_FirmsId",
                        column: x => x.FirmsId,
                        principalTable: "Firms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LobbyActivity_Registrant_RegistrantId",
                        column: x => x.RegistrantId,
                        principalTable: "Registrant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BENEFICIARY_BeneficiariesId",
                table: "BENEFICIARY",
                column: "BeneficiariesId");

            migrationBuilder.CreateIndex(
                name: "IX_BENEFICIARY_BusinessAddressId",
                table: "BENEFICIARY",
                column: "BusinessAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Firm_BusinessAddressId",
                table: "Firm",
                column: "BusinessAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Firm_FirmsId",
                table: "Firm",
                column: "FirmsId");

            migrationBuilder.CreateIndex(
                name: "IX_LobbyActivity_BeneficiariesId",
                table: "LobbyActivity",
                column: "BeneficiariesId");

            migrationBuilder.CreateIndex(
                name: "IX_LobbyActivity_FirmsId",
                table: "LobbyActivity",
                column: "FirmsId");

            migrationBuilder.CreateIndex(
                name: "IX_LobbyActivity_RegistrantId",
                table: "LobbyActivity",
                column: "RegistrantId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrant_BusinessAddressId",
                table: "Registrant",
                column: "BusinessAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BENEFICIARY");

            migrationBuilder.DropTable(
                name: "Firm");

            migrationBuilder.DropTable(
                name: "LobbyActivity");

            migrationBuilder.DropTable(
                name: "Beneficiaries");

            migrationBuilder.DropTable(
                name: "Firms");

            migrationBuilder.DropTable(
                name: "Registrant");

            migrationBuilder.DropTable(
                name: "BusinessAddress");
        }
    }
}
