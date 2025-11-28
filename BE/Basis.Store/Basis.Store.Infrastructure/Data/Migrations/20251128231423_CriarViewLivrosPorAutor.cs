using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Basis.Store.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CriarViewLivrosPorAutor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE 
                  VIEW vw_LivrosPorAutor AS
                    SELECT
                           A.CodAu AS CodigoAutor,
                           A.Nome AS NomeAutor,
                           L.Cod AS CodigoLivro,
                           L.Titulo AS TituloLivro,
                           L.Editora,
                           L.AnoPublicacao,
                           L.PrecoBase,
                           STUFF(
                                (SELECT ', ' + T2.Descricao
                                   FROM Livro_Assunto T1
                             INNER JOIN Assunto T2 
                                     ON T1.AssuntoId = T2.CodAs
                                  WHERE T1.LivroId= L.Cod
                           FOR XML PATH('')), 1, 2, '') AS Assuntos
                      FROM Autor AS A
                INNER JOIN Livro_Autor AS LA 
                        ON A.CodAu = LA.AutorId
                INNER JOIN Livro AS L 
                        ON LA.LivroId = L.Cod");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW vw_LivrosPorAutor");
        }
    }
}
