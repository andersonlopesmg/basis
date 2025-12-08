using Basis.Store.Application.Common.Repositories.Catalogo;
using Basis.Store.Application.Relatorios.Catalogo.Livros;
using Basis.Store.Application.UseCases.Catalogo.Livros.Relatorios.PorAutor.DTOs;
using Basis.Store.Application.UseCases.Catalogo.Livros.Relatorios.PorAutor.Interfaces;

namespace Basis.Store.Application.UseCases.Catalogo.Livros.Relatorios.PorAutor
{
    public class ListarLivrosPorAutorUseCase : IListarLivrosPorAutorUseCase
    {
        private readonly ILivroRepository livroRepository;
        private readonly IGerarRelatorioLivrosPorAutor gerarRelatorioLivrosPorAutor;

        public ListarLivrosPorAutorUseCase(ILivroRepository livroRepository,
            IGerarRelatorioLivrosPorAutor gerarRelatorioLivrosPorAutor)
        {
            this.livroRepository = livroRepository;
            this.gerarRelatorioLivrosPorAutor = gerarRelatorioLivrosPorAutor;
        }
        public async Task<ListarLivrosPorAutorResponse> Execute()
        {
            var dados = await this.livroRepository.ListarLivrosPorAutor();
            var pdf = this.gerarRelatorioLivrosPorAutor.Execute(dados);
            return new ListarLivrosPorAutorResponse
            {
                RelatorioPdf = pdf
            };
        }
    }
}
