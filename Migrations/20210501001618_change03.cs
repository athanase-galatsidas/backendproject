using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backendproject.Migrations
{
    public partial class change03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Medias_MediaId",
                table: "Actors");

            migrationBuilder.DropIndex(
                name: "IX_Actors_MediaId",
                table: "Actors");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: new Guid("2a13e437-961a-4dcc-87bb-d8647d460867"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "MediaId",
                keyValue: new Guid("38489244-42c1-4819-a2ff-bfdef0cb76fc"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "MediaId",
                keyValue: new Guid("e71c24da-cfec-471a-b371-7f4391b3c419"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b9d738aa-d0af-4432-80f9-11b809743314"));

            migrationBuilder.DropColumn(
                name: "MediaId",
                table: "Actors");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Medias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "MediaActor",
                columns: table => new
                {
                    MediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaActor", x => new { x.MediaId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_MediaActor_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaActor_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "MediaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "Name" },
                values: new object[] { new Guid("5ff1d481-6791-456c-9cab-ac8e35483657"), "Rainn Wilson" });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "MediaId", "Episodes", "Length", "Name", "Rating", "ReleaseDate", "Type" },
                values: new object[,]
                {
                    { new Guid("7f6e4ad9-5b4e-4b23-8378-e665533ae308"), 1, 90.0, "Shrek", 0.0, new DateTime(2001, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie" },
                    { new Guid("d4f3dc6f-f464-431f-9deb-c18c418db29a"), 6, 20.0, "The Office", 0.0, new DateTime(2005, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Series" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { new Guid("0273e60b-58fe-4748-a3b3-97290d3b41f0"), "bob@email.com", false, "Bob", "1234" });

            migrationBuilder.CreateIndex(
                name: "IX_MediaActor_ActorId",
                table: "MediaActor",
                column: "ActorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaActor");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: new Guid("5ff1d481-6791-456c-9cab-ac8e35483657"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "MediaId",
                keyValue: new Guid("7f6e4ad9-5b4e-4b23-8378-e665533ae308"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "MediaId",
                keyValue: new Guid("d4f3dc6f-f464-431f-9deb-c18c418db29a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("0273e60b-58fe-4748-a3b3-97290d3b41f0"));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Medias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "MediaId",
                table: "Actors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "MediaId", "Name" },
                values: new object[] { new Guid("2a13e437-961a-4dcc-87bb-d8647d460867"), null, "Rainn Wilson" });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "MediaId", "Episodes", "Length", "Name", "Rating", "ReleaseDate", "Type" },
                values: new object[,]
                {
                    { new Guid("38489244-42c1-4819-a2ff-bfdef0cb76fc"), 1, 90.0, "Shrek", 0.0, new DateTime(2001, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie" },
                    { new Guid("e71c24da-cfec-471a-b371-7f4391b3c419"), 6, 20.0, "The Office", 0.0, new DateTime(2005, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Series" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsAdmin", "Name", "Password" },
                values: new object[] { new Guid("b9d738aa-d0af-4432-80f9-11b809743314"), "bob@email.com", false, "Bob", "1234" });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_MediaId",
                table: "Actors",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Medias_MediaId",
                table: "Actors",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
