using FiveToSeven.Services.Seven;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;
[ApiController]
[Route("[controller]")]
public class SevenController
{
  private readonly ISevenServices _sevenServices;

  public SevenController(ISevenServices sevenServices)
  {
    _sevenServices = sevenServices;
  }
  [HttpGet]
  [Route("reverseIt/{userInput}")]

  public string heptagon(string userInput)
  {
    return _sevenServices.heptagon(userInput);
  }
}