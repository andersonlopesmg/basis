using Basis.Store.Domain.Catalogo.ValueObjects;
using Basis.Store.Domain.Common;

namespace Basis.Store.Domain.Catalogo.Entities
{
    public class Autor
    {
        public int Codigo { get; private set; }
        public NomeAutor NomeAutor { get; private set; } = null!;

        private Autor(string nomeAutor)
        {
            if (string.IsNullOrWhiteSpace(nomeAutor))
                throw new BusinessValidationException("Nome do autor inválido");

            this.NomeAutor = new NomeAutor(nomeAutor);
        }

        public static Autor Criar(string nomeAutor)
        {
            return new Autor(nomeAutor);
        }

        public static Autor Restaurar(int codigo, string nomeAutor)
        {
            if (codigo <= 0)
                throw new BusinessValidationException("Código do autor é inválido");

            var autor = new Autor(nomeAutor);
            autor.Codigo = codigo;

            return autor;
        }
    }
}
