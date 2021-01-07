using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AttributeRouting.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { 1, "Chris Anderson" },
                    { 2, "Cole Nussbaumer Knaflic" },
                    { 3, "Jeff Patton" },
                    { 4, "John MacCormick" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "AuthorId", "Description", "Genre", "Price", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "你可以用言語來改變自己，也改變世界 TED唯一官方版演講指南（限量精裝版）", "溝通說話", 320m, new DateTime(2016, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "TED TALKS 說話的力量" },
                    { 2, 2, "打破80/20法則，獲利無限延伸 (最新增訂版)", "經濟學", 450m, new DateTime(2009, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "尾理論" },
                    { 3, 2, "Google總監首度公開絕活，教你做對圖表、說對話，所有人都聽你的！", "演講/簡報", 420m, new DateTime(2016, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google必修的圖表簡報術" },
                    { 4, 3, "大型的便利貼模型，期望你感受到整個團隊全心參與並且充滿創造性。", "Software", 580m, new DateTime(2016, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "User Story Mapping" },
                    { 5, 4, "讓今日電腦無所不能的最強概念", "觀念/趨勢", 360m, new DateTime(2014, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "改變世界的九大演算法" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4);
        }
    }
}
