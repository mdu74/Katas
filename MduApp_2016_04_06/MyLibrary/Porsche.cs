using System;
using System.Drawing;

namespace MyLibrary
{
    public class Porsche : ICar
    {
        public void Start()
        {
            Console.WriteLine("This is AWESOME!!!");
        }
        public void PressAccelerator(int distance)
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

        public void PressBrake(int pressure)
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

        public string Make
        {
            get
            {
                return "Porsche";
            }
        }

        public string Model
        {
            get
            {
                return "Cayanne";
            }
        }

        public Color PaintColor
        {
            get; set;
        }

        public int Year
        {
            get { return 2015; }
        }
    }
}
