using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsAPI.Dtos;
using EventsAPI.Interface;
using EventsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EventsAPI.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public EventRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Event>> GetAllEventsAsync()
        {
            return _dbContext.Events.ToListAsync();        
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            var eventModel = await _dbContext.Events.FirstOrDefaultAsync(e => e.Id == id);
            if (eventModel == null) throw new Exception("Este evento não foi encontrado");
            return eventModel;
        }

        public async Task<List<Event>> GetEventByClientNameAsync(string name)
        {
            var eventsModel = await _dbContext.Events.Where(e => e.EventClientName == name).ToListAsync();
            if (eventsModel.Count == 0) throw new Exception("Nenhum evento foi encontrado");
            return eventsModel;
        }

        public async Task<Event> CreateEventAsync(Event eventModel)
        {
            await _dbContext.Events.AddAsync(eventModel);
            await _dbContext.SaveChangesAsync();
            return eventModel;
        }

        
        public async Task<Event> UpdateEventAsync(Event eventModel)
        {
            _dbContext.Events.Update(eventModel);
            await _dbContext.SaveChangesAsync();
            return eventModel;
        }
        public async Task<Event?> DeleteEventAsync(int id)
        {
            var eventModel = await _dbContext.Events.FirstOrDefaultAsync(e => e.Id == id);
            if (eventModel == null) return null;

            _dbContext.Events.Remove(eventModel);
            await _dbContext.SaveChangesAsync();
            return eventModel;
        }

    
    }
}