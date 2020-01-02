using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Decoder decoder = new Decoder();
            string url = decoder.sp();
            Console.WriteLine("url = " + url);

        }
    }
}
