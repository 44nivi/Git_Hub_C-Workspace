using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Abst
    {
        public void Display()
        {
            Console.WriteLine("The area is");
        }
        public abstract void Area(int a , int b);
        public abstract void Perimeter();
    }

    public interface Circle
    {
        void radius();
    }
    class Shape_Abs : Abst, Circle
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public new void Display()
        {
            Console.WriteLine("welcom");
        }

        public override void Area(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("The area is " + c);
            
        }
        public override void Perimeter()
        {
            throw new NotImplementedException();
        }

        public void radius()
        {
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
         
            try
            {
                Log.Fatal("Start log FATAL...");
                Console.WriteLine("Start log FATAL...");
                string str ="welcome to India";
                string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
                Console.WriteLine(subStr);

            }
            catch (Exception ex)
            {
                Log.Error("Start log ERROR...");
                Log.Error("Error Message: " + ex.Message.ToString(), ex);
                Console.WriteLine("Start log ERROR...");

            }

            Shape_Abs obj = new Shape_Abs();
            obj.Area(1, 2);
            obj.Display();
            Console.ReadLine();

        }

     
    }

}
