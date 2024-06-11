using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //объект Random для генерации случайных чисел
            Random random = new Random();

            int MinValue = 0, MaxValue = 0;

            Console.WriteLine("Введите минимальное значение");
            try 
            {
                MinValue = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Введено неверное значение");
                return;
            }
            Console.WriteLine("Введите максимальное значение");
            try 
            {
                MaxValue = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Введено неверное значение");
                return;
            }
            int randomNumber = random.Next(MinValue, MaxValue);
            Console.WriteLine($"Случайное целое число: {randomNumber}");


        }
    } 
}
