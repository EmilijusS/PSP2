using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeServices;

namespace Integration
{
    public class Logger : ILogger
    {
        private List<string> log;

        public Logger()
        {
            log = new List<string>();
        }

        public void Log(string message)
        {
            log.Add(message);
        }
    }
}
