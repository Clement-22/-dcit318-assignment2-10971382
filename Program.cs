using DCIT318_Assignment2_DCIT318_10971382;
using System;

namespace DCIT318_Assignment2_10971382
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance and Method Overriding
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            Console.WriteLine("Inheritance and Method Overriding:");
            genericAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();

            // Abstract Classes and Methods
            Shape circle = new Circle(5.0);
            Shape rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine("\nAbstract Classes and Methods:");
            Console.WriteLine($"Circle area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");

            // Interfaces
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            Console.WriteLine("\nInterfaces:");
            car.Move();
            bicycle.Move();
        }
    }
}
