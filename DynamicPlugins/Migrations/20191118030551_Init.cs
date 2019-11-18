using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DynamicPlugins.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PluginMigrations",
                columns: table => new
                {
                    PluginMigrationId = table.Column<Guid>(nullable: false),
                    PluginId = table.Column<Guid>(nullable: false),
                    Version = table.Column<string>(nullable: true),
                    Up = table.Column<string>(nullable: true),
                    Down = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PluginMigrations", x => x.PluginMigrationId);
                });

            migrationBuilder.CreateTable(
                name: "Plugins",
                columns: table => new
                {
                    PluginId = table.Column<Guid>(nullable: false),
                    UniqueKey = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    IsEnable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plugins", x => x.PluginId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PluginMigrations");

            migrationBuilder.DropTable(
                name: "Plugins");
        }
    }
}
