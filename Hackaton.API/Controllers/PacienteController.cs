using Microsoft.AspNetCore.Mvc;
using Hackaton.Domain.Interfaces;
using Hackaton.Domain.Entities;

namespace Hackaton.API.Controllers
{
    [ApiController]
    [Route("api/v1/Paciente")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;
        public PacienteController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        [HttpGet("Consultar")]
        public async Task<ActionResult<Paciente>> Consultar(int idPaciente)
        {
            try
            {
                return Ok(await _pacienteService.ConsultarPaciente(idPaciente));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro: {ex.Message}");
            }
        }

        [HttpPost("Agendar")]
        public async Task<ActionResult> Agendar(int idAgenda, int idPaciente)
        {
            try
            {
                await _pacienteService.Agendar(idAgenda, idPaciente);

                return Ok($"Consulta reservada, pendente aprovação do Doutor.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro: {ex.Message}");
            }
        }
    }
}
