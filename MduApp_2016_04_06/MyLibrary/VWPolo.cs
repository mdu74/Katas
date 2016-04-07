using System;
using System.Drawing;

namespace MyLibrary
{
    public class VwPolo : ICar
    {
        public void Start()
        {
            Console.WriteLine("Ready to GO!!!");
        }

        public void PressAccelerator(int distance)
        {
            Console.WriteLine("Yea!!!!");
        }

        public void PressBrake(int pressure)
        {
            Console.WriteLine("STOP!!!");
        }

        public Color PaintColor { get; set; }

        public string Make
        {
            get
            {
                return "VW";
            }
        }

        public string Model
        {
            get
            {
                return "Polo";
            }
        }

        public int Year
        {
            get
            {
                return 2015;
            }
        }

    }
}
