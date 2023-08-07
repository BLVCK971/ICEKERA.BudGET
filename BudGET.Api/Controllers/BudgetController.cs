using BudGET.Application.Features.Budgets.Commands.CreateBudget;
using BudGET.Application.Features.Budgets.Commands.DeleteBudget;
using BudGET.Application.Features.Budgets.Commands.UpdateBudget;
using BudGET.Application.Features.Budgets.Queries.GetBudgetDetail;
using BudGET.Application.Features.Budgets.Queries.GetBudgetsList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BudGET.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BudgetController : ControllerBase
{
    private readonly IMediator _mediator;

    public BudgetController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("all", Name = "GetAllBudgets")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<BudgetListVm>>> GetAllBudgets()
    {
        var dtos = await _mediator.Send(new GetBudgetsListQuery());
        return Ok(dtos);
    }

    [HttpGet("{id}", Name = "GetBudgetById")]
    public async Task<ActionResult<BudgetDetailVm>> GetBudgetById(Guid id)
    {
        var getBudgetDetailQuery = new GetBudgetDetailQuery() { Id = id };
        return Ok(await _mediator.Send(getBudgetDetailQuery));
    }

    [HttpPost(Name = "AddBudget")]
    public async Task<ActionResult<CreateBudgetCommandResponse>> Create([FromBody] CreateBudgetCommand createBudgetCommand)
    {
        var response = await _mediator.Send(createBudgetCommand);
        return Ok(response);
    }

    [HttpPut(Name = "UpdateBudget")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Update([FromBody] UpdateBudgetCommand updateBudgetCommand)
    {
        await _mediator.Send(updateBudgetCommand);
        return NoContent();
    }

    [HttpDelete("{id}", Name = "DeleteBudget")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(Guid id)
    {
        var deleteBudgetCommand = new DeleteBudgetCommand() { Id = id };
        await _mediator.Send(deleteBudgetCommand);
        return NoContent();
    }
}
