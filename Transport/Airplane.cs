namespace OOP.Transport
{

    public class Airplane : Vehicle
    {
        public double Wingspan { get; set; }

        public Airplane(double speed, double weight, double wingspan) : base(speed, weight)
        {
            Wingspan = wingspan;
        }
        public override void Move()
        {
            Console.WriteLine("Самолет летит");
        }
    }
}
