using Microsoft.EntityFrameworkCore.Migrations;

namespace ProTherm.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mutants",
                columns: table => new
                {
                    mutantID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    PDB = table.Column<string>(nullable: true),
                    pdburl = table.Column<string>(nullable: true),
                    size = table.Column<int>(nullable: false),
                    chain = table.Column<string>(nullable: true),
                    original = table.Column<string>(nullable: true),
                    site = table.Column<int>(nullable: false),
                    mutation = table.Column<string>(nullable: true),
                    ddg = table.Column<decimal>(type: "decimal(5, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mutants", x => x.mutantID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mutants");
        }
    }
}
