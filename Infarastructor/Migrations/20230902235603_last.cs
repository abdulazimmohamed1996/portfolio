using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infarastructor.Migrations
{
    /// <inheritdoc />
    public partial class last : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("9dd44b80-c922-4387-956f-427734a7cedb"));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("08cda494-2dce-4775-8433-6e32a0da879d"), "Avatar.jpg", "Abdulazim Mohamed", "FullStack DotNetDevloper" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("08cda494-2dce-4775-8433-6e32a0da879d"));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("9dd44b80-c922-4387-956f-427734a7cedb"), "Avatar.jpg", "Abdulazim Mohamed", "FullStack DotNetDevloper" });
        }
    }
}
