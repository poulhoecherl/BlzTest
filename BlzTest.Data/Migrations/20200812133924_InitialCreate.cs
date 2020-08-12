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
                    Id = table.Column<string>(nullable: false),
                    FishList = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Fish1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LakeId = table.Column<int>(nullable: false),
                    FishList = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fish1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fish1_Lake_LakeId",
                        column: x => x.LakeId,
                        principalTable: "Lake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fish1_LakeId",
                table: "Fish1",
                column: "LakeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fish");

            migrationBuilder.DropTable(
                name: "Fish1");

            migrationBuilder.DropTable(
                name: "Lake");
        }
    }
}
