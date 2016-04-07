using System;

namespace MyApp
{
    public class KeystrokeHandler
    {
        public void Run()
        {
            Console.WriteLine("Keystroke handler is running. Press Q to Quit.");

            while (true)
            {
                char key = Console.ReadKey(true).KeyChar; // Ask about KeyChar.

                if ('q' == key)
                {
                    break;
                }
            }

        }
    }
}
