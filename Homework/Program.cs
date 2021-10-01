using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
  
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1.1");
            Console.WriteLine("Введите число");
            double n = Convert.ToDouble(Console.ReadLine());
            if (n < 0)
            {
                n = -n;
            }
            Console.WriteLine(n);
            

            Console.WriteLine("Задание 1.2");
            Console.WriteLine("Введите первое число");
            double nf = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double ns = double.Parse(Console.ReadLine());
            if (Math.Abs(nf) > Math.Abs(ns))
            {
                Console.WriteLine(nf/2);  
            }
            else
            { 
                Console.WriteLine(nf);
            }
            
            Console.WriteLine("Задание 1.3");
            Console.WriteLine("Впишите название животного");
            string animal = Console.ReadLine();
            string mouthSize = "wide";
            if (animal.ToLower() == "аллигатор")
            {
                mouthSize = "small";
            }
            Console.WriteLine(mouthSize);
            

            Console.WriteLine("Задание 1.4");
            Console.WriteLine("Введите строку");
                string line = Console.ReadLine();
                switch (line.ToLower())
                {
                    case "jabroni":
                        Console.WriteLine("Patron Tequila");
                        break;
                    case "school counselor":
                        Console.WriteLine("Anything with Alcohol");
                        break;
                    case "programmer":
                        Console.WriteLine("Hipster Craft Beer");
                        break;
                    case "bike gang member":
                        Console.WriteLine("Moonshine");
                        break;
                    case "Politician":
                        Console.WriteLine("Your tax dollars");
                        break;
                    case "rapper":
                        Console.WriteLine("Cristal");
                        break;
                    default:
                        Console.WriteLine("Beer");
                        break;
                }

            
            Console.WriteLine("Задание 1.5");
            Console.WriteLine("Введите строку");
            string str1 = Console.ReadLine();
            string str2 = "english";
            bool found = str1.ToLower().Contains(str2);
            Console.WriteLine(found);
           
            Console.WriteLine("Задание 2,1");
            double sum = 0;
            double a=1;
            int i;
            for (i = 1; i < 9; i++)
            {
                sum = sum +a;
                a = a/3;
            }
            Console.WriteLine(sum);
            

            Console.WriteLine("Задание 2.2");
            double S = 1;
            int count = 1;
            double home = 0;
            double work = 1;
            for (double r = 2; r < 101; r++)
            {
                S = S + (1 / r);

                if (count % 2 != 0)
                {
                    home = home + (1 / r);
                }
                else
                {
                    work = work + (1 / r);

                }
                 count++;
            }
            Console.WriteLine("Расстояние после 100 этапа " + S);
            Console.WriteLine("Расстояние от дома " + (work - home));


            Console.WriteLine("Задание 2.3");
            Random rand = new Random();
            List<int> junuary = new List<int>();
            List<int> march = new List<int>();
            for (i=0; i<32; i++)
            {
                junuary.Add(rand.Next(0, 50));
            }
            for (i = 0; i< 32; i++)
            {
                march.Add(rand.Next(0, 50));
            }
            int sumjunuary = junuary.Sum();
            int summarch = march.Sum();
            Console.WriteLine("Среднемесячное количество осадков января "+ (sumjunuary)/31);
            Console.WriteLine("Среднемесячная количество осадков марта " + (summarch) /31);


            Console.WriteLine("Задание 3.1");
            int x = 3;
            int y = 2;
            int c = 1;
            while (Math.Abs((float)x/y-(float)y/c) > 0.001)
            {
                int d = x;
                x = x + y;
                c = y;
                y = d;
            }
            Console.WriteLine($"Ответ: {x}/{y}");


            Console.WriteLine("Задание 3.2");
            int k=1;
            int N = int.Parse(Console.ReadLine());
            while (k * k < N)
            {
                k = k + 1;
            }
                int answer = k * k;
            Console.WriteLine(answer);

            Console.WriteLine("Задание 3.3");
            x = 100;
            while (x > 79)
            {
                Console.WriteLine(x);
                x = x - 1;
            }
            x = 100;
            do
            {
                Console.WriteLine(x);
                x = x - 1;
            }
            while (x > 79);

            Console.WriteLine("Задание 3.4");
            x = 0;
            int max = 0;
            for (i = 1; i < 5000; i++)
            {
                if ( i % 39 == 0)
                {
                    x = i;
                    if (x>max)
                    {
                        max = x;
                    }
                }
            }
            Console.WriteLine(max);


            Console.WriteLine("Задание 3.5a");
            x = 1;
            for (i = 0; i < 5; i++)
            {
                for (int j = 0; j < x; j++)
                {
                   Console.Write("5 ");
                }
                x = x + 1;
                Console.WriteLine();
            }
            Console.WriteLine("Задание 3.5b");
            x = 5;
            for (i = 5; i > 0; i--)
            {
                for (int j = 0; j < x; j++)
                {
                   Console.Write("1 ");
                }
                x = x-1;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
