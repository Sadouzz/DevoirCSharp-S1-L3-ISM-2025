using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GesApprovisionnement.Migrations
{
    /// <inheritdoc />
    public partial class FixturesInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    PrixUnitaire = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Tel = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Approvisionnements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reference = table.Column<string>(type: "text", nullable: false),
                    DateApprovisionnement = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MontantTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    Commentaires = table.Column<string>(type: "text", nullable: false),
                    FournisseurId = table.Column<int>(type: "integer", nullable: false),
                    Statut = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approvisionnements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Approvisionnements_Fournisseurs_FournisseurId",
                        column: x => x.FournisseurId,
                        principalTable: "Fournisseurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApproArticles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantite = table.Column<int>(type: "integer", nullable: false),
                    Montant = table.Column<decimal>(type: "numeric", nullable: false),
                    ApproId = table.Column<int>(type: "integer", nullable: false),
                    ArticleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApproArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApproArticles_Approvisionnements_ApproId",
                        column: x => x.ApproId,
                        principalTable: "Approvisionnements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApproArticles_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Nom", "PrixUnitaire" },
                values: new object[,]
                {
                    { 1, "Tissu Coton", 1500m },
                    { 2, "Fil Polyester", 500m },
                    { 3, "Boutons Métal", 100m },
                    { 4, "Fermeture Éclair", 300m }
                });

            migrationBuilder.InsertData(
                table: "Fournisseurs",
                columns: new[] { "Id", "Nom", "Tel" },
                values: new object[,]
                {
                    { 1, "Textiles Dakar SARL", "77 123 45 67" },
                    { 2, "Mercerie Centrale", "78 222 33 44" },
                    { 3, "Tissus Premium", "76 987 65 43" }
                });

            migrationBuilder.InsertData(
                table: "Approvisionnements",
                columns: new[] { "Id", "Commentaires", "DateApprovisionnement", "FournisseurId", "MontantTotal", "Reference", "Statut" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, "APP-2023-001", 0 },
                    { 2, "", new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0m, "APP-2023-002", 0 },
                    { 3, "", new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 0m, "APP-2023-003", 1 }
                });

            migrationBuilder.InsertData(
                table: "ApproArticles",
                columns: new[] { "Id", "ApproId", "ArticleId", "Montant", "Quantite" },
                values: new object[,]
                {
                    { 1, 1, 1, 300000m, 200 },
                    { 2, 1, 2, 50000m, 100 },
                    { 3, 2, 4, 15000m, 50 },
                    { 4, 3, 3, 30000m, 300 },
                    { 5, 3, 1, 225000m, 150 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApproArticles_ApproId",
                table: "ApproArticles",
                column: "ApproId");

            migrationBuilder.CreateIndex(
                name: "IX_ApproArticles_ArticleId",
                table: "ApproArticles",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Approvisionnements_FournisseurId",
                table: "Approvisionnements",
                column: "FournisseurId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApproArticles");

            migrationBuilder.DropTable(
                name: "Approvisionnements");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Fournisseurs");
        }
    }
}
