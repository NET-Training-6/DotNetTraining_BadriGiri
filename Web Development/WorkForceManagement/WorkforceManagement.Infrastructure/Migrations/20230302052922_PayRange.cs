using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkForceManagement.web.Migrations
{
    /// <inheritdoc />
    public partial class PayRange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PayRange",
                table: "DesignationsTable",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PayRange",
                table: "DesignationsTable");
        }
    }
}
