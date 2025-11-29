using Basis.Store.Application.UseCases.Catalogo.Livros.Relatorios.PorAutor.DTOs;

namespace Basis.Store.Application.Relatorios.Catalogo.Livros
{
    public interface IGerarRelatorioLivrosPorAutor
    {
        byte[] Execute(List<LivrosPorAutorDto> dados);
    }
}
