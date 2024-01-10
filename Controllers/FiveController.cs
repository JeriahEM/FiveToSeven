using FiveToSeven.Services.Five;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;
[ApiController]
[Route("[controller]")]
public class FiveController
{
    private readonly IFiveServices _fiveServices;

    public FiveController(IFiveServices fiveServices)
    {
        _fiveServices = fiveServices;
    }
    [HttpGet]
    [Route("mabLib/{name}/{verbWithED}/{verb}/{timeFrame}/{place}/{adjWithLY}/{adj}/{noun}/{noun1}/{relationshipStatus}/{timeFrame1}/{verb1}/{noun2}/{food}/{bodyPart}/{noun3}/{verb2}/{name1}/{timeFrame2}")]
    public string pentagon(string name, string verbWithED, string verb, string timeFrame, string place, string adjWithLY, string adj, string noun, string noun1, string relationshipStatus, string timeFrame1, string verb1, string noun2, string food, string bodyPart, string noun3, string verb4, string verb2, string name1, string timeFrame2, string verb3)
    {
        return _fiveServices.madLib(name, verbWithED, verb, timeFrame, place, adjWithLY, adj, noun, noun1, relationshipStatus, timeFrame1, verb1, noun2, food, bodyPart, noun3, verb4, verb2, name1, timeFrame2, verb3);
    }
}