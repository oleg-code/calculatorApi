public class CalculatorService
{
	public double Calculate(double firstNumber, double secondNumber, char operation)
	{
		double result = 0;

		switch (operation)
		{
			case '+':
				result = AddNumbers(firstNumber, secondNumber);
				break;

			case '-':
				result = SubtractNumbers(firstNumber, secondNumber);
				break;

			case '*':
				result = MultiplyNumbers(firstNumber, secondNumber);
				break;

			case '/':
				result = DivideNumbers(firstNumber, secondNumber);
				break;

			default:
				throw new ArgumentException("Invalid operator");
		}

		return result;
	}

	private double AddNumbers(double num1, double num2)
	{
		return num1 + num2;
	}

	private double SubtractNumbers(double num1, double num2)
	{
		return num1 - num2;
	}

	private double MultiplyNumbers(double num1, double num2)
	{
		return num1 * num2;
	}

	private double DivideNumbers(double num1, double num2)
	{
		return num1 / num2;
	}
}
