using Basis.Store.Domain.Catalogo.ValueObjects;
using Basis.Store.Domain.Precificacao.ValueObjects;
using Basis.Store.Domain.Common;

namespace Basis.Store.Domain.Catalogo.Entities
{
    public class Livro
    {
        private Livro(string titulo, string editora, int edicao, int anoPublicacao, decimal precoBaseVenda)
        {
            if(editora.Length > 40)
            {
                throw new BusinessValidationException("Editora deve ter no máximo 40 caracteres");
            }

            if (edicao <= 0)
            {
                throw new BusinessValidationException("Edição deve ser maior que zero");
            }

            Titulo = new Titulo(titulo);
            Editora = editora;
            Edicao = edicao;
            AnoPublicacao = anoPublicacao;
            PrecoBaseVenda = new Preco(precoBaseVenda);
        }

        public static Livro Criar(string titulo, string editora, int edicao, int anoPublicacao, decimal precoBaseVenda)
        {
            return new Livro(titulo, editora, edicao, anoPublicacao, precoBaseVenda);

        }

        public static Livro Restaurar(int id, string titulo, string editora, int edicao, int anoPublicacao, decimal precoBaseVenda)
        {
            if (id <= 0)
            {
                throw new BusinessValidationException("Id do livro é inválido");
            }

            var livro = new Livro(titulo, editora, edicao, anoPublicacao, precoBaseVenda);
            livro.Id = id;
            return livro;
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
