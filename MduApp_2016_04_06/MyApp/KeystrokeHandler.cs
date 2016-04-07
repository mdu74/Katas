using System;

namespace MyApp
{
    public delegate void KeypressDelegate(char key);
    public delegate void QuitDelegate();

    public class KeystrokeHandler
    {
        public event KeypressDelegate OnKey;
        public event QuitDelegate OnQuitting;

        public void Run()
        {

            Console.WriteLine("Keystroke handler is running. Press Q to Quit.");

            while (true)
            {
                char key = Console.ReadKey(true).KeyChar; // Ask about KeyChar.

                if ('q' == key)
                {
                    if (null != OnQuitting)
                    {
                        OnQuitting();
                    }
                    break;
                }

                if (null != OnKey)
                    
                    OnKey(key);
                
            }

        }

        
    }
}
