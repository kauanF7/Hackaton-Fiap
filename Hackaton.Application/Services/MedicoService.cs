using Hackaton.Domain.Entities;
using Hackaton.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Application.Services
{
    public class MedicoService : IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoService(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        public Task AceitaAgendamento(int idConsulta, int idMedico)
        {
            throw new NotImplementedException();
        }

        public async Task CadastroAgenda(int idMedico, string especialidade, DateTime data)
        {
            await _medicoRepository.CadastroAgenda(idMedico, especialidade, data);
        }

        public async Task<List<Agenda>> ConsultarAgenda(int idMedico)
        {
            return await _medicoRepository.ConsultarAgenda(idMedico);
        }

        public async Task<List<Medico>> ConsultarMedicos()
        {
            return await _medicoRepository.ConsultarMedicos();
        }

        public async Task EditarAgenda(int idAgenda, DateTime horario)
        {
            await _medicoRepository.EditarAgenda(idAgenda, horario);
        }

        public Task RecusaAgendamento(int idConsulta, int idMedico)
        {
            throw new NotImplementedException();
        }

        public async Task RemoverAgenda(int idAgenda)
        {
            await _medicoRepository.RemoverAgenda(idAgenda);
        }
    }

}
