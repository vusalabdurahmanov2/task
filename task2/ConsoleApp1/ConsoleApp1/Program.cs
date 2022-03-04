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
                case "Yanvar":
                case "Mart":
                case "may":
                case "Iyul":
                case "Avgust":
                case "Oktyabr":
                case "Dekabr":
                    Console.WriteLine(31);
                        break;
                case "Aprel":
                case "Iyun":
                case "Sentyabr":
                case "Noyabr":
                    Console.WriteLine(30);
                    break;
                case "Fevral":
                    Console.WriteLine(28);
                    break;

                default:
                    Console.WriteLine("Bele Bir ay yoxdur");
                    break;



            }

        }
    }
}
