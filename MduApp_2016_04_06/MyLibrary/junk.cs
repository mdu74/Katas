using System;
using System.Drawing;

namespace MyLibrary
{
    public class Junk : ICar
    {
        public void Start()
        {
            Console.WriteLine("Wait for it.... Wait for it... Any time now!!!");
        }

        public void PressAccelerator(int distance)
        {
            if (distance < 9)
            {
                // Nothing!
            }
            Console.WriteLine("Eish!!!!");
        }

        public void PressBrake(int pressure)
        {
            if (pressure < 5)
                Console.WriteLine("Too Soon! Too Soon!!!");
            else
                Console.WriteLine("Brrrrrrr!!! Waaaaaaaaahhhh!!!!!!");
        }

        public Color PaintColor { get; set; }

        public string Make
        {
            get
            {
                return "Toyota";
            }
        }

        public string Model
        {
            get
            {
                return "Cressida";
            }
        }

        public int Year
        {
            get
            {
                return 1968;
            }
        }
    }
}
