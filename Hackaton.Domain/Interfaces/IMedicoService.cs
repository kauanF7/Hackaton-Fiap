using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Domain.Interfaces
{
    public interface IMedicoService
    {
        public Task CadastroAgenda(int idMedico,string especialidade, DateTime data);
        public Task EditarAgenda(int idAgenda, DateTime horario);
        public Task RemoverAgenda(int idAgenda);
        public Task<List<Medico>> ConsultarMedicos();
        public Task<List<Agenda>> ConsultarAgenda(int idMedico);
        public Task AceitaAgendamento(int idConsulta, int idMedico);
        public Task RecusaAgendamento(int idConsulta, int idMedico);
    }
}
