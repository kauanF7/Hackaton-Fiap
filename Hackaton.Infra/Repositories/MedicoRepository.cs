using Hackaton.Domain.Entities;
using Hackaton.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Infra.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        public Task AceitaAgendamento(int idConsulta, int idMedico)
        {
            throw new NotImplementedException();
        }

        public Task CadastroAgenda(int idMedico, string especialidade, DateTime data)
        {
            throw new NotImplementedException();
        }

        public Task<List<Agenda>> ConsultarAgenda(int idMedico)
        {
            throw new NotImplementedException();
        }

        public Task<List<Medico>> ConsultarMedicos()
        {
            throw new NotImplementedException();
        }

        public Task EditarAgenda(int idAgenda, DateTime horario)
        {
            throw new NotImplementedException();
        }

        public Task RecusaAgendamento(int idConsulta, int idMedico)
        {
            throw new NotImplementedException();
        }

        public Task RemoverAgenda(int idAgenda)
        {
            throw new NotImplementedException();
        }
    }
}
