using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //объект Random для генерации случайных чисел
            Random random = new Random();

            // Сгенерировать случайное целое число в диапазоне от 0 до 100
            int randomNumber = random.Next(0, 101);

            Console.WriteLine($"Случайное целое число: {randomNumber}");
        }
    }
}
