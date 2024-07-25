using Microsoft.AspNetCore.Mvc;
using Hackaton.Domain.Interfaces;
using Hackaton.Domain.Entities;

namespace Hackaton.API.Controllers
{
    [ApiController]
    [Route("api/v1/medico")]
    public class MedicoController : ControllerBase
    {
        private readonly IMedicoService _medicoService;

        public MedicoController(IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        [HttpPost("CadastroAgenda")]
        public async Task<ActionResult> CadastroAgenda(int idMedico, string especialidade, DateTime data)
        {
            try
            {
                await _medicoService.CadastroAgenda(idMedico, especialidade, data);
                return Ok("Agenda Cadastrada com Sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro: {ex.Message}");
            }
        }


        [HttpPut("EditarAgenda")]
        public async Task<ActionResult> EditarAgenda(int idAgenda, DateTime horario)
        {
            try
            {

                await _medicoService.EditarAgenda(idAgenda, horario);

                return Ok("Agenda Editada com Sucesso");

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro: {ex.Message}");
            }
        }

        [HttpPost("RemoverAgenda")]
        public async Task<ActionResult> RemoverAgenda(int idAgenda)
        {
            try
            {
                return Ok("Agenda Removida com Sucesso");

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro: {ex.Message}");
            }
        }

        [HttpPost("ConsultarMedicos")]
        public async Task<ActionResult<List<Medico>>> ConsultarMedicos()
        {
            try
            {     
                return Ok(await _medicoService.ConsultarMedicos());
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro: {ex.Message}");
            }
        }

        [HttpPost("AceitarAgendamento")]
        public async Task<ActionResult> Aceita(int idConsulta, int idMedico)
        {
            try
            {
                await _medicoService.AceitaAgendamento(idConsulta, idMedico);

                return Ok("Consulta Aceita");

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro: {ex.Message}");
            }
        }

        [HttpPost("RecusaAgendamento")]
        public async Task<ActionResult> Recusa(int idConsulta, int idMedico)
        {
            try
            {
                await _medicoService.RecusaAgendamento(idConsulta, idMedico);
                return Ok("Consulta Recusada");

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro: {ex.Message}");
            }
        }
    }
}
