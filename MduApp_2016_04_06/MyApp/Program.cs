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
                new Porsche {PaintColor = Color.Red},
            };

            foreach (ICar car in cars)
            {
                PrintCarInfo(car);
                car.Start();
                car.PressAccelerator(8);
                car.PressBrake(8);
            }

        }        

        static void PrintCarInfo(ICar car)
        {
            Console.WriteLine("Here is a {0} {1} {2} {3}", car.PaintColor, car.Make, car.Model, car.Year);
        }
    }
}
