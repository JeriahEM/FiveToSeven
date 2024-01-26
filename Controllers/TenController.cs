using FiveToSeven.Services.Ten;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;
[ApiController]
[Route("controller")]
public class TenController : ControllerBase

{
    private readonly ITenServices _tenServices;

    public TenController(ITenServices tenServices)
    {
        _tenServices = tenServices;
    }
[HttpGet]
[Route("restPickBurg")]
public string pickRestBurg()
{
return _tenServices.pickRestBurg();
}



[HttpGet]
[Route("restPickChick")]
public string pickRestChick()
{
return _tenServices.pickRestChick();
}

[HttpGet]
[Route("restPickPizza")]
public string pickRestPizza()
{
return _tenServices.pickRestPizza();
}
}