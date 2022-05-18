using System;
using System.Collections.Generic;

class Client
{
    public static void ClientCode(AbstractHandler handler)
    {
        foreach (var food in new List<string>(){ "banana", "nut", "meatball" })
        {
            Console.WriteLine($"Who wants a: {food}");

            var result = handler.Handle(food);

            if(result != null)
                Console.WriteLine(result);
            else
                Console.WriteLine($"{food} was untouched.");
        }
    } 
}