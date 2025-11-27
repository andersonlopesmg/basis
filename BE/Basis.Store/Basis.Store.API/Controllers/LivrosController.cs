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

        public LivrosController(IInserirLivroUseCase inserirLivroUseCase)
        {
            this.inserirLivroUseCase = inserirLivroUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> Inserir([FromBody] InserirLivroRequest request)
        {
            var livroID = await this.inserirLivroUseCase.Execute(request);
            return CreatedAtAction(nameof(inserirLivroUseCase), new { id = livroID }, request);
        }
    }
}
