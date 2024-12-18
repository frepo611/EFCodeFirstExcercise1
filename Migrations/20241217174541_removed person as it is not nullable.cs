using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirstExcercise1.Migrations
{
    /// <inheritdoc />
    public partial class removedpersonasitisnotnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Person_ResponsibleId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ResponsibleId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ResponsibleId",
                table: "Tasks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResponsibleId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ResponsibleId",
                table: "Tasks",
                column: "ResponsibleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Person_ResponsibleId",
                table: "Tasks",
                column: "ResponsibleId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
