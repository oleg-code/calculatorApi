using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CalculatorController : ControllerBase
	{
		private CalculatorService calculatorService;

		public CalculatorController(CalculatorService calculatorService)
		{
			this.calculatorService = calculatorService;
		}

		[HttpGet]
		public ActionResult<double> PerformOperation(double firstNumber, double secondNumber, char operation)
		{
			try
			{
				double result = calculatorService.Calculate(firstNumber, secondNumber, operation);
				return result;
			}
			catch (ArgumentException ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost]
		public ActionResult<double> PerformOperation([FromBody] OperationRequest request)
		{
			try
			{
				double result = calculatorService.Calculate(request.FirstNumber, request.SecondNumber, request.Operation);
				return result;
			}
			catch (ArgumentException ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}


