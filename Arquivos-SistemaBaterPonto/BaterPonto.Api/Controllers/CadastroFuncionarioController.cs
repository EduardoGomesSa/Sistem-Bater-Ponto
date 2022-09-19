using BaterPonto.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaterPonto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroFuncionarioController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CadastroFuncionarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult Post([FromBody] AdicionarFuncionario adicionarFuncionario)
        {
            var funcionarioAdicionado = _mediator.Send(adicionarFuncionario);

            return Ok();
        }
    }
}
