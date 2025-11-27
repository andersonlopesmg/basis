using Basis.Store.Application.Common.Interfaces;
using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.DTOs;
using Basis.Store.Application.UseCases.Catalogo.Livros.Inserir.v1.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Basis.Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly IInserirLivroUseCase inserirLivroUseCase;
        private readonly ILoggerService loggerService;

        public LivrosController(IInserirLivroUseCase inserirLivroUseCase, ILoggerService loggerService)
        {
            this.inserirLivroUseCase = inserirLivroUseCase;
            this.loggerService = loggerService;
        }

        [HttpPost]
        public async Task<IActionResult> Inserir([FromBody] InserirLivroRequest request)
        {   
            this.loggerService.LogInformation("Objeto de request recebido {@Request}", request);
            var livroID = await this.inserirLivroUseCase.Execute(request);
            return CreatedAtAction(nameof(inserirLivroUseCase), new { id = livroID }, request);
        }
    }
}
