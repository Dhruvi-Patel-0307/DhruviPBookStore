using DhruviPBooks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DhruviPBooks.DataAccess.Migrations
{
    public partial class AddCategoryToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
