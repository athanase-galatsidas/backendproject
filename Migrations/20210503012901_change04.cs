using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backendproject.Migrations
{
    public partial class change04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaActor_Actors_ActorId",
                table: "MediaActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaActor_Medias_MediaId",
                table: "MediaActor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MediaActor",
                table: "MediaActor");

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

            migrationBuilder.RenameTable(
                name: "MediaActor",
                newName: "MediaActors");

            migrationBuilder.RenameIndex(
                name: "IX_MediaActor_ActorId",
                table: "MediaActors",
                newName: "IX_MediaActors_ActorId");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Medias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MediaActors",
                table: "MediaActors",
                columns: new[] { "MediaId", "ActorId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_MediaActors_Actors_ActorId",
                table: "MediaActors",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaActors_Medias_MediaId",
                table: "MediaActors",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaActors_Actors_ActorId",
                table: "MediaActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaActors_Medias_MediaId",
                table: "MediaActors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MediaActors",
                table: "MediaActors");

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

            migrationBuilder.RenameTable(
                name: "MediaActors",
                newName: "MediaActor");

            migrationBuilder.RenameIndex(
                name: "IX_MediaActors_ActorId",
                table: "MediaActor",
                newName: "IX_MediaActor_ActorId");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Medias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MediaActor",
                table: "MediaActor",
                columns: new[] { "MediaId", "ActorId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_MediaActor_Actors_ActorId",
                table: "MediaActor",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaActor_Medias_MediaId",
                table: "MediaActor",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "MediaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
