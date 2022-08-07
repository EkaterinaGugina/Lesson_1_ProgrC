// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите Ваше имя");

string username = Console.ReadLine();

if (username.ToLower() == "Маша")
   {
     Console.WriteLine("Ура! Это же Маша!");
   }
else
   {
     Console.Write("Привет, ");

     Console.Write(username);

     Console.Write("!");

   }        
       