using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FollowTheMoney.Migrations
{
    /// <inheritdoc />
    public partial class fixmodelsagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Electorates_PoliticalParties_PoliticalPartyId",
                table: "Electorates");

            migrationBuilder.DropForeignKey(
                name: "FK_PoliticalParties_Electorates_ElectorateId",
                table: "PoliticalParties");

            migrationBuilder.DropForeignKey(
                name: "FK_Politicians_Electorates_ElectorateId",
                table: "Politicians");

            migrationBuilder.DropForeignKey(
                name: "FK_Politicians_PoliticalParties_PoliticalPartyId",
                table: "Politicians");

            migrationBuilder.DropIndex(
                name: "IX_Politicians_PoliticalPartyId",
                table: "Politicians");

            migrationBuilder.DropIndex(
                name: "IX_PoliticalParties_ElectorateId",
                table: "PoliticalParties");

            migrationBuilder.DropIndex(
                name: "IX_Electorates_PoliticalPartyId",
                table: "Electorates");

            migrationBuilder.DropColumn(
                name: "PoliticalPartyId",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "ElectorateId",
                table: "PoliticalParties");

            migrationBuilder.DropColumn(
                name: "PoliticalPartyId",
                table: "Electorates");

            migrationBuilder.AlterColumn<Guid>(
                name: "ElectorateId",
                table: "Politicians",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Committees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CommitteeId = table.Column<string>(type: "TEXT", nullable: true),
                    CommitteeName = table.Column<string>(type: "TEXT", nullable: false),
                    CommitteeChamber = table.Column<string>(type: "TEXT", nullable: true),
                    CommitteeType = table.Column<string>(type: "TEXT", nullable: true),
                    ServiceStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ServiceEnd = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CurrentMembers = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalMembers = table.Column<int>(type: "INTEGER", nullable: true),
                    SourceDocument = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Committees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PoliticalPartyMemberships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    MembershipStartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MembershipEndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RoleInParty = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PoliticianId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PoliticalPartyId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoliticalPartyMemberships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoliticalPartyMemberships_PoliticalParties_PoliticalPartyId",
                        column: x => x.PoliticalPartyId,
                        principalTable: "PoliticalParties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PoliticalPartyMemberships_Politicians_PoliticianId",
                        column: x => x.PoliticianId,
                        principalTable: "Politicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommitteeMemberships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    MembershipStartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MembershipEndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RoleInCommittee = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PoliticianId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CommitteeId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommitteeMemberships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommitteeMemberships_Committees_CommitteeId",
                        column: x => x.CommitteeId,
                        principalTable: "Committees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommitteeMemberships_Politicians_PoliticianId",
                        column: x => x.PoliticianId,
                        principalTable: "Politicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommitteeMemberships_CommitteeId",
                table: "CommitteeMemberships",
                column: "CommitteeId");

            migrationBuilder.CreateIndex(
                name: "IX_CommitteeMemberships_PoliticianId",
                table: "CommitteeMemberships",
                column: "PoliticianId");

            migrationBuilder.CreateIndex(
                name: "IX_PoliticalPartyMemberships_PoliticalPartyId",
                table: "PoliticalPartyMemberships",
                column: "PoliticalPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PoliticalPartyMemberships_PoliticianId",
                table: "PoliticalPartyMemberships",
                column: "PoliticianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Politicians_Electorates_ElectorateId",
                table: "Politicians",
                column: "ElectorateId",
                principalTable: "Electorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Politicians_Electorates_ElectorateId",
                table: "Politicians");

            migrationBuilder.DropTable(
                name: "CommitteeMemberships");

            migrationBuilder.DropTable(
                name: "PoliticalPartyMemberships");

            migrationBuilder.DropTable(
                name: "Committees");

            migrationBuilder.AlterColumn<Guid>(
                name: "ElectorateId",
                table: "Politicians",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PoliticalPartyId",
                table: "Politicians",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ElectorateId",
                table: "PoliticalParties",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PoliticalPartyId",
                table: "Electorates",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Politicians_PoliticalPartyId",
                table: "Politicians",
                column: "PoliticalPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PoliticalParties_ElectorateId",
                table: "PoliticalParties",
                column: "ElectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Electorates_PoliticalPartyId",
                table: "Electorates",
                column: "PoliticalPartyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Electorates_PoliticalParties_PoliticalPartyId",
                table: "Electorates",
                column: "PoliticalPartyId",
                principalTable: "PoliticalParties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PoliticalParties_Electorates_ElectorateId",
                table: "PoliticalParties",
                column: "ElectorateId",
                principalTable: "Electorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Politicians_Electorates_ElectorateId",
                table: "Politicians",
                column: "ElectorateId",
                principalTable: "Electorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Politicians_PoliticalParties_PoliticalPartyId",
                table: "Politicians",
                column: "PoliticalPartyId",
                principalTable: "PoliticalParties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
