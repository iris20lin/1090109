using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            int s1 = game.Add(3, 5);
            int s2 = game.Sub(7, 2);
            int s3 = game.Fs(3, 0);
            int s4 = game.Yed(5, 4);
            Console.WriteLine("3+5=" + s1);
            Console.WriteLine("7-2=" + s2);
            Console.WriteLine("3/0=" + s3);
            Console.WriteLine("5*4=" + s4);
            Console.ReadKey();
        }
    }
}
