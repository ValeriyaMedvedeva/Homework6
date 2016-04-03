using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job.StartJob;


namespace Job
{
    class Program
    {
        static void Main(string[] args)
        {
            Scheduler start = new Scheduler();
            start.Start();
            Console.ReadLine();
        }
    }
}
