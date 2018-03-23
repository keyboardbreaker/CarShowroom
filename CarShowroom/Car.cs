using System;

namespace CarShowroom
{
    public class Car : Vehicle
    {
        public static int totalNumberCars = 0;
        //public string model;
        //public string color;
        //public int price;
        //public bool sold;

        public Car(string model, string color, int price) : base(model, color, price)
        {
            //this.model = model;
            //this.color = color;
            //this.price = price;
            //this.sold = false;
            Car.totalNumberCars++;
        }

        //any one can call this
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
