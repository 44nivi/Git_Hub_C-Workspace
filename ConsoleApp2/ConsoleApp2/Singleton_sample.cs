using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{
    public class Singleton
    {
        // Private static instance variable
        private static Singleton instance;
        public int id;
        // Private constructor to prevent instantiation from outside
        private Singleton() { 
        }

        // Public static method to access the singleton instance
        public static Singleton GetInstance()
        {
            // Lazy initialization: create the instance if it doesn't exist
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // Example method of the Singleton class
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }

      /*  public static bool WriteLog(string strFileName, string strMessage)
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
        }*/
    }
    internal class Singleton_sample
    {
        static void Main(string[] args)
        {
            // Get the singleton instance
            Singleton singletonInstance = Singleton.GetInstance();
            singletonInstance.id = 24;
            // Use methods or properties of the singleton instance
           // Singleton.WriteLog("ConsoleLog1", String.Format("{0} @ {1}", "Log is Created at", DateTime.Now));

            singletonInstance.PrintMessage("Hello, Singleton!");

        

        }
    }
}
