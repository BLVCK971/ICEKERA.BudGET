using BudGET.Application.Features.Comptes.Commands.CreateCompte;
using BudGET.Application.Features.Comptes.Commands.DeleteCompte;
using BudGET.Application.Features.Comptes.Commands.UpdateCompte;
using BudGET.Application.Features.Comptes.Queries.GetCompteDetail;
using BudGET.Application.Features.Comptes.Queries.GetComptesList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BudGET.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompteController : ControllerBase
{
    private readonly IMediator _mediator;

    public CompteController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("all", Name = "GetAllComptes")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<CompteListVm>>> GetAllComptes()
    {
        var dtos = await _mediator.Send(new GetComptesListQuery());
        return Ok(dtos);
    }

    [HttpGet("{id}", Name = "GetCompteById")]
    public async Task<ActionResult<CompteDetailVm>> GetCompteById(Guid id)
    {
        var getCompteDetailQuery = new GetCompteDetailQuery() { CompteId = id };
        return Ok(await _mediator.Send(getCompteDetailQuery));
    }

    [HttpPost(Name = "AddCompte")]
    public async Task<ActionResult<CreateCompteCommandResponse>> Create([FromBody] CreateCompteCommand createCompteCommand)
    {
        var response = await _mediator.Send(createCompteCommand);
        return Ok(response);
    }

    [HttpPut(Name = "UpdateCompte")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Update([FromBody] UpdateCompteCommand updateCompteCommand)
    {
        await _mediator.Send(updateCompteCommand);
        return NoContent();
    }

    [HttpDelete("{id}", Name = "DeleteCompte")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(Guid id)
    {
        var deleteCompteCommand = new DeleteCompteCommand() { Id = id };
        await _mediator.Send(deleteCompteCommand);
        return NoContent();
    }
}