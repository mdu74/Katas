using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class QuitTracker
    {
        public string MyTracker { get; set; }

        public void QuitHandler()
        {
            Console.WriteLine("My name is {0}, I've just recieved a quite alert.", MyTracker);
        }
    }
}
