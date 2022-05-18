using static System.Console;
// using DesignPatterns.Facade.AuthenticationComponent;
// using DesignPatterns.Facade.AuthorizationComponent;
// using DesignPatterns.Facade.ValidationComponent;
using DesignPatterns.Facade;
using DesignPatterns.CreationalPatterns;
using System;
using DesignPatterns.StructuralPatterns.Composite;
using DesignPatterns.StructuralPatterns.Decorator;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userName = "";
            //string password = "";

            //// without FACADE design pattern
            //// ---------------------------------------------------------------------
            //// var validationService = new ValidationService();
            //// if(validationService.ISValidated(userName,password))
            //// {
            ////     var authenticationService = new AuthenticationService();
            ////     if(authenticationService.IsAuthenticated(userName,password))
            ////     {
            ////         var authorizationService  = new AuthorizationService();
            ////         if(authorizationService.IsAuthorized(userName,password))
            ////             System.Console.WriteLine("User loged in !");
            ////     }
            //// }
            ////------------------------------------------------------------------------

            ////FACADE solution 
            //var loginFacade = new LoginFacade();
            //if(loginFacade.CanLogin(userName,password))
            //    WriteLine("user loged in !");

            //var firstCustomer = new Customer()
            //{
            //    Name = "Alireza",
            //    LastName = "Mori",
            //    PhoneNumber = "+9890122222222"
            //};
            //var firstCustomerClone = firstCustomer.Clone();

            //var modernHouse = new HouseDirector().CreateModernHouse();
            //WriteLine(modernHouse.WallType);

            //var xml = new StructuralPatterns.Adapter(new StructuralPatterns.XML());
            //var x = xml.Convert();

            //var box = new Box();
            //var product = new Product() { Price = 10 };
            //var productTwo = new Product() { Price = 20 };

            //box.Add(product);
            //box.Add(productTwo);

            //var boxTwo = new Box();
            //var productThree = new Product() { Price = 30 };
            //boxTwo.Add(box);
            //boxTwo.Add(productThree);

            //var priceOfProducts = boxTwo.GetPrice();
            //Console.WriteLine(priceOfProducts);

            // var baseNotify = new BaseNotify();
            // var firstDecorator = new FirstDecorator(baseNotify);
            // var secondDecorator = new SecondDecorator(firstDecorator);

            // secondDecorator.Notify();

            // var button = new BehavioralPatterns.Button(){ Name = "Babak" };
            // var authDialog = new BehavioralPatterns.AuthenticatoinDialog(button);
            // button.SetMediator(authDialog);
            // button.Click();

            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            Client.ClientCode(monkey);
            Client.ClientCode(squirrel);

            ReadLine();
        }
    }
}
