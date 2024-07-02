using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _1._7._2024
{
    public class Car
    {

        public string Make { get; set; }
        public int Year { get; set; }
        public string CarType { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public string PalletNo { get; set; }
        public string Color { get; set; }


        public Car(string make, int year, string carType, double price, string model, string palletNo, string color)
        {
            Make = make;
            Year = year;
            CarType = carType;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;
        }

        
        // Method Start
        void Start()
        {
            Console.WriteLine("the car is starting");
        }
        // Method Stop
        void Stop()
        {
            Console.WriteLine("the car is stopping");
        }

        public void FullInformation()
        {
            Console.WriteLine($" Thie information of car are {Make} , {Year} , {CarType} , {Price} , {Model} , {PalletNo} , {Color}");
        }
    }

    // Derived class BMW
    public class BMW : Car
    {
        public BMW(int year, string carType, double price, string model, string palletNo, string color)
            : base("BMW", year, carType, price, model, palletNo, color)
        {
        }
    }




        internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", 2021, "SUV", 30000, "RAV4", "123456", "Red");
            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Year: {myCar.Year}");
            Console.WriteLine($"Type: {myCar.CarType}");
            Console.WriteLine($"Price: {myCar.Price}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Pallet No: {myCar.PalletNo}");
            Console.WriteLine($"Color: {myCar.Color}");

            myCar.FullInformation();


            BMW bMW = new BMW( 1999, "ABC", 12, "1", "1234", "color");
            Console.WriteLine(bMW.Year);
            Console.WriteLine($"Make: {bMW.Make}");
            Console.WriteLine($"Year: {bMW.Year}");
            Console.WriteLine($"Type: {bMW.CarType}");
            Console.WriteLine($"Price: {bMW.Price}");
            Console.WriteLine($"Model: {bMW.Model}");
            Console.WriteLine($"Pallet No: {bMW.PalletNo}");
            Console.WriteLine($"Color: {bMW.Color}");
        }
    }
}