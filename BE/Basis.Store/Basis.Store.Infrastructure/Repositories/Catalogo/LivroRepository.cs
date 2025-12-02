using Azure.Core;
using Basis.Store.Application.Common.Paginacao;
using Basis.Store.Application.Common.Repositories.Catalogo;
using Basis.Store.Application.UseCases.Catalogo.Livros.Listar;
using Basis.Store.Application.UseCases.Catalogo.Livros.Relatorios.PorAutor.DTOs;
using Basis.Store.Domain.Catalogo.Entities;
using Basis.Store.Domain.Common;
using Basis.Store.Infrastructure.Data;
using Basis.Store.Infrastructure.Entities.Catalogo;
using Basis.Store.Infrastructure.Extensions;
using Basis.Store.Infrastructure.Mappers.Catalogo;
using Basis.Store.Infrastructure.Mappers.Catalogo.Views;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Basis.Store.Infrastructure.Repositories.Catalogo
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public LivroRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }


        public async Task<int> AdicionarAsync(Livro livro)
        {
            var livroDbModel = new LivroDbModel
            {
                AnoPublicacao = livro.AnoPublicacao.ToString(),
                Editora = livro.Editora,
                Titulo = livro.Titulo.Valor,
                Edicao = livro.Edicao,
                PrecoBase = livro.PrecoBaseVenda.Valor,
                LivroAssuntos = livro.Assuntos.Select(a => new LivroAssuntoDbModel
                {
                    AssuntoId = a.Codigo
                }).ToList(),
                LivroAutores = livro.Autores.Select(a => new LivroAutorDbModel
                {
                    AutorId = a.Codigo
                }).ToList()
            };


            await this.applicationDbContext.Livro.AddAsync(livroDbModel);
            await this.applicationDbContext.SaveChangesAsync();

            return livroDbModel.Id;
        }

        public Task AtualizarAsync(Livro livro)
        {
            throw new NotImplementedException();
        }


        public async Task<List<LivrosPorAutorDto>> ListarLivrosPorAutor()
        {
            var retorno = applicationDbContext.LivrosPorAutorViewModel;

            return await retorno
                .Select(x => x.ToDomain())
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<ResultadoPaginado<Livro>> ConsultarPaginado(LivroFilter livroFilter, PaginacaoDto paginacao)
        {
            var query = FiltrarLivro(livroFilter);
            var totalDeItens = await query.CountAsync();
            var itensPagina = await query
                .Paginar(paginacao, ObterExpressaoOrdenacao(paginacao.ColunaOrdenacao))
                .Select(x => x.ToDomain())
                .ToListAsync();
            return new ResultadoPaginado<Livro>(itensPagina, totalDeItens, paginacao.Pagina, paginacao.TamanhoDaPagina);
        }

        public Task<Livro?> DetalharPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Livro>> ListarAsync()
        {
            throw new NotImplementedException();
        }


        private IQueryable<LivroDbModel> FiltrarLivro(LivroFilter filtro)
        {
            var query = applicationDbContext.Livro.AsQueryable();

            if (!string.IsNullOrEmpty(filtro.NomeAutor))
                query = query.Where(x => x.LivroAutores.Any(x => x.Autor.Nome.Contains(filtro.NomeAutor)));

            if (!string.IsNullOrEmpty(filtro.Titulo))
                query = query.Where(x => x.Titulo.Contains(filtro.Titulo));

            query.Include(x => x.LivroAutores)
                    .ThenInclude(x => x.Autor)
                .Include(x => x.LivroAssuntos)
                    .ThenInclude(x => x.Assunto);

            return query.AsSplitQuery();
        }

        private static Expression<Func<LivroDbModel, object>> ObterExpressaoOrdenacao(string? colunaOrdenacao)
        {
            ListarLivroOrdenacaoEnum coluna = ListarLivroOrdenacaoEnum.Id;

            if (!string.IsNullOrEmpty(colunaOrdenacao) && !Enum.TryParse(colunaOrdenacao, true, out coluna))
            {
                throw new BusinessValidationException($"Coluna {colunaOrdenacao} inválida para ordenação");
            }


            return coluna switch
            {
                ListarLivroOrdenacaoEnum.Titulo => x => x.Titulo,
                ListarLivroOrdenacaoEnum.AnoPublicacao => x => x.AnoPublicacao,
                _ => x => x.Id,
            };
        }
    }
}
