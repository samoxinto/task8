using System;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());

            string str = "";
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    str += i + " ";
                }
            }

            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
