using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsAPI.Dtos;
using EventsAPI.Interface;
using EventsAPI.Models;

namespace EventsAPI.Service
{
    public class EventService
    {
        private readonly IEventRepository _eventRepository;
        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public async Task<List<Event>> GetAllEventsAsync()
        {
            return await _eventRepository.GetAllEventsAsync();
        }
        public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _eventRepository.GetEventByIdAsync(id);
        }
        public async Task<List<Event>> GetEventByClientNameAsync(string name)
        {
            return await _eventRepository.GetEventByClientNameAsync(name);
        }
        public async Task<int> CountAllEvents()
        {
            var result = await _eventRepository.GetAllEventsAsync();
            return result.Count;
        }
        public async Task<Event> CreateEventAsync(Event eventModel)
        {
            return await _eventRepository.CreateEventAsync(eventModel);
        }
        public async Task<Event> UpdateEventAsync(int id, UpdateEventRequestDto eventDto)
        {
            var existingEvent = await _eventRepository.GetEventByIdAsync(id);
            if (existingEvent == null)  throw new Exception("Nenhum evento foi encontrado");

            existingEvent.CompanyId = eventDto.CompanyId;
            existingEvent.EventClientName = eventDto.EventClientName;
            existingEvent.EventResponsible = eventDto.EventResponsible;
            existingEvent.EventType = eventDto.EventType;

            return await _eventRepository.UpdateEventAsync(existingEvent);
        }
        public async Task<Event?> DeleteEventAsync(int id)
        {
            return await _eventRepository.DeleteEventAsync(id);
        }
    }
}