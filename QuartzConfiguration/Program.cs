using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzConfiguration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scheduler = new StdSchedulerFactory().GetScheduler();
            scheduler.Start();
        }
    }
}
