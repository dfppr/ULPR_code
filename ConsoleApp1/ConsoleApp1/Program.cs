using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razrabotka_algoritmov
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK_1
            /*
            Console.Write("Введите сторону: ");
            int a = int.Parse(Console.ReadLine());
            int V = a * a * a;
            int S = a * a * 4;
            Console.WriteLine("Объём куба равен: {0}", V);
            Console.WriteLine("Площадь боковой поверхности равна: {0}", S);
            Console.ReadKey();            */


            //TASK_2
            /*
            double x = Convert.ToDouble(Console.ReadLine()), y =
            Convert.ToDouble(Console.ReadLine());
            var sum = (x + y) / 2, proizv = (x * y) * 2;
            if (x == y)
            {
                Console.Write("X не может быть равен Y");
                return;
            }
            if (x < y)
            {
                x = sum;
                y = proizv;
            }
            else
            {
                x = proizv;
                y = sum;
            }
            Console.WriteLine("X = {0}, Y = {1}", x, y);
            Console.ReadKey();
             */


            //TASK_3
            /*
                int[] MyArray = new int[5];
                for (int i = 0; i < MyArray.Length; i++)
                {
                    MyArray[i] = Convert.ToInt32(Console.ReadLine());
                }
                int count = 0;
                for (int i = 0; i < MyArray.Length; i++)
                {
                    if ((MyArray[i] / 3 == 0) && (MyArray[i] / 7 != 0))
                        count = count + 1;
                }
                Console.WriteLine(count);
                Console.ReadKey();
            */


            //TASK_4
            /*
            Console.Write("Введите число: ");
            int x = int.Parse(Console.ReadLine());
            int chet = 0;
            int nechet = 0;
            while (x != 0)
            {
                if ((x % 10) % 2 == 0)
                {
                    chet++;
                }
                else nechet++;
                x = x / 10;
            }
            Console.WriteLine("Количество четных цифр: {0}", chet);
            Console.WriteLine("Количество четных цифр: {0}", nechet);
            Console.ReadKey();            */


            //TASK_5
            /*
            Console.WriteLine("Введите последовательность чисел через пробел: ");
            var array = Console.ReadLine().Split(' ');
            double sum = 0;
            int last = int.Parse(array[array.Length - 1]);
            for (int i = 0; i < array.Length; i++)
            {
                if (last >= 0)
                {
                    16
                Console.WriteLine("\nПоследний элемент массива не является отрицательным числом");
                break;
                }
                else
                    for (i = 0; i < array.Length - 1; i++)
                    {
                        int element = int.Parse(array[i]);
                        sum += element;
                    }
                Console.WriteLine("\nСреднее арифметическое: " + sum / i);
                Console.WriteLine(last);
            }
            Console.ReadKey();
            */


            //TASK_6
            /*
            int x = 0;
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 != 0)
                    x += i;
            }
            Console.WriteLine("Количество положительных нечетых чисел, меньших 50 равно: { 0}", x);
            */

        }
    }
}
