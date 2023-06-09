using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzConfiguration
{
    public class HelloJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.Out.WriteLineAsync($"Executing background job => {DateTime.Now}");
        }
    }
}
