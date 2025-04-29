using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsAPI.Dtos;
using EventsAPI.Interface;
using EventsAPI.Mappers;
using EventsAPI.Models;
using EventsAPI.Repository;
using EventsAPI.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventsAPI.Controllers
{
    [Route("api/Events")]
    public class EventsController : ControllerBase
    {
        private readonly EventService _eventService;
        public EventsController(EventService eventService)
        {
            _eventService = eventService;
        }
        

        [HttpGet]
        public async Task<IActionResult> FindAllEvents()
        {
            var events = await _eventService.GetAllEventsAsync();
            return Ok(events);
        }

        [HttpGet("FindBy/{id}")]
        public async Task<IActionResult> FindById([FromRoute] int id)
        {
            var eventItem = await _eventService.GetEventByIdAsync(id);
            if (eventItem == null)
            {
                return NotFound();
            }
            return Ok(eventItem.ToEventDto());
        }

        [HttpGet("FindByClient/{name}")]
        public async Task<IActionResult> FindByClientName([FromRoute] string name)
        {
            var eventItem = await _eventService.GetEventByClientNameAsync(name);
            if (eventItem == null)
            {
                return NotFound();
            }
            return Ok(eventItem);
        }

        [HttpGet("Count")]
        public async Task<IActionResult> CountAllEvents()
        {
            var events = await _eventService.CountAllEvents();
            return Ok(events);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateEventRequestDto eventDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
                
            var eventModel = eventDto.ToEventFromCreateDTO();

            if (eventModel == null)
            {
                return BadRequest("Evento não pode ser nulo");
            }
            await _eventService.CreateEventAsync(eventModel);
            return CreatedAtAction(nameof(FindById), new { id = eventModel.Id }, eventModel.ToEventDto());
        }

        [HttpPut]
        [Route("Update/{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateEventRequestDto eventDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var eventModel = await _eventService.UpdateEventAsync(id, eventDto);

            if (eventModel == null)
            {
                return NotFound();
            }
            return Ok(eventModel.ToEventDto());
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var eventModel = await _eventService.DeleteEventAsync(id);

            if (eventModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}