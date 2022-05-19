using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello"; //immutable

            //string updatehello = hello.Replace('e', '3');
            //updatehello = updatehello.replace('o', 'O');
            hello = hello.Replace('e', '3');
            hello = hello.Replace('o', 'O');
            Console.WriteLine(hello);
            //consoleWriteLine(hello);                       
        }
    }
}
