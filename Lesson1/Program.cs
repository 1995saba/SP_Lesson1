using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process{
                StartInfo = new ProcessStartInfo("notepad.exe", @"z:\\MyFile.txt")
            };

            process.Start();
            Console.WriteLine("Process started...");

            // установка приоритета процесса
            process.PriorityClass = ProcessPriorityClass.High;

            Console.WriteLine("Process ID: {0}", process.Id);
            Console.WriteLine("Machine Name: {0}", process.MachineName);

            process.WaitForExit();
            Console.WriteLine("Process done");

            Console.ReadLine();
        }
    }
}
