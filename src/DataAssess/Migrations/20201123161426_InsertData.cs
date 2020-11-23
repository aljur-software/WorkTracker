using DataLayer.Scripts;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(InitialScript.InsertRoomTypeInitScript());
            migrationBuilder.Sql(InitialScript.InsertJobInitScript());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from RX_Job");
            migrationBuilder.Sql("Delete from RX_RoomType");
        }
    }
}
