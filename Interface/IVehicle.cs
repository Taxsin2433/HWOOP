namespace OOP.Interface
{
    public interface IVehicle
    {
        double Speed { get; set; }
        double Weight { get; set; }

        void Move();
    }
}
