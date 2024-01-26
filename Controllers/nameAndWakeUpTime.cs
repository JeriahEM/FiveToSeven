using Microsoft.AspNetCore.Mvc;
using FiveToSeven.Services.Mini;
namespace FiveToSeven.Controllers;
[ApiController]
[Route("[controller]")]
    public class nameAndWakeUpTime : ControllerBase
    {
    private readonly InameAndWakeUpTime _nameAndWakeUpTime;

    public nameAndWakeUpTime(InameAndWakeUpTime nameAndWakeUpTime)
        {
        _nameAndWakeUpTime = nameAndWakeUpTime;
    }

        [HttpGet]
        [Route("PullName/{userName}/{wakeUp}")]
        //this is a string function which is trying to return a string, it is taking in a parameter that is a string
        public string PullName(string userName, string wakeUp)
        {
           return  _nameAndWakeUpTime.PullName(userName, wakeUp);
        }
    }