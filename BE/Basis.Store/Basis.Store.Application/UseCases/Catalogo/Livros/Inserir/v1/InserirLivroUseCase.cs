using Basis.Store.Application.Common.Repositories;
using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.DTOs;
using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.Interfaces;
using Basis.Store.Domain.Catalogo.Entities;
using Basis.Store.Domain.Common;

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
            Livro l = Livro.Criar(request.Titulo, request.Editora, request.Edicao, request.AnoPublicacao, request.PrecoBaseVenda);
            
            throw new BusinessValidationException("Falha na validação de negócio");
        }
    }
}
