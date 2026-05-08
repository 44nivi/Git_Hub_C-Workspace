using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class NewSample_Thread
    {

       private static readonly object LockDisplayMethod = new object();
        static void DoSomeHeavyLifting()
        {
            lock (LockDisplayMethod)
            {
                Console.WriteLine("I'm lifting a truck!!");
                Thread.Sleep(1000);
                Console.WriteLine("Tired! Need a 3 sec nap.");
                Thread.Sleep(1000);
                Console.WriteLine("1....");
                Thread obj5 = new Thread(nothing);
                obj5.Start();
                
                /*Thread.Sleep(1000);
                Console.WriteLine("2....");
                Thread.Sleep(1000);

                Console.WriteLine("3....");
                Console.WriteLine("I'm awake.");*/
            }
         }
        /*   static void DoSomething()
          {

              Console.WriteLine("Hey! DoSomething here!");
              for (int i = 0; i < 5; i++)
              {
                  Thread.Sleep(3000);
                  Console.Write($" {i} ");
                  Console.WriteLine();
              }
              Console.WriteLine("I'm done.");


          }*/

        static void nothing()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("its me nothing");
            }
                
        }
        static void anything()
        {
            Console.WriteLine("Hey! am anything ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("its me anything");
            }
        }

        static void Main(string[] args)

        {
            //foreground Thread

            Console.WriteLine("Main Thread Starts!!");

           /* Thread obj = new Thread(NewSample_Thread.DoSomeHeavyLifting);
            
            obj.Start();*/

            Console.WriteLine("Main thread ends");

            //Background Thread
            /* Thread obj2 = new Thread(DoSomething)
             {
                 IsBackground = true
             };

             obj2.Start();

             Console.WriteLine("Main Thread Ends!!");
             */

            Thread obj3 = new Thread(NewSample_Thread.DoSomeHeavyLifting);
            obj3.Start();


            Thread obj4 = new Thread(NewSample_Thread.anything);
            obj4.Start();

            obj3.Join();
            obj4.Join();

            //obj4.Abort();

            Console.ReadLine();

        }
    }
}
