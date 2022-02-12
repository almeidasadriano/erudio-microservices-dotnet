using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReatWithASPNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController (ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {

            }

            return BadRequest("Invalid Input");
         }

        private bool IsNumeric(string firstNumber)
        {
            throw new NotImplementedException();
        }
    }
}
