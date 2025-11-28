using Basis.Store.Application.Common.Paginacao;
using System.Linq.Expressions;

namespace Basis.Store.Infrastructure.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> query, PaginacaoDto paginacao, Expression<Func<T, object>>? expressaoOrdenacao)
        {
            if (paginacao == null)
            {
                return query;
            }

            if (expressaoOrdenacao != null)
            {
                query = paginacao.Orientacao == OrientacaoOrdenacaoConst.Asc
                ? query.OrderBy(expressaoOrdenacao)
                : query.OrderByDescending(expressaoOrdenacao);
            }

            return query.Skip((paginacao.Pagina - 1) * paginacao.TamanhoDaPagina)
                        .Take(paginacao.TamanhoDaPagina);
        }
    }
}
