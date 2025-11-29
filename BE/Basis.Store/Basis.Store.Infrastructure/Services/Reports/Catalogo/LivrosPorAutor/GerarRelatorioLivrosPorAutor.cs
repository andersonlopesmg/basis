using Basis.Store.Application.Relatorios.Catalogo.Livros;
using Basis.Store.Application.UseCases.Catalogo.Livros.Relatorios.PorAutor.DTOs;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basis.Store.Infrastructure.Services.Reports.Catalogo.LivrosPorAutor
{
    public class GerarRelatorioLivrosPorAutor : IGerarRelatorioLivrosPorAutor
    {
        public byte[] Execute(List<LivrosPorAutorDto> dados)
        {

            QuestPDF.Settings.License = LicenseType.Community;

            var dadosAgrupados = dados.GroupBy(x => new { x.CodigoAutor, x.NomeAutor });


            var documento = Document.Create(container =>
            {
                container.Page(page =>
                {
                    // Configurações da Página
                    page.Size(PageSizes.A4);
                    page.Margin(1, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily(Fonts.Arial));


                    page.Header()
                        .PaddingBottom(10)
                        .Row(row =>
                        {
                            row.RelativeItem().Text("Relatório de Livros por Autor").FontSize(16).SemiBold().FontColor(Colors.Blue.Medium);
                            row.RelativeItem().AlignRight().Text(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                        });


                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(50); // Código
                            columns.RelativeColumn(3);  // Título (Maior)
                            columns.RelativeColumn(2);  // Editora
                            columns.ConstantColumn(40); // Ano
                            columns.ConstantColumn(70); // Preço
                            columns.RelativeColumn(2);  // Assuntos
                        });

                        // 5. Cabeçalho da Tabela (Fixo)
                        table.Header(header =>
                        {
                            header.Cell().Element(EstiloCabecalho).Text("Código");
                            header.Cell().Element(EstiloCabecalho).Text("Título");
                            header.Cell().Element(EstiloCabecalho).Text("Editora");
                            header.Cell().Element(EstiloCabecalho).Text("Ano");
                            header.Cell().Element(EstiloCabecalho).AlignRight().Text("Preço");
                            header.Cell().Element(EstiloCabecalho).Text("Assuntos");
                        });

                        // 6. Iteração dos Grupos (AUTORES)
                        foreach (var grupoAutor in dadosAgrupados)
                        {
                            // --- LINHA DO GRUPO (AUTOR) ---
                            // ColumnSpan(6) faz a célula ocupar a linha inteira
                            table.Cell().ColumnSpan(6)
                                .PaddingTop(10) // Espaço antes do grupo
                                .PaddingBottom(5)
                                .Background(Colors.Grey.Lighten3) // Fundo Cinza
                                .BorderBottom(1).BorderColor(Colors.Black)
                                .Padding(5)
                                .Text($"{grupoAutor.Key.CodigoAutor} - {grupoAutor.Key.NomeAutor}")
                                .FontSize(11).Bold();

                            // --- LINHAS DE DETALHE (LIVROS) ---
                            foreach (var livro in grupoAutor)
                            {
                                table.Cell().Element(EstiloLinha).Text(livro.CodigoLivro.ToString());
                                table.Cell().Element(EstiloLinha).Text(livro.TituloLivro);
                                table.Cell().Element(EstiloLinha).Text(livro.Editora);
                                table.Cell().Element(EstiloLinha).AlignCenter().Text(livro.AnoPublicacao);

                                // Formatação de Moeda
                                table.Cell().Element(EstiloLinha).AlignRight().Text($"R$ {livro.PrecoBase:N2}");

                                table.Cell().Element(EstiloLinha).Text(livro.Assuntos);
                            }
                        }
                    });

                    // --- RODAPÉ ---
                    page.Footer().AlignCenter().Text(x =>
                    {
                        x.Span("Página ");
                        x.CurrentPageNumber();
                        x.Span(" de ");
                        x.TotalPages();
                    });
                });
            });

            return documento.GeneratePdf();
        }


        static IContainer EstiloCabecalho(IContainer container)
        {
            return container
                .BorderBottom(1)
                .BorderColor(Colors.Grey.Darken1)
                .Padding(5)
                .AlignMiddle();
        }

        static IContainer EstiloLinha(IContainer container)
        {
            return container
                .BorderBottom(1)
                .BorderColor(Colors.Grey.Lighten4) // Linha suave entre livros
                .PaddingVertical(5)
                .PaddingHorizontal(5)
                .AlignMiddle();
        }
    }
}