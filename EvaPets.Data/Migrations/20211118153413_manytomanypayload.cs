using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EvaPets.Data.Migrations
{
    public partial class manytomanypayload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "CitiesStore",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOpened",
                table: "CitiesStore",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityId",
                table: "CitiesStore");

            migrationBuilder.DropColumn(
                name: "DateOpened",
                table: "CitiesStore");
        }
    }
}
