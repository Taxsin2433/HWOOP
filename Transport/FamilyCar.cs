namespace OOP.Transport
{

    public class FamilyCar : Car
    {
        public int NumSeats { get; set; }

        public FamilyCar(double speed, double weight, string brand, string model, int numSeats) : base(speed, weight, brand, model)
        {
            NumSeats = numSeats;
        }
    }

}
