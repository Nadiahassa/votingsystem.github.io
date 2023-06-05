using Microsoft.EntityFrameworkCore.Migrations;

namespace EvotingApi.Data.Migrations
{
    public partial class DropColumnCadidateNid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NationalId",
                table: "Candidates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NationalId",
                table: "Candidates",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
