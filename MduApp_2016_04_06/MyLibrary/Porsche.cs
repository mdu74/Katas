using System;
using System.Drawing;

namespace MyLibrary
{
    public class Porsche : Car
    {
        public Porsche() : base("Porsche", "Cayenne", 2015, Color.Black)
        {

        }
        public override void PressAccelerator(int distance)
        {
            if (distance <= 6)
            {
                Console.WriteLine("C'mon MAN!!!");
            }
            else if (distance > 6)
            {
                Console.WriteLine("GONE!!!");
            }
            
        }

        public override void PressBrake(int pressure)
        {
            if (pressure <= 5)
            {
                Console.WriteLine("Brakes are set low: We're stopping now");
            }
            else if(pressure > 5)
            {
                Console.WriteLine("Brakes are set high: Carefull you're not ready for this");
            }
            
        }
    }
}
