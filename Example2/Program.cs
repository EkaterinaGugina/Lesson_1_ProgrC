// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите два целых числа, и мы найдем их сумму и частное:");

Console.Write("A =");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("B =");

int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Их сумма равна: {numberA + numberB}");

Console.WriteLine($"Их частное равно: {(double)numberA / numberB}");

Console.WriteLine("А теперь мы придумаем любые два числа и проделаем те же операции суммы и деления с ними:");

int number1 = new Random().Next(1,100);
Console.WriteLine(number1);

int number2 = new Random().Next(1, 100);
Console.WriteLine(number2);

Console.WriteLine($"Их сумма равна: {number1 + number2}");

Console.WriteLine($"Их частное равно: {(double)number1 / number2}");
