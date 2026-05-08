using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Double_dimension
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I am from Class A");
            String[] months = { "jan", "feb", "march" };

            int[,] sales = new int[3, 3];
            for(int i = 0; i < sales.GetLength(0); i++) {     // declared the number of rows in sales and it returns the rows using getlength

                Console.WriteLine($"Enter the sales man {i + 1}");

                for(int j= 0; j < sales.GetLength(1); j++)
                {
                    Console.Write("enter the sales");
                    sales[i,j]=int.Parse(Console.ReadLine());

                }
            }

            //print the values
            for (int i = 0; i < sales.GetLength(0); i++)
            {     // declared the number of rows in sales and it returns the rows using getlength

                Console.WriteLine($" the sales man {i + 1}");

                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    Console.WriteLine("tHE SALES IS");
                    Console.WriteLine($"{sales[i,j] }\t");

                }
            }
            Console.ReadLine();

        }

        }
}
