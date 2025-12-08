using Basis.Store.Domain.Catalogo.ValueObjects;
using Basis.Store.Domain.Precificacao.ValueObjects;
using Basis.Store.Domain.Common;

namespace Basis.Store.Domain.Catalogo.Entities
{
    public class Livro
    {
        public int? Id { get; private set; }
        public Titulo Titulo { get; private set; } = null!;
        public string Editora { get; private set; } = null!;
        public int Edicao { get; private set; }
        public int AnoPublicacao { get; private set; }
        public Preco PrecoBaseVenda { get; private set; } = null!;

        private readonly List<Autor> _autores = new();
        public IReadOnlyCollection<Autor> Autores => _autores.AsReadOnly();

        private readonly List<Assunto> _assuntos = new();
        public IReadOnlyCollection<Assunto> Assuntos => _assuntos.AsReadOnly();



        internal Livro(LivroBuilder builder)
        {
            if (string.IsNullOrWhiteSpace(builder._titulo))
                throw new InvalidOperationException("Falha de Integridade: Título não pode ser nulo");

            if (string.IsNullOrWhiteSpace(builder._editora))
                throw new InvalidOperationException("Falha de Integridade: Editora não pode ser nula");


            if (builder._autores == null)
                throw new InvalidOperationException("Falha de Integridade: Autores não pode ser nulo");

            if (builder._assuntos == null)
                throw new InvalidOperationException("Falha de Integridade: Assuntos não pode ser nulo");


            Id = builder._id;
            Titulo = new Titulo(builder._titulo);
            Editora = builder._editora;
            Edicao = builder._edicao;
            AnoPublicacao = builder._anoPublicacao;
            PrecoBaseVenda = new Preco(builder._precoBaseVenda);

            _autores = builder._autores;
            _assuntos = builder._assuntos;
        }







        public class LivroBuilder
        {
            internal int? _id;
            internal string _titulo = string.Empty;
            internal string _editora = string.Empty;
            internal int _edicao;
            internal int _anoPublicacao;
            internal decimal _precoBaseVenda;

            internal readonly List<Autor> _autores = new();
            internal readonly List<Assunto> _assuntos = new();



            public LivroBuilder ComDadosBasicos(
                string titulo,
                string editora,
                int edicao,
                int anoPublicacao,
                decimal precoBaseVenda)
            {
                _titulo = titulo;
                _editora = editora;
                _edicao = edicao;
                _anoPublicacao = anoPublicacao;
                _precoBaseVenda = precoBaseVenda;
                return this;
            }


            public LivroBuilder ComId(int id)
            {
                _id = id;
                return this;
            }


            public LivroBuilder ComAutores(IEnumerable<Autor> autores)
            {
                if (autores != null)
                    _autores.AddRange(autores);
                return this;
            }

            public LivroBuilder ComAssuntos(IEnumerable<Assunto> assuntos)
            {
                if (assuntos != null)
                    _assuntos.AddRange(assuntos);
                return this;
            }

            public Livro Criar()
            {

                if (_titulo.Length > 40)
                    throw new BusinessValidationException("Título deve ter no máximo 40 caracteres");

                if (_editora.Length > 40)
                    throw new BusinessValidationException("Editora deve ter no máximo 40 caracteres");

                if (_edicao <= 0)
                    throw new BusinessValidationException("Edição deve ser maior que zero");


                if (_anoPublicacao > DateTime.Now.Year)
                    throw new BusinessValidationException("Ano de publicação não pode ser futuro");


                return new Livro(this);

            }

            public Livro Restaurar()
            {
                if (_id == null)
                    throw new InvalidOperationException("Id deve ser informado para restaurar um Livro");

                return new Livro(this);
            }
        }
    }
}