using AcademiaPro.Application.Features.Classrooms.Requests.Commands;
using AcademiaPro.Application.Features.Classrooms.Requests.Queries;
using AcademiaPro.Contracts.Classrooms;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaPro.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ClassroomsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClassroomsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllClassrooms()
        {
            var result = await _mediator.Send(new GetClassroomsQuery());
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetClassroomById(int id)
        {
            var result = await _mediator.Send(new GetClassroomByIdQuery { Id = id });
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] ClassroomDto classroom)
        {
            var result = await _mediator.Send(new CreateClassroomCommand() { ClassroomDto = classroom });
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, [FromBody] ClassroomDto classroom)
        {
            if (id != classroom.ClassroomId)
            {
                return BadRequest();
            }

            await _mediator.Send(new UpdateClassroomCommand() { Id = id, ClassroomDto = classroom });
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteClassroomCommand() { Id = id });
            return NoContent();
        }
    }
}
