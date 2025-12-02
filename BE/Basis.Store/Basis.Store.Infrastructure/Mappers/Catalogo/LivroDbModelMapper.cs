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

            var builder = new Livro.LivroBuilder()
                .ComDadosBasicos(
                    livroDbModel.Titulo,
                    livroDbModel.Editora,
                    livroDbModel.Edicao,
                    Convert.ToInt32(livroDbModel.AnoPublicacao),
                    livroDbModel.PrecoBase);

            
            builder.ComId(livroDbModel.Id);

            var autores = livroDbModel.LivroAutores
                .Select(x => x.Autor.ToDomain())
                .ToList();

            builder.ComAutores(autores);


            var assuntos = livroDbModel.LivroAssuntos
                .Select(x => x.Assunto.ToDomain())
                .ToList();

            builder.ComAssuntos(assuntos);

            return builder.Restaurar();
        }
    }
}
