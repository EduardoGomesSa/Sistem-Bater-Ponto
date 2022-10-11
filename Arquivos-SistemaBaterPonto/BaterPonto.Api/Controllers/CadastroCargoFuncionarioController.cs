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

        [HttpPost("AdicionarCargo")]
        public async Task<IActionResult> AdicionarCargo([FromBody]AdicionarCargo adicionarCargo)
        {
            try
            {
                var cargoAdicionado = await _mediator.Send(adicionarCargo);

                if(cargoAdicionado) return Ok(cargoAdicionado);

                return BadRequest(cargoAdicionado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("AtualizarNomeCargo")]
        public async Task<IActionResult> AtualizarNomeCargo([FromQuery] AtualizarNomeCargo atualizarNomeCargo)
        {
            try
            {
                var nomeAtualizado = await _mediator.Send(atualizarNomeCargo);

                if (nomeAtualizado) return Ok();

                return BadRequest(nomeAtualizado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }

        [HttpPatch("AtualizarCargaHoraria")]
        public async Task<IActionResult> AtualizarCargaHoraria([FromQuery] AtualizarCargaHorariaCargo atualizarCargaHorariaCargo)
        {
            try
            {
                var cargaHorariaAtualizada = await _mediator.Send(atualizarCargaHorariaCargo);

                if (cargaHorariaAtualizada) return Ok();

                return BadRequest(cargaHorariaAtualizada);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("AtualizarValorHora")]
        public async Task<IActionResult> AtualizarValorHora([FromQuery]AtualizarValorHoraCargo atualizarValorHoraCargo)
        {
            try
            {
                var valorHoraAtualizada = await _mediator.Send(atualizarValorHoraCargo);

                if (valorHoraAtualizada) return Ok(valorHoraAtualizada);

                return BadRequest(valorHoraAtualizada);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("AtualizarEstadoDoCargo")]
        public async Task<IActionResult> AtualizarEstadoDoCargo([FromQuery] AtualizarEstadoCargo atualizarEstadoCargo)
        {
            try
            {
                var estadoAtualizado = await _mediator.Send(atualizarEstadoCargo);

                if (estadoAtualizado) return Ok(estadoAtualizado);

                return BadRequest(estadoAtualizado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
