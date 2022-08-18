using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //var ListOfCars = new List<string>();
            //    for (int i = 0; i < args.Length; i++)
            //{
            //    return ListOfCars[i] + ListOfCars;
            //}
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            Car myCar = new Car();

            myCar.Make = "Ford";
            myCar.Model = "Taurus";
            myCar.Year = 2015;
            myCar.EngineNoise = "No";
            myCar.HonkNoise = "Yes";
            myCar.IsDriveable = true;

            Console.WriteLine("My Car -");
            Console.WriteLine($"Make : {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");
            Console.WriteLine($"Engine Noise: {myCar.EngineNoise}");
            Console.WriteLine($"Honk Noise: {myCar.HonkNoise}");
            Console.WriteLine($"It is driveable: {myCar.IsDriveable}");
            Console.WriteLine();

            Car yourCar = new Car() { Make = "Subaru", Model = "Outback", Year = 2019, EngineNoise = "No", HonkNoise = "Quiet", IsDriveable = true };
            Console.WriteLine("Your car - ");
            Console.WriteLine($"Make : {yourCar.Make}");
            Console.WriteLine($"Model: {yourCar.Model}");
            Console.WriteLine($"Year: {yourCar.Year}");
            Console.WriteLine($"Engine Noise: {yourCar.EngineNoise}");
            Console.WriteLine($"Honk Noise: {yourCar.HonkNoise}");
            Console.WriteLine($"It is driveable: {yourCar.IsDriveable}");
            Console.WriteLine();

            Car ourCar = new Car("Mercedes", "GLA", 2022, "No", "Loud", true);
            Console.WriteLine("Our car - ");
            Console.WriteLine($"Make : {ourCar.Make}");
            Console.WriteLine($"Model: {ourCar.Model}");
            Console.WriteLine($"Year: {ourCar.Year}");
            Console.WriteLine($"Engine Noise: {ourCar.EngineNoise}");
            Console.WriteLine($"Honk Noise: {ourCar.HonkNoise}");
            Console.WriteLine($"It is driveable: {ourCar.IsDriveable}");
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
