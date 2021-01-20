using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTripShare.Migrations
{
    public partial class initmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableNumber = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TimeOfExpense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfMembersInvolved = table.Column<byte>(type: "tinyint", nullable: false),
                    NamesOfMembersInvolved = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseId);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    TableInfoId = table.Column<byte>(type: "tinyint", nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.TableInfoId);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MembersInfoId = table.Column<byte>(type: "tinyint", nullable: false),
                    TableNumber = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableInfoId = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MembersInfoId);
                    table.ForeignKey(
                        name: "FK_Members_Tables_TableInfoId",
                        column: x => x.TableInfoId,
                        principalTable: "Tables",
                        principalColumn: "TableInfoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_TableInfoId",
                table: "Members",
                column: "TableInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Tables");
        }
    }
}
