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
            try
            {
                var funcionarioAdicionado = await _mediator.Send(adicionarFuncionario);

                if (funcionarioAdicionado) return Ok();

                return BadRequest(funcionarioAdicionado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("AtualizarNome")]
        public async Task<IActionResult> AtualizarNome([FromQuery]AtualizarNomeFuncionario atualizarNomeFuncionario)
        {
            try
            {
                var nomeAtualizado = await _mediator.Send(atualizarNomeFuncionario);

                if (nomeAtualizado) return Ok();

                return BadRequest(nomeAtualizado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("AtualizarDataFimContratacao")]
        public async Task<IActionResult> AtualizarDataFimContratacao([FromQuery]AtualizarDataFimContratacaoFuncionario atualizarDataFimContratacaoFuncionario)
        {
            try
            {
                var dataFimContratacaoAtualizada = await _mediator.Send(atualizarDataFimContratacaoFuncionario);

                if (dataFimContratacaoAtualizada) return Ok();

                return BadRequest(dataFimContratacaoAtualizada);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch]
        public async Task<IActionResult> MudarCargoFuncionario()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
