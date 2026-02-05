using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FollowTheMoney.Migrations
{
    /// <inheritdoc />
    public partial class updatemodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Politicians",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "ElectoralDivision",
                table: "Politicians",
                newName: "Salutation");

            migrationBuilder.RenameColumn(
                name: "Dob",
                table: "Politicians",
                newName: "ElectorateId");

            migrationBuilder.RenameColumn(
                name: "Founded",
                table: "PoliticalParties",
                newName: "FoundedDate");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Donations",
                newName: "Value");

            migrationBuilder.AddColumn<string>(
                name: "Electorate",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Honorific",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Initials",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinisterialTitle",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherName",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParliamentaryTitle",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PoliticalParty",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostNominals",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreferredName",
                table: "Politicians",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PoliticalParties",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DissolvedDate",
                table: "PoliticalParties",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ElectorateId",
                table: "PoliticalParties",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "PartyCode",
                table: "PoliticalParties",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedDate",
                table: "Gifts",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<bool>(
                name: "Declared",
                table: "Gifts",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Gifts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "currency",
                table: "Gifts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DonationFrom",
                table: "Donations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DonationTo",
                table: "Donations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DonorId",
                table: "Donations",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Event",
                table: "Donations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReturnType",
                table: "Donations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Donors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DonorCode = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DonorDesciption = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    TotalDonationsMade = table.Column<double>(type: "REAL", nullable: true),
                    TotalDonationsReceived = table.Column<double>(type: "REAL", nullable: true),
                    DonationId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Electorates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ElectorateCode = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ElectorateAddress1 = table.Column<string>(type: "TEXT", nullable: true),
                    ElectorateAddress2 = table.Column<string>(type: "TEXT", nullable: true),
                    ElectorateSuburb = table.Column<string>(type: "TEXT", nullable: true),
                    ElectorateState = table.Column<string>(type: "TEXT", nullable: true),
                    ElectoratePostcode = table.Column<string>(type: "TEXT", nullable: true),
                    ElectorateTelephone = table.Column<string>(type: "TEXT", nullable: true),
                    ElectorateFax = table.Column<string>(type: "TEXT", nullable: true),
                    ElectorateTollFree = table.Column<string>(type: "TEXT", nullable: true),
                    ElectoratePostalAddress1 = table.Column<string>(type: "TEXT", nullable: true),
                    ElectoratePostalAddress2 = table.Column<string>(type: "TEXT", nullable: true),
                    ElectoratePostalSuburb = table.Column<string>(type: "TEXT", nullable: true),
                    ElectoratePostalState = table.Column<string>(type: "TEXT", nullable: true),
                    ElectoratePostalPostcode = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PoliticalPartyId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Electorates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Electorates_PoliticalParties_PoliticalPartyId",
                        column: x => x.PoliticalPartyId,
                        principalTable: "PoliticalParties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Politicians_ElectorateId",
                table: "Politicians",
                column: "ElectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_PoliticalParties_ElectorateId",
                table: "PoliticalParties",
                column: "ElectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonorId",
                table: "Donations",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Electorates_PoliticalPartyId",
                table: "Electorates",
                column: "PoliticalPartyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Donors_DonorId",
                table: "Donations",
                column: "DonorId",
                principalTable: "Donors",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Donors_DonorId",
                table: "Donations");

            migrationBuilder.DropForeignKey(
                name: "FK_PoliticalParties_Electorates_ElectorateId",
                table: "PoliticalParties");

            migrationBuilder.DropForeignKey(
                name: "FK_Politicians_Electorates_ElectorateId",
                table: "Politicians");

            migrationBuilder.DropTable(
                name: "Donors");

            migrationBuilder.DropTable(
                name: "Electorates");

            migrationBuilder.DropIndex(
                name: "IX_Politicians_ElectorateId",
                table: "Politicians");

            migrationBuilder.DropIndex(
                name: "IX_PoliticalParties_ElectorateId",
                table: "PoliticalParties");

            migrationBuilder.DropIndex(
                name: "IX_Donations_DonorId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "Electorate",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "Honorific",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "Initials",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "MinisterialTitle",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "OtherName",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "ParliamentaryTitle",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "PoliticalParty",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "PostNominals",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "PreferredName",
                table: "Politicians");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PoliticalParties");

            migrationBuilder.DropColumn(
                name: "DissolvedDate",
                table: "PoliticalParties");

            migrationBuilder.DropColumn(
                name: "ElectorateId",
                table: "PoliticalParties");

            migrationBuilder.DropColumn(
                name: "PartyCode",
                table: "PoliticalParties");

            migrationBuilder.DropColumn(
                name: "Declared",
                table: "Gifts");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Gifts");

            migrationBuilder.DropColumn(
                name: "currency",
                table: "Gifts");

            migrationBuilder.DropColumn(
                name: "DonationFrom",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "DonationTo",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "DonorId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "Event",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "ReturnType",
                table: "Donations");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Politicians",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "Salutation",
                table: "Politicians",
                newName: "ElectoralDivision");

            migrationBuilder.RenameColumn(
                name: "ElectorateId",
                table: "Politicians",
                newName: "Dob");

            migrationBuilder.RenameColumn(
                name: "FoundedDate",
                table: "PoliticalParties",
                newName: "Founded");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Donations",
                newName: "Amount");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedDate",
                table: "Gifts",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
