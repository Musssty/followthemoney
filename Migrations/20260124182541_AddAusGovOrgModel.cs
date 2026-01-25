using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FollowTheMoney.Migrations
{
    /// <inheritdoc />
    public partial class AddAusGovOrgModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GovOrgs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    InternalDocId = table.Column<string>(type: "TEXT", nullable: true),
                    DeptName = table.Column<string>(type: "TEXT", nullable: false),
                    IsPortfolioDept = table.Column<string>(type: "TEXT", nullable: true),
                    Abbreviation = table.Column<string>(type: "TEXT", nullable: true),
                    PortfolioName = table.Column<string>(type: "TEXT", nullable: true),
                    Classification = table.Column<string>(type: "TEXT", nullable: true),
                    TypeOfBody = table.Column<string>(type: "TEXT", nullable: true),
                    GFSSectorClass = table.Column<string>(type: "TEXT", nullable: true),
                    GFSFunctionSector = table.Column<string>(type: "TEXT", nullable: true),
                    Materiality = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    EstablishedByOrUnder = table.Column<string>(type: "TEXT", nullable: true),
                    EstablishedByOrUnderMoreInfo = table.Column<string>(type: "TEXT", nullable: true),
                    PSActBody = table.Column<string>(type: "TEXT", nullable: true),
                    DateEstablished = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateDissolved = table.Column<DateTime>(type: "TEXT", nullable: true),
                    AverageStaffingLevel = table.Column<string>(type: "TEXT", nullable: true),
                    MaxBoardMembers = table.Column<string>(type: "TEXT", nullable: true),
                    HasPaidMembers = table.Column<string>(type: "TEXT", nullable: true),
                    BoardCommitteeAppointedBy = table.Column<string>(type: "TEXT", nullable: true),
                    BoardCommitteeAppointedByMoreInfo = table.Column<string>(type: "TEXT", nullable: true),
                    Auditor = table.Column<string>(type: "TEXT", nullable: true),
                    AuditoOtherInfo = table.Column<string>(type: "TEXT", nullable: true),
                    ABN = table.Column<string>(type: "TEXT", nullable: true),
                    ParentOrganisation = table.Column<string>(type: "TEXT", nullable: true),
                    ParentBoardNonBoardTitle = table.Column<string>(type: "TEXT", nullable: true),
                    HeadOfficeStreetAddress = table.Column<string>(type: "TEXT", nullable: true),
                    HeadOfficeSuburb = table.Column<string>(type: "TEXT", nullable: true),
                    HeadOfficeState = table.Column<string>(type: "TEXT", nullable: true),
                    HeadOfficePostcode = table.Column<string>(type: "TEXT", nullable: true),
                    WebsiteAddress = table.Column<string>(type: "TEXT", nullable: true),
                    MainPhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    StrategicCorporateOrganisationalPlan = table.Column<string>(type: "TEXT", nullable: true),
                    AnnualReport = table.Column<string>(type: "TEXT", nullable: true),
                    BudgetDocumentation = table.Column<string>(type: "TEXT", nullable: true),
                    TotalAppropriation = table.Column<string>(type: "TEXT", nullable: true),
                    TotalDeptExpenses = table.Column<string>(type: "TEXT", nullable: true),
                    SourceDocument = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PoliticianId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GovOrgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GovOrgs_Politicians_PoliticianId",
                        column: x => x.PoliticianId,
                        principalTable: "Politicians",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GovOrgs_PoliticianId",
                table: "GovOrgs",
                column: "PoliticianId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GovOrgs");
        }
    }
}
