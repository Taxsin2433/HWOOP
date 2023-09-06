namespace OOP.Transport

{

    public class Car2 : Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public new double Speed { get; set; }
        public new double Weight { get; set; }

        public  Car2(double speed, double weight, string brand, string model) : base(speed, weight, brand, model)
        {
            Brand = brand;
            Model = model;
            Speed = 1111111111;
            Weight = 111111111;
        }
        public override void Move()
        {
            Console.WriteLine("Car 2 Машина медленно едет");
        }
    }

}
