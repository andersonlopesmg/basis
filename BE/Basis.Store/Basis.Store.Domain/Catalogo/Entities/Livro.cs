using Basis.Store.Domain.Catalogo.ValueObjects;
using Basis.Store.Domain.Precificacao.ValueObjects;
using Basis.Store.Domain.Shared;

namespace Basis.Store.Domain.Catalogo.Entities
{
    public class Livro
    {
        private Livro()
        {
        }

        public static Livro Criar(string titulo, string editora, int edicao, int anoPublicacao, decimal precoBaseVenda)
        {
            if (edicao <= 0)
            {
                throw new BusinessValidationException("Edição deve ser maior que zero");
            }

            return new Livro
            {
                Titulo = new Titulo(titulo),
                Editora = editora,
                Edicao = edicao,
                AnoPublicacao = anoPublicacao,
                PrecoBaseVenda = new Preco(precoBaseVenda)
            };
        }
        public int Id { get; private set; }
        public Titulo Titulo { get; private set; } = null!;
        public string Editora { get; private set; } = null!;
        public int Edicao { get; private set; }
        public int AnoPublicacao { get; private set; }
        public Preco PrecoBaseVenda { get; private set; } = null!;


        private readonly List<Autor> _autores = new();
        public IReadOnlyCollection<Autor> Autores => _autores.AsReadOnly();

        private readonly List<Assunto> _assuntos = new();
        public IReadOnlyCollection<Assunto> Assuntos => _assuntos.AsReadOnly();
    }
}
