using System;
using System.Threading;

Console.WriteLine("Hello, World!");


void ThreadProc(){
    Thread.Sleep(2000);
    Console.WriteLine("rg");
}
Thread t = new Thread(new ThreadStart(ThreadProc));

Console.ReadLine();

