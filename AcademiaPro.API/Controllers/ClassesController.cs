using AcademiaPro.Application.Requests.Commands;
using AcademiaPro.Application.Requests.Queries;
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
        public async Task<ActionResult<IEnumerable<LevelDto>>> GetAll()
        {
            var levels = await _mediator.Send(new GetClassesQuery());
            return Ok(levels);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<LevelDto>> GetClassById(int id)
        {
            var level = await _mediator.Send(new GetClassByIdQuery() { Id = id});
            return Ok(level);
        }

        [HttpPost]
        public async Task<ActionResult<LevelDto>> Create([FromBody]CreateClassCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(int id, [FromBody]LevelDto levelDto)
        {
            if(id != levelDto.Id)
            {
                return BadRequest(levelDto);
            }
            await _mediator.Send(new UpdateClassCommand() {Id = id, LevelDto = levelDto});
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteClassCommand() { Id = id});
            return Ok();
        }
    }
}
