using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2
{
    public class FileLogger : ILogger
    {
        private List<string> log;

        public FileLogger()
        {
            log = new List<string>();
        }

        public void Log(string message)
        {
            log.Add(message);
            Console.WriteLine("FileLogger:" + message);
        }
    }
}
