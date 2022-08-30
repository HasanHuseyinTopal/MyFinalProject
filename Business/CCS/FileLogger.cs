using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Filerlogger");
        }
    }
}
