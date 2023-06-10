//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter first number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int secondNumber = int.Parse(Console.ReadLine());

int max = firstNumber > secondNumber? firstNumber : secondNumber;
int min = firstNumber < secondNumber? firstNumber : secondNumber;

Console.WriteLine($"max={max}, min={min}");
