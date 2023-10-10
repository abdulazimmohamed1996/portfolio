using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infarastructor.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("fc0aecef-45e4-4d0f-8fcb-ffa350985153"));

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("9dd44b80-c922-4387-956f-427734a7cedb"), "Avatar.jpg", "Abdulazim Mohamed", "FullStack DotNetDevloper" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("9dd44b80-c922-4387-956f-427734a7cedb"));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("fc0aecef-45e4-4d0f-8fcb-ffa350985153"), "Avatar.jpg", "Abdulazim Mohamed", "FullStack DotNetDevloper" });
        }
    }
}
