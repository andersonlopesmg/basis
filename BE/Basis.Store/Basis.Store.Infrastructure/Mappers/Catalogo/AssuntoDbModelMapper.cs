using Basis.Store.Domain.Catalogo.Entities;
using Basis.Store.Infrastructure.Entities.Catalogo;

namespace Basis.Store.Infrastructure.Mappers.Catalogo
{
    public static class AssuntoDbModelMapper
    {
        public static Assunto ToDomain(this AssuntoDbModel? assuntoDbModel)
        {
            if (assuntoDbModel == null)
            {
                throw new Exception("AssuntoDbModel não pode ser nulo");
            }

            var assunto = Assunto.Restaurar(
                assuntoDbModel.Id,
                assuntoDbModel.Descricao);

            return assunto;
        }
    }
}
