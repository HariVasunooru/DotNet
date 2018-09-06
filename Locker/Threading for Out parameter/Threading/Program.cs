using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingConcept
{
    class Program
    {
        public static int value = 0;
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(() => print(out value)));

            thread.Start();
            Console.WriteLine("Main Thread Started");
            Console.WriteLine($"{value}");
            Thread.Sleep(1000);
            Console.WriteLine($"{value}");
            Thread.Sleep(500);
            Console.WriteLine($"{value}");


            Console.ReadKey();
        }

        static void print(out int val)
        {


            Thread.Sleep(3000);
            val = 1;
            Console.WriteLine(val);
            
        }
    }
}

