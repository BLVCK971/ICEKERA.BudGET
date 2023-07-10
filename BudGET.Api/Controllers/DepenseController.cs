using BudGET.Application.Features.Depenses.Commands.CreateDepense;
using BudGET.Application.Features.Depenses.Commands.DeleteDepense;
using BudGET.Application.Features.Depenses.Commands.UpdateDepense;
using BudGET.Application.Features.Depenses.Queries.GetDepenseDetail;
using BudGET.Application.Features.Depenses.Queries.GetDepensesList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BudGET.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepenseController : ControllerBase
{
    private readonly IMediator _mediator;

    public DepenseController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("all", Name = "GetAllDepenses")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<DepenseListVm>>> GetAllDepenses()
    {
        var dtos = await _mediator.Send(new GetDepensesListQuery());
        return Ok(dtos);
    }

    [HttpGet("{id}", Name = "GetDepenseById")]
    public async Task<ActionResult<DepenseDetailVm>> GetDepenseById(Guid id)
    {
        var getDepenseDetailQuery = new GetDepenseDetailQuery() { DepenseId = id };
        return Ok(await _mediator.Send(getDepenseDetailQuery));
    }

    [HttpPost(Name = "AddDepense")]
    public async Task<ActionResult<CreateDepenseCommandResponse>> Create([FromBody] CreateDepenseCommand createDepenseCommand)
    {
        var response = await _mediator.Send(createDepenseCommand);
        return Ok(response);
    }

    [HttpPut(Name = "UpdateDepense")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Update([FromBody] UpdateDepenseCommand updateDepenseCommand)
    {
        await _mediator.Send(updateDepenseCommand);
        return NoContent();
    }

    [HttpDelete("{id}", Name = "DeleteDepense")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(Guid id)
    {
        var deleteDepenseCommand = new DeleteDepenseCommand() { Id = id };
        await _mediator.Send(deleteDepenseCommand);
        return NoContent();
    }
}