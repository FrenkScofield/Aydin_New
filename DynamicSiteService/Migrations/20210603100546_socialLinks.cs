using Microsoft.EntityFrameworkCore.Migrations;

namespace DynamicSiteService.Migrations
{
    public partial class socialLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "SiteConfig",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pinterest",
                table: "SiteConfig",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Linkedin",
                table: "SiteConfig");

            migrationBuilder.DropColumn(
                name: "Pinterest",
                table: "SiteConfig");
        }
    }
}
