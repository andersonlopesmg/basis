using Basis.Store.Infrastructure.Entities.Catalogo;
using Microsoft.EntityFrameworkCore;

namespace Basis.Store.Infrastructure.Data.Seeds
{
    public static class CargaInicialGenerator
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var random = new Random();
            const int totalEntidades = 5;
            const int totalLivros = 50;

            // --- 1. SEED AUTORES ---
            var autoresSeedData = Enumerable.Range(1, totalEntidades).Select(i => new AutorDbModel
            {
                Id = i,
                Nome = $"Autor de Teste {i}"
            }).ToArray();
            modelBuilder.Entity<AutorDbModel>().HasData(autoresSeedData);

            // --- 2. SEED ASSUNTOS ---
            var assuntosSeedData = Enumerable.Range(1, totalEntidades).Select(i => new AssuntoDbModel
            {
                Id = i,
                Descricao = $"Assunto {i}"
            }).ToArray();
            modelBuilder.Entity<AssuntoDbModel>().HasData(assuntosSeedData);

            // --- 3. SEED LIVROS ---
            var livrosSeedData = Enumerable.Range(1, totalLivros).Select(i => new LivroDbModel
            {
                Id = i,
                Titulo = i % 5 == 0
                    ? $"O Efeito {i}: Inovação Radical em 90 Dias"
                    : $"Liderança Fluida {i} - Manifesto da Adaptabilidade",
                Editora = i % 2 == 0 ? "Editora Vanguarda" : "Editora Crescimento",
                Edicao = (i % 3) + 1,
                AnoPublicacao = (2020 + (i % 5)).ToString(),
                PrecoBase = 50.00M + (i * 2.50M)
            }).ToArray();
            modelBuilder.Entity<LivroDbModel>().HasData(livrosSeedData);

            // --- 4. SEED ASSOCIAÇÕES ALEATÓRIAS (Livro-Autor e Livro-Assunto) ---

            var livroAutorSeedList = new List<LivroAutorDbModel>();
            var livroAssuntoSeedList = new List<LivroAssuntoDbModel>();

            for (int i = 1; i <= totalLivros; i++)
            {
                // A) Geração Aleatória de Autores (1 a 3 por livro)
                var autoresParaAssociar = autoresSeedData.Select(a => a.Id)
                    .OrderBy(x => random.Next())
                    .Take(random.Next(1, 4));

                foreach (var autorId in autoresParaAssociar)
                {
                    livroAutorSeedList.Add(new LivroAutorDbModel { LivroId = i, AutorId = autorId });
                }

                // B) Geração Aleatória de Assuntos (1 a 5 por livro)
                var assuntosParaAssociar = assuntosSeedData.Select(a => a.Id)
                    .OrderBy(x => random.Next())
                    .Take(random.Next(1, 6));

                foreach (var assuntoId in assuntosParaAssociar)
                {
                    livroAssuntoSeedList.Add(new LivroAssuntoDbModel { LivroId = i, AssuntoId = assuntoId });
                }
            }

            modelBuilder.Entity<LivroAutorDbModel>().HasData(livroAutorSeedList);
            modelBuilder.Entity<LivroAssuntoDbModel>().HasData(livroAssuntoSeedList);
        }
    }
}
