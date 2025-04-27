using System.Threading;

namespace ThreadsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, World! 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hello, World! 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hello, World! 3");
            Thread.Sleep(1000);
            */

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 1");
            //}).Start();
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 2");
            //}).Start();
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 3");
            //}).Start();
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 4");
            //}).Start();

            // Thread Execution And Completion
            //var taskCompletionWSource = new TaskCompletionSource<bool>();
            //var thread = new Thread(() =>
            //{
            //    Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} started");
            //    Thread.Sleep(1000);
            //    taskCompletionWSource.TrySetResult(true);
            //    Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} ended");
            //});
            //Console.WriteLine($"Thread number: { thread.ManagedThreadId }");
            //thread.Start();
            //var test = taskCompletionWSource.Task.Result;
            //Console.WriteLine("Task was done: {0}", test);

            // Background Threads
            //new Thread(() =>
            //{
            //    Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} started");
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} ended");
            //})
            //{
            //    IsBackground = true
            //}.Start();

            // Thread Pool
            //Enumerable.Range(0, 1000).ToList().ForEach(i =>
            //{
            //    ThreadPool.QueueUserWorkItem((o) => {

            //        Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} started");
            //        Thread.Sleep(1000);
            //        Console.WriteLine($"Thread number : {Thread.CurrentThread.ManagedThreadId} ended");
            //    });
            //});

            //Console.ReadLine();

            Console.WriteLine("Main Thread Started");
            Thread thread1 = new Thread(Tread1Function);
            Thread thread2 = new Thread(Tread2Function);
            thread1.Start();
            thread2.Start();
            //thread1.Join();
            //Console.WriteLine("Thread1Function Done");
            //thread2.Join();
            //Console.WriteLine("Thread2Function Done");
            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1Function done");
            }
            else
            {
                Console.WriteLine("Thread1Function wasn't done in 1 sec");
            }
            thread2.Join();
            for (int i = 0; i < 10; i++)
            {
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread1 is still doing stuff");
                    Thread.Sleep(300);
                }
                else
                {
                    Console.WriteLine("Thread1 completed");
                }
            }
            Console.WriteLine("Main Thread Ended");
        }

        public static void Tread1Function()
        {
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(3000);
            Console.WriteLine("Thread1Function coming back to caller");
        }
        public static void Tread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }
    }
}
