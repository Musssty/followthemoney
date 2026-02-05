using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FollowTheMoney.Migrations
{
    /// <inheritdoc />
    public partial class fixpolitician : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PoliticianOrganisations");

            migrationBuilder.DropColumn(
                name: "Electorate",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "TermEndDate",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "TermStartDate",
                table: "Politicians");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Electorate",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TermEndDate",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TermStartDate",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PoliticianOrganisations",
                columns: table => new
                {
                    PoliticianId = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrganisationId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoliticianOrganisations", x => new { x.PoliticianId, x.OrganisationId });
                    table.ForeignKey(
                        name: "FK_PoliticianOrganisations_Organisations_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PoliticianOrganisations_Politicians_PoliticianId",
                        column: x => x.PoliticianId,
                        principalTable: "Politicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PoliticianOrganisations_OrganisationId",
                table: "PoliticianOrganisations",
                column: "OrganisationId");
        }
    }
}
