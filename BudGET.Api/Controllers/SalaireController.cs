using BudGET.Application.Features.Salaires.Commands.CreateSalaire;
using BudGET.Application.Features.Salaires.Commands.DeleteSalaire;
using BudGET.Application.Features.Salaires.Commands.UpdateSalaire;
using BudGET.Application.Features.Salaires.Queries.GetSalaireDetail;
using BudGET.Application.Features.Salaires.Queries.GetSalairesList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BudGET.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SalaireController : ControllerBase
{
    private readonly IMediator _mediator;

    public SalaireController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("all", Name = "GetAllSalaires")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<SalaireListVm>>> GetAllSalaires()
    {
        var dtos = await _mediator.Send(new GetSalairesListQuery());
        return Ok(dtos);
    }

    [HttpGet("{id}", Name = "GetSalaireById")]
    public async Task<ActionResult<SalaireDetailVm>> GetSalaireById(Guid id)
    {
        var getSalaireDetailQuery = new GetSalaireDetailQuery() { Id = id };
        return Ok(await _mediator.Send(getSalaireDetailQuery));
    }

    [HttpPost(Name = "AddSalaire")]
    public async Task<ActionResult<CreateSalaireCommandResponse>> Create([FromBody] CreateSalaireCommand createSalaireCommand)
    {
        var response = await _mediator.Send(createSalaireCommand);
        return Ok(response);
    }

    [HttpPut(Name = "UpdateSalaire")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Update([FromBody] UpdateSalaireCommand updateSalaireCommand)
    {
        await _mediator.Send(updateSalaireCommand);
        return NoContent();
    }

    [HttpDelete("{id}", Name = "DeleteSalaire")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(Guid id)
    {
        var deleteSalaireCommand = new DeleteSalaireCommand() { Id = id };
        await _mediator.Send(deleteSalaireCommand);
        return NoContent();
    }
}