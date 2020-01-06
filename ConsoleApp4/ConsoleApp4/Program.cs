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

                Console.Write(militaryTime);
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
                if (((militaryTime[0] == '0') || (militaryTime[0] == '1') || (militaryTime[0] == '2')))//只有24小時制012的可以進入
                {
                    if (militaryTime[0] == '2')//2進入
                    {
                        if (((militaryTime[1] == '0') || (militaryTime[1] == '1') || (militaryTime[1] == '2') || (militaryTime[1] == '3')))//只有24制20、21、22、23進入，已解決
                        {
                            if (((militaryTime[3] == '0') || (militaryTime[3] == '1') || (militaryTime[3] == '2') || (militaryTime[3] == '3') || (militaryTime[3] == '4') || (militaryTime[3] == '5')))//只有十位數的0~5分鐘進入
                            {
                                if (((militaryTime[4] == '0') || (militaryTime[4] == '1') || (militaryTime[4] == '2') || (militaryTime[4] == '3') || (militaryTime[4] == '4') || (militaryTime[4] == '5') || (militaryTime[4] == '6') || (militaryTime[4] == '7') || (militaryTime[4] == '8') || (militaryTime[4] == '9')))//只有個位數的0~9分鐘進入
                                {
                                    if (militaryTime[1] == '0')
                                    {
                                        Console.WriteLine("08" + ":" + militaryTime[3] + militaryTime[4] + "PM");
                                    }
                                    if (militaryTime[1] == '1')
                                    {
                                        Console.WriteLine("09" + ":" + militaryTime[3] + militaryTime[4] + "PM");
                                    }
                                    if (militaryTime[1] == '2')
                                    {
                                        Console.WriteLine("10" + ":" + militaryTime[3] + militaryTime[4] + "PM");
                                    }
                                    if (militaryTime[1] == '3')
                                    {
                                        Console.WriteLine("11" + ":" + militaryTime[3] + militaryTime[4] + "PM");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("error");
                                }
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    else if (militaryTime[0] == '1')//1進入
                    {
                        if (((militaryTime[1] == '0') || (militaryTime[1] == '1') || (militaryTime[1] == '2')))//只有10、11、12進入，已解決
                        {
                            if (((militaryTime[3] == '0') || (militaryTime[3] == '1') || (militaryTime[3] == '2') || (militaryTime[3] == '3') || (militaryTime[3] == '4') || (militaryTime[3] == '5')))//只有十位數的0~5分鐘進入
                            {
                                if (((militaryTime[4] == '0') || (militaryTime[4] == '1') || (militaryTime[4] == '2') || (militaryTime[4] == '3') || (militaryTime[4] == '4') || (militaryTime[4] == '5') || (militaryTime[4] == '6') || (militaryTime[4] == '7') || (militaryTime[4] == '8') || (militaryTime[4] == '9')))//只有個位數的0~9分鐘進入
                                {
                                    Console.WriteLine(militaryTime + "AM");
                                }
                                else
                                {
                                    Console.WriteLine("error");
                                }
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                        }
                        else if ((militaryTime[1] == '3') || (militaryTime[1] == '4') || (militaryTime[1] == '5') || (militaryTime[1] == '6') || (militaryTime[1] == '7') || (militaryTime[1] == '8') || (militaryTime[1] == '9'))//13~19進入，已解決
                        {
                            if (((militaryTime[3] == '0') || (militaryTime[3] == '1') || (militaryTime[3] == '2') || (militaryTime[3] == '3') || (militaryTime[3] == '4') || (militaryTime[3] == '5')))//只有十位數的0~5分鐘進入
                            {
                                if (((militaryTime[4] == '0') || (militaryTime[4] == '1') || (militaryTime[4] == '2') || (militaryTime[4] == '3') || (militaryTime[4] == '4') || (militaryTime[4] == '5') || (militaryTime[4] == '6') || (militaryTime[4] == '7') || (militaryTime[4] == '8') || (militaryTime[4] == '9')))//只有個位數的0~9分鐘進入
                                {
                                    int a = (int)militaryTime[0];
                                    int b = (int)militaryTime[1];
                                    a = 0;
                                    if (b == 51)
                                    {
                                        b = 51 - 50;
                                    }
                                    if (b == 52)
                                    {
                                        b = 52 - 50;
                                    }
                                    if (b == 53)
                                    {
                                        b = 53 - 50;
                                    }
                                    if (b == 54)
                                    {
                                        b = 54 - 50;
                                    }
                                    if (b == 55)
                                    {
                                        b = 55 - 50;
                                    }
                                    if (b == 56)
                                    {
                                        b = 56 - 50;
                                    }
                                    if (b == 57)
                                    {
                                        b = 57 - 50;
                                    }
                                    Console.WriteLine(a + b + ":" + militaryTime[3] + militaryTime[4] + "PM");
                                }
                                else
                                {
                                    Console.WriteLine("error");
                                }
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    else if ((militaryTime[0] == '0'))//0進入，寫好了
                    {
                        if (((militaryTime[1] == '0') || (militaryTime[1] == '1') || (militaryTime[1] == '2') || (militaryTime[1] == '3') || (militaryTime[1] == '4') || (militaryTime[1] == '5') || (militaryTime[1] == '6') || (militaryTime[1] == '7') || (militaryTime[1] == '8') || (militaryTime[1] == '9')))
                        {
                            if (((militaryTime[3] == '0') || (militaryTime[3] == '1') || (militaryTime[3] == '2') || (militaryTime[3] == '3') || (militaryTime[3] == '4') || (militaryTime[3] == '5')))//只有十位數的0~5分鐘進入
                            {
                                if (((militaryTime[4] == '0') || (militaryTime[4] == '1') || (militaryTime[4] == '2') || (militaryTime[4] == '3') || (militaryTime[4] == '4') || (militaryTime[4] == '5') || (militaryTime[4] == '6') || (militaryTime[4] == '7') || (militaryTime[4] == '8') || (militaryTime[4] == '9')))//只有個位數的0~9分鐘進入
                                {
                                    Console.WriteLine(militaryTime + "AM");
                                }
                                else
                                {
                                    Console.WriteLine("error");
                                }
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            return "";
        }
    }
}
