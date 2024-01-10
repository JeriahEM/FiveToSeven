using FiveToSeven.Services.BSeven;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;
[ApiController]
[Route("[controller]")]
public class BSevenController
{
    private readonly IBSevenServices _bSevenServices;

    public BSevenController(IBSevenServices bSevenServices)
    {
        _bSevenServices = bSevenServices;
    }
    [HttpGet]
    [Route("reverseit/{userInput}")]
    public string seven(string userInput)
    {
        return _bSevenServices.seven(userInput);
    }
}
