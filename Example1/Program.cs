internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.Write("Текущая дата и время:   ");

        Console.WriteLine(DateTime.Now);

        Console.WriteLine("Введите Ваше имя");

        string UserName = Console.ReadLine();

        Console.Write($"Привет, {UserName}!");

    }
}