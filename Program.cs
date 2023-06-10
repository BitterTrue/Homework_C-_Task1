Console.WriteLine("Enter first number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int secondNumber = int.Parse(Console.ReadLine());
int max = firstNumber > secondNumber? firstNumber : secondNumber;
int min = firstNumber < secondNumber? firstNumber : secondNumber;
Console.WriteLine($"max={max}, min={min}");