using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QuitTracker terry = new QuitTracker{MyTracker = "Terry"};
            QuitTracker alphios = new QuitTracker {MyTracker = "Alphios"};

            KeystrokeHandler keystrokeHandler = new KeystrokeHandler();
            keystrokeHandler.OnKey += GotKey;
            keystrokeHandler.OnQuitting += alphios.MyTracker;
            keystrokeHandler.OnQuitting += OnQuit;

            keystrokeHandler.Run();
        }

        static void GotKey(char key)
        {
            Console.WriteLine("Got a key: {0}", key);
        }

        static void OnQuit()
        {
            Console.WriteLine("Quitting");
        }

    }
}
