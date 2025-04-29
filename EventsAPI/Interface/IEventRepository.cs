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
        Task<List<Event>> GetAllEventsAsync();
        Task<Event> GetEventByIdAsync(int id);
        Task<Event> CreateEventAsync(Event eventModel);
        Task<List<Event>> GetEventByClientNameAsync(string name);
        Task<Event> UpdateEventAsync(Event eventModel);
        Task<Event?> DeleteEventAsync(int id);
    }
}