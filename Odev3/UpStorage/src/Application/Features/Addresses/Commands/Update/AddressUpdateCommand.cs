using Domain.Common;
using Domain.Enums;
using MediatR;

namespace Application.Features.Addresses.Commands.Update;

public class AddressUpdateCommand:IRequest<Response<int>>
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    public string District { get; set; }
    
    public string PostCode { get; set; }

    public string AddressLine1 { get; set; }
    
    public string? AddressLine2 { get; set; }

    public AddressType AddressType { get; set; }
}