using System;

namespace Business.CCS
{
    class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("DatabaseLogger");
        }
    }
}
