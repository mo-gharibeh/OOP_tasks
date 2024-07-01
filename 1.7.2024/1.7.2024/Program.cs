using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7._2024
{
    public class Car
    {
        protected int year;
        protected string type;
        protected string model;
        protected string pallet_no;
        protected string color;
        protected string owner;


        public int Year
        {

            set
            {
                year = value;
            }
            get { return year; }
        }



        public Car(int year, string type, string model, string pallet_no, string color, string owner)
        {
            this.year = year;
            this.type = type;
            this.model = model;
            this.pallet_no = pallet_no;
            this.color = color;
            this.owner = owner;
        }




        protected void Start()
        {
            Console.WriteLine("the car has just started");
        }


        protected void Stop()
        {
            Console.WriteLine("the car has just stopped");
        }


        protected string Car_info()
        {


            return $"the car info is : year: {year} , type : {type} , model : {model} , pallet N.o {pallet_no} , color : {color}, owner: {owner}";

        }


    }

    public class BMW : Car
    {


        public BMW(int year, string type, string model, string pallet_no, string color, string owner) : base(year, type, model, pallet_no, color, owner)
        {

            this.year = year;
            this.model = model;
            this.pallet_no = pallet_no;
            this.color = color;
            this.type = type;
            this.owner = owner;

        }
        public string GetCarInfo()
        {
            return Car_info();
        }
        public void GetStop()
        {
            Stop();

        }
        public void GetStart()
        {
            Start();

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1633, "Marcedecs", "nm", "533102", "Green", "Rmzi");

            Console.WriteLine(car.Year);

            BMW bmw_car = new BMW(2001, "ddd", "mm", "778963", "Black", "Mohmmad");

            Console.WriteLine(bmw_car.Year);

            Console.WriteLine(bmw_car.GetCarInfo());
            bmw_car.GetStop();
            bmw_car.GetStart();


        }
    }
}