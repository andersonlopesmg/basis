using Basis.Store.Application.UseCases.Catalogo.Livros.Relatorios.PorAutor.DTOs;
using Basis.Store.Infrastructure.Entities.Catalogo.Views;
using System.Globalization;

namespace Basis.Store.Infrastructure.Mappers.Catalogo.Views
{
    public static class LivrosPorAutorViewModelMapper
    {
        public static LivrosPorAutorDto ToDomain(this LivrosPorAutorViewModel livrosPorAutorViewModel)
        {
            if (livrosPorAutorViewModel == null)
            {
                return null!;
            }


            var LivrosPorAutorResponse = new LivrosPorAutorDto
            {
                CodigoAutor = livrosPorAutorViewModel.CodigoAutor,
                NomeAutor = livrosPorAutorViewModel.NomeAutor,
                CodigoLivro = livrosPorAutorViewModel.CodigoLivro,
                TituloLivro = livrosPorAutorViewModel.TituloLivro,
                Editora = livrosPorAutorViewModel.Editora,
                AnoPublicacao = livrosPorAutorViewModel.AnoPublicacao,
                PrecoBase = livrosPorAutorViewModel.PrecoBase.ToString(),
                Assuntos = livrosPorAutorViewModel.Assuntos
            };

            return LivrosPorAutorResponse;
        }
    }
}
