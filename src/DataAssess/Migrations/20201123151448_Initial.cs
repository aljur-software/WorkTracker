using System;
using DataLayer.Scripts;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(InitialScript.CreateRX_RoomTypeInitScript());
            migrationBuilder.Sql(InitialScript.CreateRX_JobInitScript());  
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RX_Job");

            migrationBuilder.DropTable(
                name: "RX_RoomType");
        }
    }
}
