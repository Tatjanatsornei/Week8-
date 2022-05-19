using System;

namespace NameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение спрашивает у пользователя его имя и показывает имя задом наперед
            Console.WriteLine("Enter You name:");
            string Name = Console.ReadLine();
            for (int i = Name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(Name[i]);
            }
           
        }
    }
}
