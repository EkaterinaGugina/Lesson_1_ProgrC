// See https://aka.ms/new-console-template for more information
Console.WriteLine("Решим залачу - найти вес самой тяжелой гири.");
Console.WriteLine("Пусть вес ваших гирь: 1, 2, 6, 8, 5");
int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 5;
int max = a;
if ( b > max) max = b;
if ( c > max) max = c;
if ( d > max) max = d;
if ( e > max) max = e;
Console.WriteLine($"max = {max}");


//static void Main(string[] args)
       // {
           // Console.WriteLine("Введите размерность массива:");
            //int i, n = Convert.ToInt32(Console.ReadLine());
            //int[] mas = new int[n];
           // Console.WriteLine("Введите массив:");
          //  string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
           // for (i = 0; i < (n < str.Length ? n : str.Length); ++i)
           //     mas[i] = Convert.ToInt32(str[i]);
          //  Console.WriteLine("Введенный массив:");
           // for (i = 0; i < n; ++i)
          //      Console.Write("{0} ", mas[i]);
          //  Console.ReadLine();
        //} 
