using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Add/{a}/{b}")]
        public ActionResult<double> Add(double a, double b)
        {
            return a + b;
        }

        [HttpGet("Subtract/{a}/{b}")]
        public ActionResult<double> Subtract(double a, double b)
        {
            return a - b;
        }

        [HttpGet("Multiply/{a}/{b}")]
        public ActionResult<double> Multiply(double a, double b)
        {
            return a * b;
        }

        [HttpGet("Divide/{a}/{b}")]
        public ActionResult<double> Divide(double a, double b)
        {
            if (b == 0)
                return BadRequest("Division by zero is not allowed.");
            return a / b;
        }

        [HttpGet("Percentage/{a}/{b}")]
        public ActionResult<double> Percentage(double a, double b)
        {
            return (a / b) * 100;
        }
    }
}
