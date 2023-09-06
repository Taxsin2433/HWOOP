using OOP.Interface;

namespace OOP.Transport
{
    // База
    public abstract class Vehicle : IVehicle
    {
        public double Speed { get; set; }
        public double Weight { get; set; }

        public Vehicle(double speed, double weight)
        {
            Speed = speed;
            Weight = weight;
        }
        public abstract void Move();


    }
}


