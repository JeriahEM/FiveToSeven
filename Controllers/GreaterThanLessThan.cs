using Microsoft.AspNetCore.Mvc;
using FiveToSeven.Services.Mini;

namespace FiveToSeven.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterThanLessThan : ControllerBase
{
    private readonly IgreaterThanLessThan _greaterThanLessThan;

    public GreaterThanLessThan(IgreaterThanLessThan greaterThanLessThan)
    {
        _greaterThanLessThan = greaterThanLessThan;
    }
    [HttpGet]
    [Route("PullNum1/{num}/{num1}")]
    //this is a string function which is trying to return a string, it is taking in a parameter that is a string
    public string PullNum1(int num, int num1)
    {
       return _greaterThanLessThan.PullNum1(num, num1);

    }

}