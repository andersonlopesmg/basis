using Basis.Store.Application.Common.Repositories;
using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.DTOs;
using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.Interfaces;

namespace Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1
{
    public class InserirLivroUseCase : IInserirLivroUseCase
    {
        private readonly ILivroRepository repository;

        public InserirLivroUseCase(ILivroRepository repository)
        {
            this.repository = repository;
        }

        
        public Task<int> Execute(InserirLivroRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
