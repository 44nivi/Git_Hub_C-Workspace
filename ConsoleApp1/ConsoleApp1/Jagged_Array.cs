using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Jagged_Array //jagged array is the array which will not consume the unsued space of array.Jagged array is a array of arrays such that member arrays can be of different sizes.
                                //In other words, the length of each array index can differ.
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Jagged array");
            

            int[][] sales = new int[3][];
            for (int i = 0; i < sales.GetLength(0); i++)
            {     // declared the number of rows in sales and it returns the rows using getlength

                Console.WriteLine($"Enter the sales man {i + 1}");
                int n=int.Parse(Console.ReadLine());
                sales[i]  = new int[n];
                for (int j = 0; j < sales[i].Length; j++)
                {
                    Console.Write("enter the sales");
                    sales[i][j] = int.Parse(Console.ReadLine());

                }

            }

            for (int i = 0; i < sales.GetLength(0); i++)
            {     // declared the number of rows in sales and it returns the rows using getlength

                Console.WriteLine($" the sales man {i + 1}");

                for (int j = 0; j < sales[i].Length; j++)
                {
                    Console.WriteLine("tHE SALES IS");
                    Console.WriteLine($"{sales[i][j]}\t");

                }
            }
            Console.ReadLine();



        }



    }
        
}
