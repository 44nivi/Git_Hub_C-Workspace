using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class log_file
    {
        public static bool WriteLog(string strFileName, string strMessage)
        {
            try
            {
                FileStream objFilestream = new FileStream(string.Format("{0}\\{1}", "C:\\Users\\nraman\\Desktop", strFileName), FileMode.Append, FileAccess.Write);
                StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
                objStreamWriter.WriteLine(strMessage);
                objStreamWriter.Close();
                objFilestream.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
            static void Main(string[] args)
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                //System.Console.WriteLine(builder);

                builder.AddFilter("Microsoft", LogLevel.Warning)
                .AddFilter("System", LogLevel.Warning)
                .AddFilter("LoggingConsoleApp.Program", LogLevel.Debug)
                .AddFilter("some thing error", LogLevel.Error).AddConsole();

            });
            var logs = loggerFactory.CreateLogger<log_file>();

            
            try
            {
                //user to enter the length
                Console.WriteLine("Enter the array Length");
                int n = Convert.ToInt32(Console.ReadLine());
                //create a integer array 
                int[] array = new int[n];
                Console.Write("Enter the array elements:");
                for (int i = 0; i < n; i++)//iterate the loop i
                {

                    //Storing value in an array
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                int sum = 0;
                //calculate the sum of array 
                for (int i = 0; i < array.Length; i++)
                {

                    sum += array[i];
                }
                Console.WriteLine("Sum of value in the array is " + sum);
                logs.LogInformation("Hello World! Logging is {Description}.", "fun");

                Console.ReadLine();

            }
            catch (Exception e)
            {
                logs.LogError(e.Message);
                log_file.WriteLog("ConsoleLog3", String.Format("{0} @ {1}", e.Message, DateTime.Now));
                Console.WriteLine("Log is Written Successfully !!!");
                Console.ReadLine();

                Console.ReadLine();

            }


        }

    }
}
