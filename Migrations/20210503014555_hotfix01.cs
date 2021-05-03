using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backendproject.Migrations
{
    public partial class hotfix01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("a4d5e88f-8c88-4d36-a5d1-42360465e3fe"), "Rainn Wilson" });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "MediaId", "Episodes", "Length", "Name", "Rating", "ReleaseDate", "Type" },
                values: new object[,]
                {
                    { new Guid("ec73431b-a9a7-42c1-a0fc-531b42b287e1"), 1, 90.0, "Shrek", 0.0, new DateTime(2001, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie" },
                    { new Guid("d19237bb-25e1-4826-8a38-5ed881e8a77c"), 6, 20.0, "The Office", 0.0, new DateTime(2005, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Series" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { new Guid("a93aee65-b07c-4ba0-a264-60d156cfd162"), "bob@email.com", false, "Bob", "1234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: new Guid("a4d5e88f-8c88-4d36-a5d1-42360465e3fe"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "MediaId",
                keyValue: new Guid("d19237bb-25e1-4826-8a38-5ed881e8a77c"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "MediaId",
                keyValue: new Guid("ec73431b-a9a7-42c1-a0fc-531b42b287e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a93aee65-b07c-4ba0-a264-60d156cfd162"));

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
    }
}
