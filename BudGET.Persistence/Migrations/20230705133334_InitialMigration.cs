using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BudGET.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comptes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Intitule = table.Column<string>(type: "text", nullable: false),
                    Montant = table.Column<double>(type: "double precision", nullable: false),
                    EstCompteCourant = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comptes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Montant = table.Column<double>(type: "double precision", nullable: false),
                    Exception = table.Column<bool>(type: "boolean", nullable: false),
                    CompteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Budgets_Comptes_CompteId",
                        column: x => x.CompteId,
                        principalTable: "Comptes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Objectifs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Valeur = table.Column<double>(type: "double precision", nullable: false),
                    CompteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectifs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objectifs_Comptes_CompteId",
                        column: x => x.CompteId,
                        principalTable: "Comptes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Salaires",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Valeur = table.Column<double>(type: "double precision", nullable: false),
                    CompteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salaires_Comptes_CompteId",
                        column: x => x.CompteId,
                        principalTable: "Comptes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Depenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Valeur = table.Column<double>(type: "double precision", nullable: false),
                    BudgetId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depenses_Budgets_BudgetId",
                        column: x => x.BudgetId,
                        principalTable: "Budgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Depenses_Comptes_CompteId",
                        column: x => x.CompteId,
                        principalTable: "Comptes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_CompteId",
                table: "Budgets",
                column: "CompteId");

            migrationBuilder.CreateIndex(
                name: "IX_Depenses_BudgetId",
                table: "Depenses",
                column: "BudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_Depenses_CompteId",
                table: "Depenses",
                column: "CompteId");

            migrationBuilder.CreateIndex(
                name: "IX_Objectifs_CompteId",
                table: "Objectifs",
                column: "CompteId");

            migrationBuilder.CreateIndex(
                name: "IX_Salaires_CompteId",
                table: "Salaires",
                column: "CompteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Depenses");

            migrationBuilder.DropTable(
                name: "Objectifs");

            migrationBuilder.DropTable(
                name: "Salaires");

            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.DropTable(
                name: "Comptes");
        }
    }
}
