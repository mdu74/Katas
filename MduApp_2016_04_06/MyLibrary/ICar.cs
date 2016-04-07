using System.Drawing;

namespace MyLibrary
{
    public interface ICar
    {
        void Start();
        void PressAccelerator(int distance);
        void PressBrake(int pressure);

        string Make { get;}
        string Model { get; }
        int Year { get; }
        Color PaintColor { get; set; }

    }
}
