using FiveToSeven.Services.Eight;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;
[ApiController]
[Route("[controller]")]
public class EightController : ControllerBase
{
    private readonly IEightServices _eightServices;

    public EightController(IEightServices eightServices)
    {
        _eightServices = eightServices;
    }
[HttpGet]
[Route ("magicEight/{question}")]
public string EightBall()
    {
        return _eightServices.EightBall();
    }
}