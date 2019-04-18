using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise1
{
    public class StopWatch
    {
        private bool Running { get; set; }
        private DateTime Started { get; set; }

        public void Start()
        {
            if (this.Running)
            {
                Console.WriteLine("Already running...");
                return;
            }
            else
            {
                this.Running = true;
                this.Started = DateTime.Now;
                Console.WriteLine(DateTime.Now);
            }
        }

        public void Stop()
        {
            if (this.Running == false)
            {
                Console.WriteLine("Not running...");
            }
            else
            {
                this.Running = false;
                var ended = DateTime.Now;
                var totalTime = (ended - this.Started);
                Console.WriteLine(totalTime);
            }
        }
    }
}
