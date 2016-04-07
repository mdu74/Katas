using System;
using System.Drawing;

namespace MyLibrary
{
    public class VwPolo : CarBase
    {
        public VwPolo() : base("VW", "Polo", 2015, Color.DarkGoldenrod)
        {
            
        }
        
        public override void PressAccelerator(int distance)
        {
            Console.WriteLine("Yea!!!!");
        }

        public override void PressBrake(int pressure)
        {
            Console.WriteLine("STOP!!!");
        }
        
    }
}
