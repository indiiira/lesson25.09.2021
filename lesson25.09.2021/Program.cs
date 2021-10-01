using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson25._09._2021
{
    class Program
    {
        public enum Week
        {
            Понедельник=1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        public enum Cards
        {
            Шестерка=6,
            Семерка,
            Восьмерка,
            Девятка,
            Десятка,
            Валет,
            Дама,
            Король,
            Туз
        }
        static void Main(string[] args)
        {
             Console.WriteLine("Задание 1");

             string number = Console.ReadLine();
             char[] numbeR = number.ToCharArray();
             Array.Reverse(numbeR);//переворачиваем цифры
             string finalnumber = new string(numbeR);
             if (number == finalnumber)
                {
                  Console.WriteLine("Является палиндромом");
                }
             else
                {
                   Console.WriteLine("Не вляется палиндромом");
                }

             Console.WriteLine("Задание 2");
             Console.WriteLine("Введите длину форточки");
             int a=int.Parse(Console.ReadLine());
             Console.WriteLine("Введите ширину форточки");
             int b = int.Parse(Console.ReadLine());
             Console.WriteLine("Введите диаметр головы");
             int d = int.Parse(Console.ReadLine());
             double  R = d / 2;
             int Sframe = (a-1) * (b-1);//зазор для головы
             double Scircle = Math.PI * R*R;
             if (Scircle<Sframe)
             {
                 Console.WriteLine("Ваня сможет просунуть голову");
             }
             else
             {
                 Console.WriteLine("Ваня не сможет просунуть голову");
             }


             Console.WriteLine("Задание 3");
             Console.WriteLine("Введите число от 1 до 7");
             int i = int.Parse(Console.ReadLine());
             Console.WriteLine((Week)i);

             Console.WriteLine("Задание 4");
             try
             { 
             int Nomer =int.Parse(Console.ReadLine());
              Console.WriteLine((Cards)Nomer);
             }
             catch (Exception)
             { 
                 Console.WriteLine("Такой масти нет!");
             }

            Console.WriteLine("Задание 5");
             double distance;
             double r = 6350;
             for (double Height  = 1; Height < 11; Height++)
             {
                 distance = Math.Sqrt((r + Height) * (r + Height) - (r * r));
                 Console.WriteLine($"Расстояние  {distance}  при высоте {Height} ");
             }

             Console.WriteLine("Задание 6");
             Console.WriteLine("Введите число от 1 до 9");
             int n = int.Parse(Console.ReadLine());
             for (int m=1; m<11; m++)
             {
                 Console.WriteLine(n * m);
             }

             Console.WriteLine("Задание 7");
             int c = 1; int k = 0; int s = 0;
             try
             {
                 while (c > 0)
                 {
                     c = int.Parse(Console.ReadLine());
                     if (c > 0)
                     {
                         s = s + c;
                         k = k + 1;
                     }
                 }
                 Console.WriteLine((double)s / k);
             }
             catch (System.FormatException)
             {
                 Console.WriteLine("Введите число!");
             }

             Console.WriteLine("Задание 8");
             int[] posledov = new int[10];
             for (int u = 0; u < 10; u++)
                 posledov[u] = int.Parse(Console.ReadLine());//заполняем массив
             int v = 0;
             for (int q = 0; q < 9; c++)
             {
                 if (posledov[q + 1] < posledov[q])
                 {
                     v = q + 1;
                     break;
                 }
             }

             if (v == 0)
             {
                 Console.WriteLine("Является упорядоченной");
             }
             else
             {
                Console.WriteLine("Не является упорядоченной, порядковый номер числа " + v);
             }

             Console.WriteLine("Задание 9");
             a = 1;
             b = 0;
             n = 0;
             while (a!=0)
             {
                 a = int.Parse(Console.ReadLine());
                 n = n + 1;
                 if (n % 3 != 0)
                     continue;
                     b = b + a; 
             }
             Console.WriteLine(b);
             

            Console.WriteLine("Задание 10");
            int num = 1;
            int sum = 0;
            link1:
            Console.WriteLine(sum);
            while (num != 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
                goto link1;     
            }
            Console.ReadKey();
        }

        
        }
    }



