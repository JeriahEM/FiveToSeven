using Microsoft.AspNetCore.Mvc;
using FiveToSeven.Services.Mini;
namespace FiveToSeven.Controllers;
[ApiController]
[Route("[controller]")]
    public class TwoToFour : ControllerBase
    {
    private readonly ITwoToFour _twoToFour;

    public TwoToFour(ITwoToFour TwoToFour)
        {
        _twoToFour = TwoToFour;
    }
        [HttpGet]
        [Route("PullNum/{num}/{num1}")]
        //this is a string function which is trying to return a string, it is taking in a parameter that is a string
        public string PullNum(int num, int num1)
        {
            return _twoToFour.PullNum(num, num1);
        }
    }