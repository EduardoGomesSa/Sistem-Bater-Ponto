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
        public async Task<IActionResult> Post([FromBody] AdicionarFuncionario adicionarFuncionario)
        {
            var funcionarioAdicionado = await _mediator.Send(adicionarFuncionario);

            if(funcionarioAdicionado) return Ok();

            return BadRequest(funcionarioAdicionado);
        }

        [HttpPatch("AtualizarNome")]
        public async Task<IActionResult> AtualizarNome([FromQuery]AtualizarNomeFuncionario atualizarNomeFuncionario)
        {
            var nomeAtualizado = await _mediator.Send(atualizarNomeFuncionario);

            if(nomeAtualizado) return Ok();

            return BadRequest(nomeAtualizado);
        }

        [HttpPatch("AtualizarDataFimContratacao")]
        public async Task<IActionResult> AtualizarDataFimContratacao([FromQuery]AtualizarDataFimContratacaoFuncionario atualizarDataFimContratacaoFuncionario)
        {
            var dataFimContratacaoAtualizada = await _mediator.Send(atualizarDataFimContratacaoFuncionario);

            if(dataFimContratacaoAtualizada) return Ok();

            return BadRequest(dataFimContratacaoAtualizada);
        }
    }
}
