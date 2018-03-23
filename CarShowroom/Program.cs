using System;
using System.Collections.Generic;

namespace CarShowroom
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carlist  = new List<Car>();
            string userInput = "";

            do
            {
                Console.WriteLine($"Enter 'add' to add house, 'show' to see car list or 'exit': ");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "add": //ADD CREATED CAR OBJECT RETURNED FROM STATIC CAR METHOD IN CAR CLASS
                        carlist.Add(Car.CreateCar());
                        break;

                    case "show": //DISPLAY ALL CARS
                        foreach(Car car in carlist)
                            Console.WriteLine("{0} {1} £{2:N}", car.color, car.model, car.price);
                        break;

                    case "exit":
                        break;
                }
            }
            while (userInput != "exit");
        }
    }
}
