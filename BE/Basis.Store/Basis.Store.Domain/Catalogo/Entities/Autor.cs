using Basis.Store.Domain.Catalogo.ValueObjects;

namespace Basis.Store.Domain.Catalogo.Entities
{
    public class Autor
    {
        public int Codigo { get; private set; }
        public NomeAutor NomeAutor { get; private set; } = null!;

        private Autor(string nomeAutor)
        {
            if (string.IsNullOrWhiteSpace(nomeAutor))
                throw new ArgumentNullException(nameof(nomeAutor));

            this.NomeAutor = new NomeAutor(nomeAutor);
        }

        public static Autor Criar(string nomeAutor)
        {
            return new Autor(nomeAutor);
        }

        public static Autor Restaurar(int codigo, string nomeAutor)
        {
            if (codigo <= 0)
                throw new ArgumentNullException("Código do autor é inválido", nameof(codigo));

            var autor = new Autor(nomeAutor);
            autor.Codigo = codigo;

            return autor;
        }
    }
}
