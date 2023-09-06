namespace OOP.Transport
{

    public class Bus : Vehicle
    {
        public int NumPassengers { get; set; }

        public Bus(double speed, double weight, int numPassengers) : base(speed, weight)
        {
            NumPassengers = numPassengers;
        }
        public override void Move()
        {
            Console.WriteLine("Автобус едет");
        }
    }
}
