using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string militaryTime = Console.ReadLine();
                militaryTime = MilitaryTimeToRegularTime(militaryTime);

                Console.WriteLine(militaryTime);
            }
        }


        public static string MilitaryTimeToRegularTime(string militaryTime)
        {
            
            if (((militaryTime.Length < 5) || (militaryTime.Length > 5) || (militaryTime[2] != ':')))//去除掉大於小於5字元和不是:的
            {
                Console.WriteLine("error");

            }
            else
            {
                if (((militaryTime[0] == 0) || (militaryTime[0] ==1) || (militaryTime[0] == 2)))//只有24小時制012的可以進入
                {
                    if (militaryTime[0] == 2)//1進入
                    {
                        if (((militaryTime[1] == 0) || (militaryTime[1] == 1) || (militaryTime[1] == 2) || (militaryTime[1] == 3)))
                        {

                        }
                    }else if (militaryTime[0] == 1)//2進入
                    {

                    }
                    else//0進入
                    {

                    }
    {

    }
                    
                }
                else
                {
                    Console.WriteLine("error");
                }
                
            }


            return militaryTime;
        }
    }
}
