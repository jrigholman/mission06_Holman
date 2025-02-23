﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06.Migrations
{
    /// <inheritdoc />
    public partial class AddCopiedToPlexAndCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Movies");
        }
    }
}
