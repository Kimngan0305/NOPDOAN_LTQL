using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LTQL_DOAN.Migrations
{
    /// <inheritdoc />
    public partial class AddKhoRelationToSach : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MaSach",
                table: "Sach",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaSach",
                table: "Kho",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Sach_MaSach",
                table: "Sach",
                column: "MaSach");

            migrationBuilder.CreateIndex(
                name: "IX_Kho_MaSach",
                table: "Kho",
                column: "MaSach");

            migrationBuilder.AddForeignKey(
                name: "FK_Kho_Sach_MaSach",
                table: "Kho",
                column: "MaSach",
                principalTable: "Sach",
                principalColumn: "MaSach",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kho_Sach_MaSach",
                table: "Kho");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Sach_MaSach",
                table: "Sach");

            migrationBuilder.DropIndex(
                name: "IX_Kho_MaSach",
                table: "Kho");

            migrationBuilder.AlterColumn<string>(
                name: "MaSach",
                table: "Sach",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MaSach",
                table: "Kho",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
