using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAPI.Models
{
    public class Event
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string EventClientName { get; set; } = string.Empty;

        public string EventResponsible { get; set; } = string.Empty;

        public string EventType { get; set; } = string.Empty;
    }
}