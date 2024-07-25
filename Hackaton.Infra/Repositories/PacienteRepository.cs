using Hackaton.Domain.Entities;
using Hackaton.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Infra.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        public Task Agendar(int idAgenda, int idPaciente)
        {
            throw new NotImplementedException();
        }

        public Task<Agenda> ConsultarAgenda(int idConsulta)
        {
            throw new NotImplementedException();
        }

        public Task<Paciente> ConsultarPaciente(int idPaciente)
        {
            throw new NotImplementedException();
        }
    }
}
