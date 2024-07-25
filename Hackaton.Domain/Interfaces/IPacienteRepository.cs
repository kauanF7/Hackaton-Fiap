using Hackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Domain.Interfaces
{
    public interface IPacienteRepository
    {
        public Task<Paciente> ConsultarPaciente(int idPaciente);
        public Task<Agenda> ConsultarAgenda(int idConsulta);
        public Task Agendar(int idAgenda, int idPaciente);
    }
}
