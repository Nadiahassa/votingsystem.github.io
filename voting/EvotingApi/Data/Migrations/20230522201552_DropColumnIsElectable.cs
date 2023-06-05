using Microsoft.EntityFrameworkCore.Migrations;

namespace EvotingApi.Data.Migrations
{
    public partial class DropColumnIsElectable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsElectable",
                table: "Voters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsElectable",
                table: "Voters",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
