using BudGET.Application.Features.Objectifs.Commands.CreateObjectif;
using BudGET.Application.Features.Objectifs.Commands.DeleteObjectif;
using BudGET.Application.Features.Objectifs.Commands.UpdateObjectif;
using BudGET.Application.Features.Objectifs.Queries.GetObjectifDetail;
using BudGET.Application.Features.Objectifs.Queries.GetObjectifsList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BudGET.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ObjectifController : ControllerBase
{
    private readonly IMediator _mediator;

    public ObjectifController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("all", Name = "GetAllObjectifs")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<ObjectifListVm>>> GetAllObjectifs()
    {
        var dtos = await _mediator.Send(new GetObjectifsListQuery());
        return Ok(dtos);
    }

    [HttpGet("{id}", Name = "GetObjectifById")]
    public async Task<ActionResult<ObjectifDetailVm>> GetObjectifById(Guid id)
    {
        var getObjectifDetailQuery = new GetObjectifDetailQuery() { ObjectifId = id };
        return Ok(await _mediator.Send(getObjectifDetailQuery));
    }

    [HttpPost(Name = "AddObjectif")]
    public async Task<ActionResult<CreateObjectifCommandResponse>> Create([FromBody] CreateObjectifCommand createObjectifCommand)
    {
        var response = await _mediator.Send(createObjectifCommand);
        return Ok(response);
    }

    [HttpPut(Name = "UpdateObjectif")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Update([FromBody] UpdateObjectifCommand updateObjectifCommand)
    {
        await _mediator.Send(updateObjectifCommand);
        return NoContent();
    }

    [HttpDelete("{id}", Name = "DeleteObjectif")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(Guid id)
    {
        var deleteObjectifCommand = new DeleteObjectifCommand() { Id = id };
        await _mediator.Send(deleteObjectifCommand);
        return NoContent();
    }
}
