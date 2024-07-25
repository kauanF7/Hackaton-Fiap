using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Domain.Entities
{
    public class Medico
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "nome")]
        public string Nome { get; set; }

        [Column("especialidade")]
        [Display(Name = "especialidade")]
        public string Especialidade { get; set; }

        [Column("crm")]
        [Display(Name = "crm")]
        public string Crm { get; set; }

        [Column("Agenda")]
        [Display(Name = "Agenda")]
        public List<Agenda> Agenda { get; set; }
    }
}
