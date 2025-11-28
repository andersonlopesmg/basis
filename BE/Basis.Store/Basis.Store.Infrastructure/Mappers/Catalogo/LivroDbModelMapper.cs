using Basis.Store.Domain.Catalogo.Entities;
using Basis.Store.Infrastructure.Entities.Catalogo;

namespace Basis.Store.Infrastructure.Mappers.Catalogo
{
    public static class LivroDbModelMapper
    {
        public static Livro ToDomain(this LivroDbModel livroDbModel)
        {
            if (livroDbModel == null)
            {
                return null!;
            }

            var livro = Livro.Restaurar(
                livroDbModel.Id,
                livroDbModel.Titulo,
                livroDbModel.Editora,
                livroDbModel.Edicao,
                livroDbModel.AnoPublicacao,
                livroDbModel.PrecoBase);

            var autores = livroDbModel.LivroAutores?
                .Select(x => x.Autor.ToDomain())
                .ToList() ?? new List<Autor>();

            livro.AdicionarAutores(autores);


            var assuntos = livroDbModel.LivroAssuntos?
                .Select(x => x.Assunto.ToDomain())
                .ToList() ?? new List<Assunto>();

            livro.AdicionarAssuntos(assuntos);

            return livro;
        }
    }
}
