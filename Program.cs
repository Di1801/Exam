using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_PPM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World");
            Console.ResetColor();
             RandomNumber();
            Console.ReadKey();
        }
    }
    public static void RandomNumber()
        {
            Random rand = new Random();
            int number = rand.Next(0, 100);
            Console.WriteLine(number);
        }
}
