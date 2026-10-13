using System;
using System.Threading;

class Program
{
    static void DonwloadFile()
    {
        for (int i = 0; i< 5; i++)
        {
            Console.WriteLine("Donwloadig file...");
            Thread.Sleep(1000);
        }
    }

    static void CheckingData()
    {
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Checking data...");
            Thread.Sleep(1000);
        }
    }

    static void Main()
    {
        Thread thread1 = new Thread(DonwloadFile);
        Thread thread2 = new Thread(CheckingData);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine(" ");
        Console.WriteLine("All operations completed.");
    }
}