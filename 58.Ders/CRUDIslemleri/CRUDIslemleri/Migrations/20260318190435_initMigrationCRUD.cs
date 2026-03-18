using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDIslemleri.Migrations
{
    /// <inheritdoc />
    public partial class initMigrationCRUD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogrenci",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciIsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciNo = table.Column<int>(type: "int", nullable: false),
                    Sinif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Not1 = table.Column<int>(type: "int", nullable: false),
                    Not2 = table.Column<int>(type: "int", nullable: false),
                    Not3 = table.Column<int>(type: "int", nullable: false),
                    Gecti = table.Column<bool>(type: "bit", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenci", x => x.OgrenciId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrenci");
        }
    }
}
