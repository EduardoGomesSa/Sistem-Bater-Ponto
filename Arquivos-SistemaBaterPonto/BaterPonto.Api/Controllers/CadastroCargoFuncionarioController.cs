using BaterPonto.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaterPonto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroCargoFuncionarioController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CadastroCargoFuncionarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPatch]
        public async Task<IActionResult> AtualizarNomeCargo([FromQuery] AtualizarNomeCargo atualizarNomeCargo)
        {
            var nomeAtualizado = await _mediator.Send(atualizarNomeCargo);

            if(nomeAtualizado) return Ok();

            return BadRequest(nomeAtualizado);
        }
    }
}
