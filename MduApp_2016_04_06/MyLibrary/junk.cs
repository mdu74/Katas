using System;
using System.Drawing;

namespace MyLibrary
{
    public class Junk : CarBase
    {
        public Junk() : base("Toyota", "Cressida", 1968, Color.Aqua)
        {

        }
        
        public override void PressAccelerator(int distance)
        {
            if (distance < 9)
            {
                // Nothing!
            }
            Console.WriteLine("Eish!!!!");
        }

        public override void PressBrake(int pressure)
        {
            if (pressure < 5)
                Console.WriteLine("Too Soon! Too Soon!!!");
            else
                Console.WriteLine("Brrrrrrr!!! Waaaaaaaaahhhh!!!!!!");
        }
        
    }
}
