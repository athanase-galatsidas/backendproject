using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backendproject.Migrations
{
    public partial class change05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: new Guid("d781aeab-1396-4333-99dd-4c122f42a348"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "MediaId",
                keyValue: new Guid("26d3eadb-da83-4b0e-a71d-6392a39e609a"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "MediaId",
                keyValue: new Guid("7c0d13d5-7513-4132-a666-ea89089f41a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8331b3d2-f633-49ed-ab22-fafaccd3a343"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "Name" },
                values: new object[] { new Guid("3e2ba825-78da-4b57-b5dd-05334b876634"), "Rainn Wilson" });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "MediaId", "Episodes", "Length", "Name", "Rating", "ReleaseDate", "Type" },
                values: new object[,]
                {
                    { new Guid("44abf6ad-0706-468c-9c73-099a80ff7229"), 1, 90.0, "Shrek", 0.0, new DateTime(2001, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie" },
                    { new Guid("024cb65b-a85c-4cc0-9801-cc79bdf5d4f6"), 6, 20.0, "The Office", 0.0, new DateTime(2005, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Series" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { new Guid("a78ecba7-9863-4d30-8c4b-05c380f71bd9"), "bob@email.com", false, "Bob", "1234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: new Guid("3e2ba825-78da-4b57-b5dd-05334b876634"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "MediaId",
                keyValue: new Guid("024cb65b-a85c-4cc0-9801-cc79bdf5d4f6"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "MediaId",
                keyValue: new Guid("44abf6ad-0706-468c-9c73-099a80ff7229"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a78ecba7-9863-4d30-8c4b-05c380f71bd9"));

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "Name" },
                values: new object[] { new Guid("d781aeab-1396-4333-99dd-4c122f42a348"), "Rainn Wilson" });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "MediaId", "Episodes", "Length", "Name", "Rating", "ReleaseDate", "Type" },
                values: new object[,]
                {
                    { new Guid("26d3eadb-da83-4b0e-a71d-6392a39e609a"), 1, 90.0, "Shrek", 0.0, new DateTime(2001, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie" },
                    { new Guid("7c0d13d5-7513-4132-a666-ea89089f41a1"), 6, 20.0, "The Office", 0.0, new DateTime(2005, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Series" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { new Guid("8331b3d2-f633-49ed-ab22-fafaccd3a343"), "bob@email.com", false, "Bob", "1234" });
        }
    }
}
