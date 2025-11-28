using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1;
using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.Interfaces;
using Basis.Store.Application.UseCases.Catalogo.Livros.Listar.Paginado.v1;
using Basis.Store.Application.UseCases.Catalogo.Livros.Listar.Paginado.v1.Interfaces;

namespace Basis.Store.API.IoC.Catalogo
{
    public static class LivroIoC
    {
        public static void AddLivroIoC(this IServiceCollection services)
        {
            services.AddScoped<IInserirLivroUseCase, InserirLivroUseCase>();
            services.AddScoped<IListarLivrosPaginadoUseCase, ListarLivrosPaginadoUseCase>();
        }   
    }
}
