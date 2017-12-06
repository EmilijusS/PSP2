using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class MainViews : IMainViews
    {
        public void showMainMenu()
        {
            Console.WriteLine("1. Create client");
            Console.WriteLine("2. Create trainer");
            Console.WriteLine("3. Find trainer for client");
        }
    }
}
