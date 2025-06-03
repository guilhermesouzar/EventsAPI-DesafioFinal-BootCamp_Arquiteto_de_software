using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsAPI.Dtos;
using EventsAPI.Interface;
using EventsAPI.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;

namespace EventsAPI.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly HubDealerContext _hubDealerContext;
        public EventRepository(ApplicationDBContext dbContext, HubDealerContext hubDealerContext)
        {
            _dbContext = dbContext;
            _hubDealerContext = hubDealerContext;
        }

        public Task<List<Evento>> GetAllEventsAsync()
        {
            return _hubDealerContext.Eventos.ToListAsync();        
        }

        public async Task<Evento> GetEventByIdAsync(int id)
        {
            var eventModel = await _hubDealerContext.Eventos.FirstOrDefaultAsync(e => e.EventosId == id);
            if (eventModel == null) throw new Exception("Este evento não foi encontrado");
            return eventModel;
        }

        public async Task<List<Evento>> GetEventByClientNameAsync(string name)
        {
            var eventsModel = await _hubDealerContext.Eventos.Where(e => e.NOME == name).ToListAsync();
            if (eventsModel.Count == 0) throw new Exception("Nenhum evento foi encontrado");
            return eventsModel;
        }

        public async Task<List<Evento>> GetEventByResponsibleNameAsync(string name)
        {
            var eventsModel = await _hubDealerContext.Eventos.Where(e => e.EVENTO_RESPONSAVEL == name).ToListAsync();
            if (eventsModel.Count == 0) throw new Exception("Nenhum evento foi encontrado");
            return eventsModel;
        }
        public async Task<List<Evento>> GetEventByDateAndResponsibleNameAsync(DateTime initDate, DateTime endDate, string name)
        {
            var eventsModel = await _hubDealerContext.Eventos
                .Where(e =>
                    e.EVENTO_RESPONSAVEL == name &&
                    e.EVENTO_DATA >= initDate &&
                    e.EVENTO_DATA <= endDate
                )
                .ToListAsync();

            if (eventsModel.Count == 0)
                throw new Exception("Nenhum evento foi encontrado");

            return eventsModel;
        }


        public async Task<Evento> CreateEventAsync(Evento eventModel)
        {
            await _hubDealerContext.Eventos.AddAsync(eventModel);
            await _hubDealerContext.SaveChangesAsync();
            return eventModel;
        }

        
        public async Task<Evento> UpdateEventAsync(Evento eventModel)
        {
            _hubDealerContext.Eventos.Update(eventModel);
            await _hubDealerContext.SaveChangesAsync();
            return eventModel;
        }
        public async Task<Evento?> DeleteEventAsync(int id)
        {
            var eventModel = await _hubDealerContext.Eventos.FirstOrDefaultAsync(e => e.EventosId == id);
            if (eventModel == null) return null;

            _hubDealerContext.Eventos.Remove(eventModel);
            await _hubDealerContext.SaveChangesAsync();
            return eventModel;
        }

    
    }
}