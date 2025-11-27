using Basis.Store.API.IoC.Catalogo;

namespace Basis.Store.API.IoC
{
    public static class ConfigServicesIoC
    {
        public static void AddApiServicesIoC(this IServiceCollection services)
        {
            services.AddLivroIoC();
        }
    }
}
