// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter first number:");
int firstNumber = int.Parse(Console.ReadLine());

if (firstNumber % 2 == 0)
{
  Console.WriteLine("число чётное");
}
else
{
  Console.WriteLine("число нечётное");
}

