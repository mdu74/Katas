using System;
using System.Drawing;
using MyLibrary;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car[] cars =
            {
                new VwPolo {Paint = Color.Blue},
                new Junk {Paint = Color.Aquamarine},
                new Porsche {Paint = Color.Red},
            };

            foreach (Car car in cars)
            {
                PrintCarInfo(car);
                car.Start();
                car.PressAccelerator(8);
                car.PressBrake(8);
            }

        }        

        static void PrintCarInfo(Car car)
        {
            Console.WriteLine("Here is a {0} {1} {2} {3}", car.Paint, car.Make, car.Model, car.Year);
        }
    }
}
