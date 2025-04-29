using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsAPI.Dtos;
using EventsAPI.Models;

namespace EventsAPI.Mappers
{
    public static class EventMappers
    {
        public static EventDto ToEventDto(this Event eventModel)
        {
            return new EventDto
            {
                Id = eventModel.Id,
                CompanyId = eventModel.CompanyId,
                EventClientName = eventModel.EventClientName,
                EventResponsible = eventModel.EventResponsible,
                EventType = eventModel.EventType
            };
        }

        public static Event ToEventFromCreateDTO(this CreateEventRequestDto eventDto)
        {
            return new Event
            {
                CompanyId = eventDto.CompanyId,
                EventClientName = eventDto.EventClientName,
                EventResponsible = eventDto.EventResponsible,
                EventType = eventDto.EventType
            };
        }
        // public static Event ToEventFromUpdateDTO(this UpdateEventRequestDto updateEventRequestDto)
        // {
        //     return new Event
        //     {
        //         CompanyId = updateEventRequestDto.CompanyId,
        //         EventClientName = updateEventRequestDto.EventClientName,
        //         EventResponsible = updateEventRequestDto.EventResponsible,
        //         EventType = updateEventRequestDto.EventType
        //     };
        // }
    }
}