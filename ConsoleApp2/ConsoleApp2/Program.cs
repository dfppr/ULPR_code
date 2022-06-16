using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace zadaniya_bez_variantov
{


    class Program
    {
        static void Main(string[] args)
        {
            //TASK_1
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            var date = new DateTime(c, b, a);
            var startDate = new DateTime(c, 1, 1);
            Console.WriteLine("Сейчас {0}-й день в году", (date - startDate).Days + 1);
            if ((c % 4 == 0) && (c % 100 != 0) && (c % 400 == 0))
            {
                Console.WriteLine("Осталось {0} дней до конца года", 366 - (date - startDate).Days + 1);
            }
            Console.WriteLine("Осталось {0} дней до конца года", 365 - ((date - startDate).Days + 1));
            Console.ReadKey();
            */


            //TASK_2
            /*
            int c = 0;
            Console.WriteLine("Введите число, месяц и год: ");
            string day = Console.ReadLine();
            string month = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            DateTime today = DateTime.Parse($"{day}.{month}.{Convert.ToString(year)}");
            Console.WriteLine(today);
            int jYear = year;
            while (jYear > 0)
            {
                jYear = jYear - 160;
                c++;
            }
            today = today.AddDays(c);
            Console.WriteLine(today.ToShortDateString());
            Console.ReadKey();
            */


            //TASK_3
            /*
            Console.Write("Введите конечное число диапозона n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество попыток: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int value = rnd.Next(1, n);
            int i = 0;
            do
            {
                Console.WriteLine("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == value)
                {
                    Console.WriteLine("Вы угадали!");
                    break;
                }
                if (a < value) Console.WriteLine("Больше");
                if (a > value) Console.WriteLine("Меньше");
                i++;
            } while (i != k);
            Console.WriteLine();
            Console.WriteLine("Игра завершена!");
            */


            //TASK_4
            /*
            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(0, 99);
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.Write("\n");
            for (int a = array.Length - 1; a >= 0; a--)
            {
                int b = rand.Next(a);
                int c = array[a];
                array[a] = array[b];
                array[b] = c;
            }
            for (int a = 0; a < array.Length; a++) Console.Write(array[a] + " ");
            Console.ReadKey();
            */


            //TASK_5
            /*
           
                for (int i = 0; i < 100; i++)
                {
                    double R = RND();
                    Console.Write(R);
                    Console.Write(" ");
                }
                Console.ReadLine();
                Console.ReadKey();
            
        */
    }
}
    /* internal class Program
     {
         public static byte RND()
         {
             RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();
             byte[] randomNumber = new byte[1];
             Rand.GetBytes(randomNumber);
             return (randomNumber[0]);
         }
         */

}
