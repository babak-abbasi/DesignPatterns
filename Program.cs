using static System.Console;
// using DesignPatterns.Facade.AuthenticationComponent;
// using DesignPatterns.Facade.AuthorizationComponent;
// using DesignPatterns.Facade.ValidationComponent;
using DesignPatterns.Facade;
using DesignPatterns.CreationalPatterns;
using System;
using DesignPatterns.StructuralPatterns.Composite;
using DesignPatterns.StructuralPatterns.Decorator;
using DesignPatterns.BehavioralPatterns;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var genericSpecification 
                = new Specification.GenericSpecification<Car>(car => car.Age == 10);

            var car = new Car(){Age = 10};
            Console.WriteLine(genericSpecification.IsSatisfiedBy(car));
        }

        public class Car
        {
            public int Age { get; set; }
        }
    }
}
