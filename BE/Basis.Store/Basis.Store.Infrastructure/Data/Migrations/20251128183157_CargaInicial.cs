using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Basis.Store.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CargaInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assunto",
                columns: new[] { "CodAs", "Descricao" },
                values: new object[,]
                {
                    { 1, "Assunto 1" },
                    { 2, "Assunto 2" },
                    { 3, "Assunto 3" },
                    { 4, "Assunto 4" },
                    { 5, "Assunto 5" }
                });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "CodAu", "Nome" },
                values: new object[,]
                {
                    { 1, "Autor de Teste 1" },
                    { 2, "Autor de Teste 2" },
                    { 3, "Autor de Teste 3" },
                    { 4, "Autor de Teste 4" },
                    { 5, "Autor de Teste 5" }
                });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Cod", "AnoPublicacao", "Edicao", "Editora", "PrecoBase", "Titulo" },
                values: new object[,]
                {
                    { 1, "2021", 2, "Editora Crescimento", 52.50m, "Liderança Fluida 1" },
                    { 2, "2022", 3, "Editora Vanguarda", 55.00m, "Liderança Fluida 2" },
                    { 3, "2023", 1, "Editora Crescimento", 57.50m, "Liderança Fluida 3" },
                    { 4, "2024", 2, "Editora Vanguarda", 60.00m, "Liderança Fluida 4" },
                    { 5, "2020", 3, "Editora Crescimento", 62.50m, "O Efeito 5: Inovação Radical em 90 Dias" },
                    { 6, "2021", 1, "Editora Vanguarda", 65.00m, "Liderança Fluida 6" },
                    { 7, "2022", 2, "Editora Crescimento", 67.50m, "Liderança Fluida 7" },
                    { 8, "2023", 3, "Editora Vanguarda", 70.00m, "Liderança Fluida 8" },
                    { 9, "2024", 1, "Editora Crescimento", 72.50m, "Liderança Fluida 9" },
                    { 10, "2020", 2, "Editora Vanguarda", 75.00m, "O Efeito 10: Inovação Radical em 90 Dias" },
                    { 11, "2021", 3, "Editora Crescimento", 77.50m, "Liderança Fluida 11" },
                    { 12, "2022", 1, "Editora Vanguarda", 80.00m, "Liderança Fluida 12" },
                    { 13, "2023", 2, "Editora Crescimento", 82.50m, "Liderança Fluida 13" },
                    { 14, "2024", 3, "Editora Vanguarda", 85.00m, "Liderança Fluida 14" },
                    { 15, "2020", 1, "Editora Crescimento", 87.50m, "O Efeito 15: Inovação Radical em 90 Dias" },
                    { 16, "2021", 2, "Editora Vanguarda", 90.00m, "Liderança Fluida 16" },
                    { 17, "2022", 3, "Editora Crescimento", 92.50m, "Liderança Fluida 17" },
                    { 18, "2023", 1, "Editora Vanguarda", 95.00m, "Liderança Fluida 18" },
                    { 19, "2024", 2, "Editora Crescimento", 97.50m, "Liderança Fluida 19" },
                    { 20, "2020", 3, "Editora Vanguarda", 100.00m, "O Efeito 20: Inovação Radical em 90 Dias" },
                    { 21, "2021", 1, "Editora Crescimento", 102.50m, "Liderança Fluida 21" },
                    { 22, "2022", 2, "Editora Vanguarda", 105.00m, "Liderança Fluida 22" },
                    { 23, "2023", 3, "Editora Crescimento", 107.50m, "Liderança Fluida 23" },
                    { 24, "2024", 1, "Editora Vanguarda", 110.00m, "Liderança Fluida 24" },
                    { 25, "2020", 2, "Editora Crescimento", 112.50m, "O Efeito 25: Inovação Radical em 90 Dias" },
                    { 26, "2021", 3, "Editora Vanguarda", 115.00m, "Liderança Fluida 26" },
                    { 27, "2022", 1, "Editora Crescimento", 117.50m, "Liderança Fluida 27" },
                    { 28, "2023", 2, "Editora Vanguarda", 120.00m, "Liderança Fluida 28" },
                    { 29, "2024", 3, "Editora Crescimento", 122.50m, "Liderança Fluida 29" },
                    { 30, "2020", 1, "Editora Vanguarda", 125.00m, "O Efeito 30: Inovação Radical em 90 Dias" },
                    { 31, "2021", 2, "Editora Crescimento", 127.50m, "Liderança Fluida 31" },
                    { 32, "2022", 3, "Editora Vanguarda", 130.00m, "Liderança Fluida 32" },
                    { 33, "2023", 1, "Editora Crescimento", 132.50m, "Liderança Fluida 33" },
                    { 34, "2024", 2, "Editora Vanguarda", 135.00m, "Liderança Fluida 34" },
                    { 35, "2020", 3, "Editora Crescimento", 137.50m, "O Efeito 35: Inovação Radical em 90 Dias" },
                    { 36, "2021", 1, "Editora Vanguarda", 140.00m, "Liderança Fluida 36" },
                    { 37, "2022", 2, "Editora Crescimento", 142.50m, "Liderança Fluida 37" },
                    { 38, "2023", 3, "Editora Vanguarda", 145.00m, "Liderança Fluida 38" },
                    { 39, "2024", 1, "Editora Crescimento", 147.50m, "Liderança Fluida 39" },
                    { 40, "2020", 2, "Editora Vanguarda", 150.00m, "O Efeito 40: Inovação Radical em 90 Dias" },
                    { 41, "2021", 3, "Editora Crescimento", 152.50m, "Liderança Fluida 41" },
                    { 42, "2022", 1, "Editora Vanguarda", 155.00m, "Liderança Fluida 42" },
                    { 43, "2023", 2, "Editora Crescimento", 157.50m, "Liderança Fluida 43" },
                    { 44, "2024", 3, "Editora Vanguarda", 160.00m, "Liderança Fluida 44" },
                    { 45, "2020", 1, "Editora Crescimento", 162.50m, "O Efeito 45: Inovação Radical em 90 Dias" },
                    { 46, "2021", 2, "Editora Vanguarda", 165.00m, "Liderança Fluida 46" },
                    { 47, "2022", 3, "Editora Crescimento", 167.50m, "Liderança Fluida 47" },
                    { 48, "2023", 1, "Editora Vanguarda", 170.00m, "Liderança Fluida 48" },
                    { 49, "2024", 2, "Editora Crescimento", 172.50m, "Liderança Fluida 49" },
                    { 50, "2020", 3, "Editora Vanguarda", 175.00m, "O Efeito 50: Inovação Radical em 90 Dias" }
                });

            migrationBuilder.InsertData(
                table: "Livro_Assunto",
                columns: new[] { "AssuntoId", "LivroId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 5, 2 },
                    { 4, 3 },
                    { 1, 4 },
                    { 3, 4 },
                    { 4, 4 },
                    { 5, 4 },
                    { 2, 5 },
                    { 3, 5 },
                    { 1, 6 },
                    { 3, 6 },
                    { 5, 6 },
                    { 2, 7 },
                    { 1, 8 },
                    { 2, 8 },
                    { 3, 8 },
                    { 4, 8 },
                    { 5, 8 },
                    { 2, 9 },
                    { 3, 9 },
                    { 5, 9 },
                    { 1, 10 },
                    { 2, 10 },
                    { 3, 10 },
                    { 4, 10 },
                    { 5, 10 },
                    { 2, 11 },
                    { 3, 11 },
                    { 4, 11 },
                    { 5, 11 },
                    { 4, 12 },
                    { 5, 12 },
                    { 2, 13 },
                    { 4, 13 },
                    { 1, 14 },
                    { 2, 14 },
                    { 3, 14 },
                    { 4, 14 },
                    { 5, 14 },
                    { 1, 15 },
                    { 5, 15 },
                    { 2, 16 },
                    { 5, 16 },
                    { 2, 17 },
                    { 4, 17 },
                    { 5, 17 },
                    { 1, 18 },
                    { 2, 18 },
                    { 3, 18 },
                    { 5, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 2, 20 },
                    { 3, 20 },
                    { 4, 20 },
                    { 5, 20 },
                    { 1, 21 },
                    { 2, 21 },
                    { 3, 21 },
                    { 4, 21 },
                    { 1, 22 },
                    { 2, 22 },
                    { 3, 22 },
                    { 4, 22 },
                    { 3, 23 },
                    { 3, 24 },
                    { 5, 24 },
                    { 1, 25 },
                    { 2, 25 },
                    { 3, 25 },
                    { 4, 25 },
                    { 5, 25 },
                    { 1, 26 },
                    { 2, 26 },
                    { 4, 26 },
                    { 5, 26 },
                    { 1, 27 },
                    { 2, 27 },
                    { 4, 27 },
                    { 3, 28 },
                    { 2, 29 },
                    { 3, 29 },
                    { 5, 29 },
                    { 1, 30 },
                    { 2, 30 },
                    { 3, 30 },
                    { 4, 30 },
                    { 5, 30 },
                    { 1, 31 },
                    { 2, 31 },
                    { 3, 31 },
                    { 4, 31 },
                    { 5, 31 },
                    { 4, 32 },
                    { 1, 33 },
                    { 3, 33 },
                    { 4, 33 },
                    { 5, 33 },
                    { 1, 34 },
                    { 2, 34 },
                    { 1, 35 },
                    { 2, 35 },
                    { 3, 35 },
                    { 4, 35 },
                    { 5, 35 },
                    { 1, 36 },
                    { 5, 36 },
                    { 5, 37 },
                    { 4, 38 },
                    { 3, 39 },
                    { 1, 40 },
                    { 2, 40 },
                    { 4, 40 },
                    { 5, 40 },
                    { 1, 41 },
                    { 2, 41 },
                    { 3, 41 },
                    { 5, 41 },
                    { 1, 42 },
                    { 2, 42 },
                    { 4, 42 },
                    { 5, 42 },
                    { 2, 43 },
                    { 3, 43 },
                    { 4, 43 },
                    { 5, 43 },
                    { 1, 44 },
                    { 2, 44 },
                    { 3, 44 },
                    { 4, 44 },
                    { 5, 44 },
                    { 1, 45 },
                    { 4, 45 },
                    { 5, 45 },
                    { 3, 46 },
                    { 4, 47 },
                    { 5, 47 },
                    { 5, 48 },
                    { 2, 49 },
                    { 1, 50 },
                    { 2, 50 },
                    { 3, 50 },
                    { 4, 50 },
                    { 5, 50 }
                });

            migrationBuilder.InsertData(
                table: "Livro_Autor",
                columns: new[] { "AutorId", "LivroId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 3, 5 },
                    { 5, 5 },
                    { 4, 6 },
                    { 5, 6 },
                    { 3, 7 },
                    { 4, 7 },
                    { 5, 7 },
                    { 1, 8 },
                    { 5, 8 },
                    { 3, 9 },
                    { 1, 10 },
                    { 2, 10 },
                    { 3, 11 },
                    { 1, 12 },
                    { 2, 12 },
                    { 1, 13 },
                    { 2, 13 },
                    { 3, 13 },
                    { 3, 14 },
                    { 2, 15 },
                    { 1, 16 },
                    { 2, 16 },
                    { 3, 16 },
                    { 2, 17 },
                    { 4, 17 },
                    { 4, 18 },
                    { 1, 19 },
                    { 2, 19 },
                    { 3, 19 },
                    { 3, 20 },
                    { 4, 20 },
                    { 5, 20 },
                    { 1, 21 },
                    { 2, 21 },
                    { 3, 21 },
                    { 4, 22 },
                    { 3, 23 },
                    { 4, 23 },
                    { 1, 24 },
                    { 4, 24 },
                    { 3, 25 },
                    { 5, 26 },
                    { 1, 27 },
                    { 2, 27 },
                    { 4, 27 },
                    { 1, 28 },
                    { 2, 29 },
                    { 3, 30 },
                    { 1, 31 },
                    { 5, 31 },
                    { 2, 32 },
                    { 4, 32 },
                    { 1, 33 },
                    { 2, 33 },
                    { 3, 33 },
                    { 1, 34 },
                    { 2, 34 },
                    { 2, 35 },
                    { 4, 35 },
                    { 5, 35 },
                    { 2, 36 },
                    { 4, 36 },
                    { 1, 37 },
                    { 2, 37 },
                    { 3, 37 },
                    { 1, 38 },
                    { 2, 38 },
                    { 3, 38 },
                    { 3, 39 },
                    { 5, 39 },
                    { 1, 40 },
                    { 4, 40 },
                    { 5, 40 },
                    { 1, 41 },
                    { 3, 41 },
                    { 5, 41 },
                    { 1, 42 },
                    { 2, 42 },
                    { 2, 43 },
                    { 5, 43 },
                    { 3, 44 },
                    { 4, 44 },
                    { 1, 45 },
                    { 2, 45 },
                    { 3, 45 },
                    { 1, 46 },
                    { 1, 47 },
                    { 3, 48 },
                    { 1, 49 },
                    { 2, 49 },
                    { 3, 49 },
                    { 2, 50 },
                    { 4, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 20 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 21 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 21 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 24 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 25 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 25 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 25 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 26 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 26 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 27 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 27 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 28 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 29 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 29 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 29 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 30 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 30 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 30 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 30 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 31 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 31 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 31 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 31 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 32 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 33 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 33 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 33 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 34 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 35 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 35 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 35 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 35 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 35 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 36 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 36 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 37 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 38 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 39 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 40 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 40 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 40 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 40 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 41 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 41 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 41 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 41 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 42 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 42 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 42 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 42 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 43 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 43 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 43 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 43 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 44 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 44 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 44 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 44 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 44 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 45 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 45 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 45 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 46 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 47 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 47 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 48 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 49 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 1, 50 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 2, 50 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 3, 50 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 4, 50 });

            migrationBuilder.DeleteData(
                table: "Livro_Assunto",
                keyColumns: new[] { "AssuntoId", "LivroId" },
                keyValues: new object[] { 5, 50 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 20 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 21 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 23 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 24 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 27 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 27 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 29 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 30 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 31 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 32 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 32 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 33 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 33 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 34 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 35 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 35 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 35 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 36 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 36 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 37 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 37 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 38 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 38 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 38 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 39 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 39 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 40 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 40 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 40 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 41 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 41 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 41 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 42 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 42 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 43 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 5, 43 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 44 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 44 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 45 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 45 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 45 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 46 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 47 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 48 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 1, 49 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 49 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 3, 49 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 2, 50 });

            migrationBuilder.DeleteData(
                table: "Livro_Autor",
                keyColumns: new[] { "AutorId", "LivroId" },
                keyValues: new object[] { 4, 50 });

            migrationBuilder.DeleteData(
                table: "Assunto",
                keyColumn: "CodAs",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assunto",
                keyColumn: "CodAs",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assunto",
                keyColumn: "CodAs",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assunto",
                keyColumn: "CodAs",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assunto",
                keyColumn: "CodAs",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "CodAu",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "CodAu",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "CodAu",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "CodAu",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "CodAu",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Cod",
                keyValue: 50);
        }
    }
}
