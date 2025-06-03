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
        public static EventDto ToEventDto(this Evento eventModel)
        {
            return new EventDto
            {
                EventosId = eventModel.EventosId,
                COD_EMPRESA = eventModel.COD_EMPRESA,
                NOME = eventModel.NOME,
                EVENTO_RESPONSAVEL = eventModel.EVENTO_RESPONSAVEL,
                EVENTO_TIPO = eventModel.EVENTO_TIPO
            };
        }

        public static Evento ToEventFromCreateDTO(this CreateEventRequestDto eventDto)
        {
            return new Evento
            {
                COD_EMPRESA = eventDto.COD_EMPRESA,
                NOME = eventDto.NOME,
                EVENTO_RESPONSAVEL = eventDto.EVENTO_RESPONSAVEL,
                EVENTO_TIPO = eventDto.EVENTO_TIPO
            };
            // {
            //     CompanyId = eventDto.CompanyId,
            //     EventClientName = eventDto.EventClientName,
            //     EventResponsible = eventDto.EventResponsible,
            //     EventType = eventDto.EventType
            // };
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