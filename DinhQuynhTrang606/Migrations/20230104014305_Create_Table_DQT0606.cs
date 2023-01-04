using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DinhQuynhTrang606.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableDQT0606 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DQT0606",
                columns: table => new
                {
                    DQTId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DQTName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DQTGender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DQT0606", x => x.DQTId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DQT0606");
        }
    }
}
