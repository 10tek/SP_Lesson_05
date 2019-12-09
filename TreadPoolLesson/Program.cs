using System;
using System.Threading;

namespace TreadPoolLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.GetAvailableThreads(out int threads, out int ports);
            Console.WriteLine(threads);
            /*for (var i = 0; i < 20; i++)
            {
                ThreadPool.QueueUserWorkItem(ProcessNumbers);
            }
            Console.ReadKey();*/
            //Thread.CurrentThread.Join();

            var timer = new Timer(ProcessNumbers, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
            Console.ReadLine();
        }

        static void ProcessNumbers(object state)
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            //var currentThread = Thread.CurrentThread;
            //for (var i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine($"[{currentThread.ManagedThreadId} - {i}]");
            //    Thread.Sleep(500);
            //}
            //Console.WriteLine($"[{currentThread.ManagedThreadId}] - Закончил");
        }
    }
}
