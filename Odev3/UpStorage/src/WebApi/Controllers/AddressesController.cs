using Application.Features.Addresses.Commands.Add;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class AddressesController:ApiControllerBase 
{
    [HttpPost("AddAddresses")]
    public async Task<IActionResult> AddAddressesAsync(AddressAddCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
    
}