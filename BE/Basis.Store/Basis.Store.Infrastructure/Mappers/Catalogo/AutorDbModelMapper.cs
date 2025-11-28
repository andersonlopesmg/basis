using Basis.Store.Domain.Catalogo.Entities;
using Basis.Store.Infrastructure.Entities.Catalogo;

namespace Basis.Store.Infrastructure.Mappers.Catalogo
{
    public static class AutorDbModelMapper
    {
        public static Autor ToDomain(this AutorDbModel autorDbModel)
        {
            if (autorDbModel == null)
            {
                return null!;
            }

            var autor = Autor.Restaurar(
                autorDbModel.Id,
                autorDbModel.Nome);
            
            return autor;
        }   
    }
}
