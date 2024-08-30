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
        public async Task<IActionResult> GetAll() 
        {
            var levels = await _mediator.Send(new GetClassesQuery());
            return Ok(levels);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetClassById(int id)
        {
            var level = await _mediator.Send(new GetClassByIdQuery() { Id = id});
            return Ok(level);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]ListLevelDto command)
        {
            var result = await _mediator.Send(new CreateClassCommand { Level = command});
            
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody]ListLevelDto levelDto)
        {
            if(id != levelDto.LevelId)
            {
                return BadRequest(levelDto);
            }
            await _mediator.Send(new UpdateClassCommand() {Id = id, LevelDto = levelDto});
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteClassCommand() { Id = id});
            return Ok();
        }
    }
}
