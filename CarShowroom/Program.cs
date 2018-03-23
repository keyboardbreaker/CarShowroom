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
                    case "add":
                        carlist.Add(Car.CreateCar());
                        break;

                    case "show":
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

    public class Car{
        public static int totalNumberCars = 0;
        public string model;
        public string color;
        public int price;
        public bool sold;

        public Car(string model, string color, int price)
        {
            this.model = model;
            this.color = color;
            this.price = price;
            this.sold = false;
            Car.totalNumberCars++;
        } 

        public static Car CreateCar()
        {
            Console.WriteLine("Enter Car Model:");
            string carModel = Console.ReadLine();

            Console.WriteLine("Enter Car Color:");
            string carColor = Console.ReadLine();

            Console.WriteLine("Enter Car Price:");
            int carPrice = Convert.ToInt32(Console.ReadLine());

            Car carObject = new Car(carModel, carColor, carPrice);

            return carObject;
        }
        
    }
}
