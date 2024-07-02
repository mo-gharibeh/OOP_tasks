using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7._2024
{
    public class Car
    {
        //1
        //Fields
        //Properties
        public string Make { get; set; }
        public int Year { get; set; }
        public string CarType { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public string PalletNo { get; set; }
        public string Color { get; set; }

        //2
        public void DisplayInfo(string make, int year)
        {
            Console.WriteLine("fun 1 " + make + year);
        }
        
        //3
        public void DisplayInfo(string make)
        {
            Console.WriteLine("fun 2 " + make );
        }

        //4
        public  virtual void Display() 
        {
            Console.WriteLine("Welcom Car");
        }
    }

    //5
    public class BMW : Car
    {
        //5.a
        //public  void Display()
        public override void Display()
        {
            Console.WriteLine("Welcom BMW");
        }
    } 
    /// <summary>
    /// /////////////////////////////////////
    /// </summary>
    //Task 2
    public interface ISound
    {
        void MakeSound();
    }
    //pearent class
    public abstract class Animal 
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Eat();

        public void sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }
    }

    //children classes
     public class Dog : Animal, ISound
     {
        public Dog(string name) : base(name) { }
        public override void Eat()
        {
            Console.WriteLine($"{Name} what it is eating.");
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }

     }
     class Cat : Animal, ISound 
     {
        public Cat(string name) : base(name) { }
         public override void Eat()
        {
            Console.WriteLine($"{Name} what it is eating.");
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
     }

    internal class Program
    {
        static void Main(string[] args)
        {

            //5.b
            BMW bMW = new BMW();
            bMW.Display();

            //6
            Car myCar = new BMW();
            myCar.Display();

            ////////////
            ///For task 2
            ///4
            // Create instances of Dog and Cat
            Dog dog = new Dog("dogdog");
            Cat cat = new Cat("catcat");

            // Call the methods on the Dog instance
            dog.Eat();
            dog.sleep();
            dog.MakeSound();


            // Call the methods on the Cat instance
            cat.MakeSound();
            cat.sleep();
            cat.Eat();
        }
    }
}
