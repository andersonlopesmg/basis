using Basis.Store.Application.Common.Interfaces;
using Basis.Store.Application.Common.Services;
using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.DTOs;
using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.Interfaces;
using Basis.Store.Application.UseCases.Catalogo.Livros.Listar.Paginado.v1.DTOs;
using Basis.Store.Application.UseCases.Catalogo.Livros.Listar.Paginado.v1.Interfaces;
using Basis.Store.Application.UseCases.Catalogo.Livros.Relatorios.PorAutor.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Basis.Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly IInserirLivroUseCase inserirLivroUseCase;
        private readonly IListarLivrosPaginadoUseCase listarLivrosPaginadoUseCase;
        private readonly IListarLivrosPorAutorUseCase listarLivrosPorAutorUseCase;
        private readonly ILoggerService loggerService;
        private readonly IPdfReportService pdfReportService;

        public LivrosController(
            IInserirLivroUseCase inserirLivroUseCase,
            IListarLivrosPaginadoUseCase listarLivrosPaginadoUseCase,
            IListarLivrosPorAutorUseCase listarLivrosPorAutorUseCase,
            ILoggerService loggerService,
            IPdfReportService pdfReportService)
        {
            this.inserirLivroUseCase = inserirLivroUseCase;
            this.listarLivrosPaginadoUseCase = listarLivrosPaginadoUseCase;
            this.listarLivrosPorAutorUseCase = listarLivrosPorAutorUseCase;
            this.loggerService = loggerService;
            this.pdfReportService = pdfReportService;
        }



        [HttpGet]
        public async Task<IActionResult> ConsultarPaginados([FromQuery] ListarLivrosPaginadoRequest request)
        {
            var result = await this.listarLivrosPaginadoUseCase.Executar(request);
            return Ok(result);
        }



        [HttpPost]
        public async Task<IActionResult> Inserir([FromBody] InserirLivroRequest request)
        {
            this.loggerService.LogInformation("Objeto de request recebido {@Request}", request);
            var livroID = await this.inserirLivroUseCase.Execute(request);
            return CreatedAtAction(nameof(inserirLivroUseCase), new { id = livroID }, request);
        }




        #region Relatorios

        [HttpGet]
        [Route("relatorios/livrosporautor")]
        public async Task<IActionResult> GerarRelatorioLivrosPorAutor()
        {
            var response = await listarLivrosPorAutorUseCase.Execute();

            //var pdfBytes = this.pdfReportService.GerarRelatorioPdf("Data/Reports/Catalogo/Livros/LivrosPorAutorReport.rdlc", "dsLivrosPorAutor", dados);

            return File(response.RelatorioPdf, "application/pdf", "Relatorio_Livros_Por_Autor.pdf");
        }



        #endregion 
    }
}
