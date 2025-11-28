using Basis.Store.Domain.Catalogo.ValueObjects;
using Basis.Store.Domain.Precificacao.ValueObjects;
using Basis.Store.Domain.Common;

namespace Basis.Store.Domain.Catalogo.Entities
{
    public class Livro
    {
        private Livro(string titulo, string editora, int edicao, int anoPublicacao, decimal precoBaseVenda)
        {
            if (editora.Length < 40)
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
            if (anoPublicacao <= 0 || anoPublicacao.ToString().Length != 4)
            {
                throw new BusinessValidationException("Ano publicação deve ser um número válido com 4 dígitos");
            }
            if(anoPublicacao > DateTime.Now.Year)
            {
                throw new BusinessValidationException("Ano de publicação não pode ser maior que o ano atual");
            }

            return new Livro(titulo, editora, edicao, anoPublicacao, precoBaseVenda);

        }

        public static Livro Restaurar(int id, string titulo, string editora, int edicao, string anoPublicacao, decimal precoBaseVenda)
        {
            if (id <= 0)
            {
                throw new BusinessValidationException("Id do livro é inválido");
            }

            if (!int.TryParse(anoPublicacao, out var anoPublicacaoInt))
            {
                throw new BusinessValidationException($"O ano de publicação do livro com {id} está inválido. O ano de publicação deve ser um número");
            }

            var livro = new Livro(titulo, editora, edicao, anoPublicacaoInt, precoBaseVenda);
            livro.Id = id;
            return livro;
        }

        public void AdicionarAutores(IEnumerable<Autor> autores)
        {
            if (autores != null)
            {
                _autores.AddRange(autores);
            }
        }

        public void AdicionarAssuntos(IEnumerable<Assunto> assuntos)
        {
            if (assuntos != null)
            {
                _assuntos.AddRange(assuntos);
            }
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
