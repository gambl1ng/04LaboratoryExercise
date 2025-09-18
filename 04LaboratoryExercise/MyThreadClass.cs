using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04LaboratoryExercise
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i <= 50; i++)
            {
                Thread thread = Thread.CurrentThread;

                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + i);
                Thread.Sleep(500);


            }

        }
    }
}


