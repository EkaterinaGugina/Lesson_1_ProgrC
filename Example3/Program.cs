// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите Ваше имя");

string UserName = Console.ReadLine();

if (UserName.ToLower() == "Маша")
   {
     Console.WriteLine("Ура! Это же Маша!");
   }
else
   {
     Console.Write("Привет, ");

     Console.Write(UserName);

     Console.Write("!");

   }        
       