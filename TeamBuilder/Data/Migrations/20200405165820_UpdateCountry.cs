﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamBuilder.Data.Migrations
{
    public partial class UpdateCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "Country",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "Country");
        }
    }
}
