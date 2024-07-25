using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Domain.Entities
{
    public class Paciente
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "nome")]
        public string Nome { get; set; }

        [Column("cpf")]
        [Display(Name = "cpf")]
        public string CPF { get; set; }

        [Column("email")]
        [Display(Name = "email")]
        public string Email { get; set; }
    }
}
