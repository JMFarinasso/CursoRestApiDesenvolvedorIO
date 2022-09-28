using DevIo.Api.ViewModels;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.Api.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        // validacao notificoes de erro
        
        // validacao de modelstate

        // validacao de operacao de negocios
    };

    [Route("api/controller")]
    public class FornecedoresController : MainController
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedoresController(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;   
        }

        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> ObterTodos()
        {
            var fornecedores = await _fornecedorRepository.ObterTodos();

            return Ok(fornecedores);
        }
    }
}