using System;
using System.Drawing;
using MyLibrary;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICar[] cars =
            {
                new VwPolo {PaintColor = Color.Blue},
                new Junk {PaintColor = Color.Aquamarine},
            };

            foreach (ICar car in cars)
            {
                PrintCarInfo(car);
                car.Start();
                car.PressAccelerator(3);
                car.PressAccelerator(20);
                car.PressBrake(3);
                car.PressBrake(10);
            }

        }        

        static void PrintCarInfo(ICar car)
        {
            Console.WriteLine("Here is a {0} {1} {2} {3}", car.PaintColor, car.Make, car.Model, car.Year);
        }
    }
}
