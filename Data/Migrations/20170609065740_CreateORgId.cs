using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WWW.Data.Migrations
{
    public partial class CreateORgId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrgId",
                table: "PersonalProducts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalProducts_OrgId",
                table: "PersonalProducts",
                column: "OrgId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalProducts_Orgs_OrgId",
                table: "PersonalProducts",
                column: "OrgId",
                principalTable: "Orgs",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalProducts_Orgs_OrgId",
                table: "PersonalProducts");

            migrationBuilder.DropIndex(
                name: "IX_PersonalProducts_OrgId",
                table: "PersonalProducts");

            migrationBuilder.DropColumn(
                name: "OrgId",
                table: "PersonalProducts");
        }
    }
}
