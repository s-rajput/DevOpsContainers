using Microsoft.EntityFrameworkCore.Migrations;

namespace DevOpsChallenge.SalesApi.Database.Migrations
{
    public partial class IndexCreation : Migration
    {
        protected readonly string SaleEntityTable = "Sale";
        protected readonly string TransactionIDColumn = "TransactionId";
        protected readonly string SaleEntityIndexName = "IX_SaleEntity_TransactionId";

        protected override void Up(MigrationBuilder migrationBuilder)
        { 
            migrationBuilder.CreateIndex(
                name: SaleEntityIndexName,
                table: SaleEntityTable,
                column: TransactionIDColumn).Annotation("SqlServer:Online", true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
               name: SaleEntityIndexName,
               table: SaleEntityTable);

        }
    }
}
