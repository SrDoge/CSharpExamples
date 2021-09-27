using System;
using System.IO;
using System.Timers;
using Microsoft.Extensions.Configuration;

namespace TimerEmail
{
    class Program
    {
        private static Timer aTimer;
        static void Main(string[] args)
        {
            aTimer = new Timer();

            aTimer.Interval = 2000;

            aTimer.Elapsed += OnTimedEvent;

            aTimer.AutoReset = true;

            aTimer.Enabled = true;

            Console.WriteLine("Aperte Enter para sair do programa");
            Console.ReadLine();
        }

        private static void OnTimedEvent(Object teste, ElapsedEventArgs e)
        {
            Console.WriteLine("The elapse event was raised at {0}", e.SignalTime);
        }


    }
}
