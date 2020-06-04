using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PepeTheDog.Data.Migrations
{
    public partial class SeedAspNetRolesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO AspNetRoles (Id, Name, NormalizedName)" +
                $"Values ('{Guid.NewGuid()}', 'admin', 'admin')");

            migrationBuilder
                .Sql("INSERT INTO AspNetRoles (Id, Name, NormalizedName)" +
                $"Values ('{Guid.NewGuid()}', 'standard', 'standard')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM AspNetRoles");
        }
    }
}