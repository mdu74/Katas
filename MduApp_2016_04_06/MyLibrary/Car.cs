using System;
using System.Drawing;

namespace MyLibrary
{
    public abstract class Car
    {
        public Car(string make, string model, int year, Color paintColor)
        {
            Make = make;
            Model = model;
            Year = year;
            Paint = paintColor;
        }
        
        public virtual void Start()
        {
            Console.WriteLine("Voooom!!! Voooom!!!");
        }

        public abstract void PressAccelerator(int distance);

        public abstract void PressBrake(int pressure);

        public string Make { get;}
        public string Model { get; }
        public int Year { get; }
        public Color Paint { get; set; }

    }
}
