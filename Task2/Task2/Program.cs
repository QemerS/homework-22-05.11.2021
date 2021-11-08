using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = Console.ReadLine();
            int hecm = Convert.ToInt32(Console.ReadLine());
            int yagliliq = Convert.ToInt32(Console.ReadLine());
            Milk array = new Milk(ad,hecm,yagliliq);
            
        }
    }
}
