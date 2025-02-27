using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IssueManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_Priorities_PriorityID",
                table: "Issues");

            migrationBuilder.DropForeignKey(
                name: "FK_Issues_Statuses_StatusId",
                table: "Issues");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Issues",
                type: "int",
                nullable: true,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "PriorityID",
                table: "Issues",
                type: "int",
                nullable: true,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_Priorities_PriorityID",
                table: "Issues",
                column: "PriorityID",
                principalTable: "Priorities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_Statuses_StatusId",
                table: "Issues",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_Priorities_PriorityID",
                table: "Issues");

            migrationBuilder.DropForeignKey(
                name: "FK_Issues_Statuses_StatusId",
                table: "Issues");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Issues",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "PriorityID",
                table: "Issues",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_Priorities_PriorityID",
                table: "Issues",
                column: "PriorityID",
                principalTable: "Priorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_Statuses_StatusId",
                table: "Issues",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
