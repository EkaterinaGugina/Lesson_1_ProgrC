// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите два целых числа, и мы найдем их сумму и частное:");

Console.Write("A =");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("B =");

int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Их сумма равна:");

Console.WriteLine(numberA + numberB);

//double div = numberA / numberB;

Console.Write("Их частное равно:");

Console.WriteLine((double)numberA / numberB);
