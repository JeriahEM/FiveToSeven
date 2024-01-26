using FiveToSeven.Services.Six;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;
[ApiController]
[Route("[controller]")]
public class SixController : ControllerBase
{
    private readonly ISixServices _sixServices;

    public SixController(ISixServices sixServices)
    {
        _sixServices = sixServices;
    }
    [HttpGet]
    [Route("oddOrEven/{input}")]
    public string hexagon(string input)
    {
        return _sixServices.oddOrEven(input);
    }
}