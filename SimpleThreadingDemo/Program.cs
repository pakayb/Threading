using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart thread = new ThreadStart(Counting);
            Thread thread1 = new Thread(thread);
            Thread thread2 = new Thread(thread);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.ReadLine();
        }

        static void Counting()
        {
            for (int i = 0; i <=10 ; i++)
            {
                Console.WriteLine("Count: {0} Thread id: {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }

}
