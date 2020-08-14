using Microsoft.EntityFrameworkCore.Migrations;

namespace BlzTest.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fish",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LakeId = table.Column<int>(nullable: false),
                    FishName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fish", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lake",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LakeName = table.Column<string>(nullable: true),
                    DnrNumber = table.Column<string>(nullable: true),
                    Tier = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    EcoRegion = table.Column<string>(nullable: true),
                    IsSentinel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lake", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fish");

            migrationBuilder.DropTable(
                name: "Lake");
        }
    }
}
