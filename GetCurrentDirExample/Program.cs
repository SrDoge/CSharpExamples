using System;
using System.IO;

namespace GetCurrentDirExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                string target = @"c:\temp";

                Console.WriteLine("The current directory is {0}", path);
                if (!Directory.Exists(target))
                {
                    Directory.CreateDirectory(target);
                }

                Environment.CurrentDirectory = (target);
                if (path.Equals(Directory.GetCurrentDirectory()))
                {
                    Console.WriteLine("You are in the temp directory");
                }
                else
                {
                    Console.WriteLine("You are not in the temp directory");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Process failed: {0}", e.ToString());
            }
        }
    }
}
