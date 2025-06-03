using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAPI.Dtos
{
    public class EventDto
    {
        public int EventosId { get; set; }

        public string COD_EMPRESA { get; set; } = string.Empty;

        public string NOME { get; set; } = string.Empty;

        public string EVENTO_RESPONSAVEL { get; set; } = string.Empty;

        public int? EVENTO_TIPO { get; set; } 
    }
}