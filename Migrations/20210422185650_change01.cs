using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backendproject.Migrations
{
    public partial class change01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Medias",
                newName: "MediaId");

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "MediaId", "Episodes", "Length", "Name", "ReleaseDate", "Type" },
                values: new object[] { new Guid("dcbee563-50e7-4ceb-8855-e4125cdb77cf"), 1, 90.0, "Shrek", new DateTime(2001, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie" });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "MediaId", "Episodes", "Length", "Name", "ReleaseDate", "Type" },
                values: new object[] { new Guid("c3bca2a1-8c3b-4a83-8c7c-542ff59d59d4"), 6, 20.0, "The Office", new DateTime(2005, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Series" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "MediaId",
                keyValue: new Guid("c3bca2a1-8c3b-4a83-8c7c-542ff59d59d4"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "MediaId",
                keyValue: new Guid("dcbee563-50e7-4ceb-8855-e4125cdb77cf"));

            migrationBuilder.RenameColumn(
                name: "MediaId",
                table: "Medias",
                newName: "MovieId");
        }
    }
}
