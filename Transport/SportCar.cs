namespace OOP.Transport
{
    // Класс спорткар иерархия  Вехикл - Кар - Кар2 - Спорткар  3 раза в глубину не считая базы
    public class SportCar : Car2
    {
        public double MaxSpeed { get; set; }

        public SportCar(double speed, double weight, string brand, string model, double maxSpeed) : base(speed, weight, brand, model)
        {
            MaxSpeed = maxSpeed;
        }
        public override void Move()
        {
            Console.WriteLine("SportCar Машина быстро едет");
        }
    }
}
