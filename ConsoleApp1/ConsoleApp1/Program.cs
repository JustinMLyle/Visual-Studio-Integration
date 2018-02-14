using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Timers
{
    public class program
    {
        static void Main()
        {            
            Stopwatch starterGun = new Stopwatch();            
            Console.WriteLine("Hit Enter key to start the timer");
            starterGun.start();
            Console.ReadLine();
            Console.WriteLine("Hit Enter key to stop the timer");
            starterGun.Stop();
            Console.ReadLine();
            Console.WriteLine("your time is: " + starterGun.TimerLength.TotalSeconds.ToString());            
            Console.ReadLine();
            program.Main();
        }
    }
    public class Stopwatch
    {
        public TimeSpan TimerLength { get; set; }
        private DateTime startTime { get; set; }
        private DateTime EndTime { get; set; }        
        private bool isStarted { get; set; }

        public void start()
        {
            if (!isStarted) 
            {
                isStarted = true;
                startTime = DateTime.Now;
            }
            else
            {
                throw new System.InvalidOperationException();
            }

        }

        public void Stop()
        {
            isStarted = false;
            EndTime = DateTime.Now;             
            TimerLength = EndTime - startTime;
            
        }

         }
}

