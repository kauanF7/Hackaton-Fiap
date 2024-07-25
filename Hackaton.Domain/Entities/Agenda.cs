using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hackaton.Domain.Entities
{
    public class Agenda
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public char status { get; set; }
    }
}
