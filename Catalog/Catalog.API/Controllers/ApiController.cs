using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers;

[ApiVersion("1")]
[Microsoft.AspNetCore.Components.Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class ApiController : ControllerBase
{
    
}