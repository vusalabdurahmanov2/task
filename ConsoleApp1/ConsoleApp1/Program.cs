using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n-i daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m-i daxil edin: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            Console.Write("Neciye bolmek isteyirsiniz?: ");
            int x = Convert.ToInt32(Console.ReadLine());//Bolunen eded
            if (n < m)
            {
                for (int i = n; i <= m; i++)
                    if (i % x == 0 && i != 0)
                        counter++;
                       
                if (counter == 0)
                {
                    Console.WriteLine("Bolunen Yoxudur");
                }
                else
                {
                    Console.WriteLine(counter);
                }
                
            }
            else if(n==m){
                Console.WriteLine("Ededler beraberdiler");
            }
            else if(n>m)
            {            
                for (int i = m; i <= n; i++)
                    if (i % x == 0 && i != 0)
                        counter++;
                if (counter == 0)
                {
                    Console.WriteLine("Bolunen Yoxudur");
                }
                else
                {
                    Console.WriteLine(counter);
                }
            }

        }
        } 

    }
