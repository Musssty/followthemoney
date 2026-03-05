using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FollowTheMoney.Migrations
{
    /// <inheritdoc />
    public partial class updatepolitician : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Politicians",
                newName: "Surname");

            migrationBuilder.AddColumn<string>(
                name: "Electorate",
                table: "Politicians",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Electorate",
                table: "Politicians");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Politicians",
                newName: "LastName");
        }
    }
}
