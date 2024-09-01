using AcademiaPro.Application.Features.Classes.Requests.Commands;
using AcademiaPro.Application.Features.Classes.Requests.Queries;
using AcademiaPro.Contracts.Classes;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AcademiaPro.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ClassesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClassesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll() 
        {
            var levels = await _mediator.Send(new GetClassesQuery());
            return Ok(levels);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetClassById(int id)
        {
            var level = await _mediator.Send(new GetClassByIdQuery() { Id = id});
            return Ok(level);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody]LevelDto command)
        {
            var result = await _mediator.Send(new CreateClassCommand { Level = command});
            
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, [FromBody]LevelDto levelDto)
        {
            if(id != levelDto.LevelId)
            {
                return BadRequest(levelDto);
            }
            await _mediator.Send(new UpdateClassCommand() {Id = id, LevelDto = levelDto});
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteClassCommand() { Id = id});
            return Ok();
        }
    }
}
