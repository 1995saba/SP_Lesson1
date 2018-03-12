using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] procList = Process.GetProcesses();
            Console.WriteLine("Количество процессов: {0}", procList.Count());
            Console.WriteLine("Имя процесса\t\t\t\tID\t\tHandles");
            foreach (Process proc in procList)
            {
                int BasePrior = -1;
                DateTime dt = DateTime.MinValue;
                try { BasePrior = proc.BasePriority; }
                catch(Exception) { }
                try { dt = proc.StartTime; }
                catch(Exception) { }
                Console.WriteLine("{0}\t\t\t\t{1}\t\t{2}\t\t{3}\t\t{4}",
                    proc.ProcessName, proc.Id, 
                    proc.HandleCount,
                    BasePrior, dt);
            }
            Console.ReadLine();
        }
    }
}
