using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LayerDA.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YAbouts",
                columns: table => new
                {
                    YAbId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YAbDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YAbDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YAbImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YAbImage1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YAbMapLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YAbStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YAbouts", x => x.YAbId);
                });

            migrationBuilder.CreateTable(
                name: "YAskUss",
                columns: table => new
                {
                    YAId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YAUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YAMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YASubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YAMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YADate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YAStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YAskUss", x => x.YAId);
                });

            migrationBuilder.CreateTable(
                name: "YCategories",
                columns: table => new
                {
                    IdYCategory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameYCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionYCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusYCategory = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YCategories", x => x.IdYCategory);
                });

            migrationBuilder.CreateTable(
                name: "YWriters",
                columns: table => new
                {
                    YWID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YWName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YWAbout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YWImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YWMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YWPass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YWStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YWriters", x => x.YWID);
                });

            migrationBuilder.CreateTable(
                name: "YBlogs",
                columns: table => new
                {
                    YBID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YBTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YBContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YBSmallImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YBImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YBCreateDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YBStatus = table.Column<bool>(type: "bit", nullable: false),
                    IdYCategory = table.Column<int>(type: "int", nullable: false),
                    YCategoryIdYCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YBlogs", x => x.YBID);
                    table.ForeignKey(
                        name: "FK_YBlogs_YCategories_YCategoryIdYCategory",
                        column: x => x.YCategoryIdYCategory,
                        principalTable: "YCategories",
                        principalColumn: "IdYCategory",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YThoughts",
                columns: table => new
                {
                    YTId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YTUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YTTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YTContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YTDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YTStatus = table.Column<bool>(type: "bit", nullable: false),
                    YBID = table.Column<int>(type: "int", nullable: false),
                    YBlogYBID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YThoughts", x => x.YTId);
                    table.ForeignKey(
                        name: "FK_YThoughts_YBlogs_YBlogYBID",
                        column: x => x.YBlogYBID,
                        principalTable: "YBlogs",
                        principalColumn: "YBID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YBlogs_YCategoryIdYCategory",
                table: "YBlogs",
                column: "YCategoryIdYCategory");

            migrationBuilder.CreateIndex(
                name: "IX_YThoughts_YBlogYBID",
                table: "YThoughts",
                column: "YBlogYBID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YAbouts");

            migrationBuilder.DropTable(
                name: "YAskUss");

            migrationBuilder.DropTable(
                name: "YThoughts");

            migrationBuilder.DropTable(
                name: "YWriters");

            migrationBuilder.DropTable(
                name: "YBlogs");

            migrationBuilder.DropTable(
                name: "YCategories");
        }
    }
}
