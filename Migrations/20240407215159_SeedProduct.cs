using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMS3A.Sales.Migrations
{
    /// <inheritdoc />
    public partial class SeedProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          migrationBuilder.Sql("Insert into Product(Id,CreatedDate, Description,ImageUrl,IsActive,Price,Stock) Values('bcb69fb2-e55c-4cdc-b894-6b00def022d7','2024-04-07T23:38:14.004Z', 'Suco de Laranja','sucodelaranja.jpeg',1,10.50,15) ");
          migrationBuilder.Sql("Insert into Product(Id,CreatedDate, Description,ImageUrl,IsActive,Price,Stock) Values('ab332c5c-d47e-4c1a-92f1-6c7e7f00ba43', '2024-04-07T23:38:14.004Z','Pizza de Romeu e Julieta','pizzaderomeuejulieta.jpeg',1,49.50,15) ");
        
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql("Drop Table Product");
        }
    }
}
