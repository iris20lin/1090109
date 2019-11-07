using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int c, int d)
        {
            return c - d;
        }
        public int Fs(int g, int h)
        {
            int result = 0;
            if (h==0)
            {
                Console.WriteLine("ㄎㄎ");
            }
            else
            {
              result= g / h;
            }
            return result;
        }
            public int Yed(int q, int w)
        {
            return q * w;
        }

    }
}
