using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsAPI.Dtos;
using EventsAPI.Models;

namespace EventsAPI.Interface
{
    public interface IEventRepository
    {
        Task<List<Evento>> GetAllEventsAsync();
        Task<Evento> GetEventByIdAsync(int id);
        Task<Evento> CreateEventAsync(Evento eventModel);
        Task<List<Evento>> GetEventByClientNameAsync(string name);
        Task<List<Evento>> GetEventByResponsibleNameAsync(string name);
        Task<List<Evento>> GetEventByDateAndResponsibleNameAsync(DateTime initDate, DateTime endDate, string name);
        Task<Evento> UpdateEventAsync(Evento eventModel);
        Task<Evento?> DeleteEventAsync(int id);
    }
}