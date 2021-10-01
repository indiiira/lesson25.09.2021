using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1,2,3");
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число");
            int date = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                if (date > 0 && date < 366)
                {
                    DateTime Time = new DateTime(year, 1, 1);
                    Time = Time.AddDays(date - 1);
                    Console.WriteLine($"Этот день соотвествует - {Time.Day} {Time.Month} {year} високосный год ");
                }
                else
                {
                    Console.WriteLine("Введите число от 1 до 366!");
                }
            }
            else
            {
                if (date > 0 && date < 366)
                { 
                    DateTime Time = new DateTime(year, 1, 1);
                Time = Time.AddDays(date - 1);
                Console.WriteLine($"Этот день соотвествует - {Time.Day} {Time.Month} {year} не високосный год");
                }
                 else
                {
                    Console.WriteLine("Введите число от 1 до 365!");
                }
            } 

            Console.ReadKey();
            
        }
        }
        
    }

