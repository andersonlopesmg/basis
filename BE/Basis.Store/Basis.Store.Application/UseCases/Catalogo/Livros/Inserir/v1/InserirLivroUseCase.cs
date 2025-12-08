using Basis.Store.Application.Common.Repositories.Catalogo;
using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.DTOs;
using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.Interfaces;
using Basis.Store.Domain.Catalogo.Entities;
using Basis.Store.Domain.Common;

namespace Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1
{
    public class InserirLivroUseCase : IInserirLivroUseCase
    {
        private readonly IAutorRepository autorRepository;
        private readonly IAssuntoRepository assuntoRepository;
        private readonly ILivroRepository repository;

        public InserirLivroUseCase(
            IAutorRepository autorRepository,
            IAssuntoRepository assuntoRepository,
            ILivroRepository repository)
        {
            this.autorRepository = autorRepository;
            this.assuntoRepository = assuntoRepository;
            this.repository = repository;
        }



        public async Task<int> Execute(InserirLivroRequest request)
        {
            var builder = new Livro.LivroBuilder();
            builder.ComDadosBasicos(request.Titulo, request.Editora, request.Edicao, request.AnoPublicacao, request.PrecoBaseVenda);

            var assuntos = new List<Assunto>();
            foreach (var assuntoId in request.Assuntos.Distinct())
            {
                var assunto = await assuntoRepository.DetalharPorIdAsync(assuntoId);
                if (assunto == null)
                {
                    throw new BusinessValidationException($"Assunto com código {assuntoId} não cadastrado");
                }
                assuntos.Add(assunto);
            }
            builder.ComAssuntos(assuntos);


            var autores = new List<Autor>();
            foreach (var autorId in request.Autores.Distinct())
            {
                var autor = await autorRepository.DetalharPorIdAsync(autorId);
                if (autor == null)
                {
                    throw new BusinessValidationException($"Autor com código {autorId} não cadastrado");
                }
                autores.Add(autor);
            }
            builder.ComAutores(autores);


            var livro = builder.Criar();
            var livroId = await repository.AdicionarAsync(livro);
            
            
            return livroId;
        }
    }
}
