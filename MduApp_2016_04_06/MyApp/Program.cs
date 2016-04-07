using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            KeystrokeHandler keystrokeHandler = new KeystrokeHandler();
            keystrokeHandler.OnKey = GotKey;
            keystrokeHandler.OnQuitting = OnQuit;

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
