using Application.Features.Addresses.Commands.Add;
using Application.Features.Addresses.Commands.Delete;
using Application.Features.Addresses.Commands.HardDelete;
using Application.Features.Addresses.Queries.GetAll;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class AddressesController:ApiControllerBase 
{
    [HttpPost()]
    public async Task<IActionResult> AddAddressesAsync(AddressAddCommand command)
    {
        return Ok(await Mediator.Send(command));
    }

    [HttpGet]

    public async Task<IActionResult> GetAllAsync(int id)
    {
        return Ok(Mediator.Send(new AddressGetAllQuery(id, null)));
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        return Ok(Mediator.Send(new AddressDeleteCommand{Id = id}));
    }
    
    
    [HttpDelete("HardDelete")]
    public async Task<IActionResult> HardDeleteAsync(int id)
    {
        return Ok(Mediator.Send(new AddressHardDeleteCommand{Id = id}));
    }
    

}