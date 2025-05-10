using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculateController : ControllerBase
{
    [HttpGet(Name = "Add/{number}/{number2}")]
    public int Add(int number, int number2)
    {
        Calculator calculator = new Calculator();
        return calculator.Sum(number, number2);
    }
}
