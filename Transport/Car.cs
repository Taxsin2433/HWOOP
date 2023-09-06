namespace OOP.Transport
{

    public abstract class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Car(double speed, double weight, string brand, string model) : base(speed, weight)
        {
            Brand = brand;
            Model = model;
        
        }

        public override void Move()
            {
                Console.WriteLine("Машина едет");
            }
       
    }

}
