using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMS3A.Sales.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
               migrationBuilder.Sql("Insert into Category(Id,Description,IsActive,ImageUrl) Values('8acadd85-8783-4dbe-aa31-025f4f698c77', 'Bebidas',1,'bebidas.jpeg') ");
               migrationBuilder.Sql("Insert into Category(Id,Description,IsActive,ImageUrl) Values('59270535-5d50-4a52-b008-6cf7fd7824b6', 'Pizzas',1,'pizza.jpeg') ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop Table Category");
        }
    }
}
