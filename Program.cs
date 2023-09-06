using OOP.Interface;
using OOP.Transport;
using System;
class Program
{
    static void Main(string[] args)
    {
        // Адд транспорта
        IVehicle[] vehicles = new IVehicle[]
        {
            new SportCar(320, 1500, "Ferrari", "F40", 320),
            new FamilyCar(180, 2000, "Toyota", "Camry", 5),
            new Bus(80, 5000, 30),
            new Airplane(900, 100000, 68),
            new Car2(280, 1000, "Nissan", "Primera")
        };

        // Сорт скоростm
        Array.Sort(vehicles, (x, y) => x.Speed.CompareTo(y.Speed));
        Array.Sort(vehicles, (a, b) => a.Weight.CompareTo(b.Weight));
        {
            Console.WriteLine($"Наибольший вес : {vehicles[vehicles.Length - 1].Weight}");
            Console.WriteLine($"Наивысшая скорость : {vehicles[vehicles.Length - 1].Speed}");

        }

        // Поиск марки
        string searchBrand = "Toyota";
        IVehicle foundVehicle = Array.Find(vehicles, v => v is Car && ((Car)v).Brand == searchBrand);

        if (foundVehicle != null)
        {
            Console.WriteLine($"Найден автомобиль марки {searchBrand}: {foundVehicle.GetType().Name}");
        }
        else
        {
            Console.WriteLine($"Автомобиль марки {searchBrand} не найден.");
        }
        // консоль оверрайда Мове
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }


    }
}