using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();

            switch (month)
            {
                case "yanvar":
                case "mart":
                case "may":
                case "iyul":
                case "avgust":
                case "oktyabr":
                case "dekabr":
                    Console.WriteLine(31);
                        break;
                case "aprel":
                case "iyun":
                case "sentyabr":
                case "noyabr":
                    Console.WriteLine(30);
                    break;
                case "evral":
                    Console.WriteLine(28);
                    break;

                default:
                    Console.WriteLine("Bele Bir ay yoxdur");
                    break;


            }

        }
    }
}
