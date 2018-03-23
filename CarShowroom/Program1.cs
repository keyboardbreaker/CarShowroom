using System;
using System.Collections.Generic;

namespace CarsUserObjectCreation
{
    class Car
    {
        public string make;
        public string model;
        public int price;
        public Boolean sold;
        public int wheels;

        public static int numberOfCars;

        //AddCar method changed to a constructor by changing its name to Car (same as the class)
        //and removing its return type
        public Car(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            this.wheels = 4;
            // this.passengers = 5;

            Car.numberOfCars++;
        }

        // PUBLIC to make sure accessible to main program
        // static is class level access - don't use the car instance Car.method NOT Car1. or Car2. 
        public static Car CreateCar()
        {

            string make;
            string model;
            int price;

            Console.WriteLine("Please enter a make:");
            make = Console.ReadLine();
            Console.WriteLine("Please enter a model:");
            model = Console.ReadLine();
            Console.WriteLine("Please enter a price:");
            price = Convert.ToInt32(Console.ReadLine());

            //Create a new Car instance called my Car
            Car myCar = new Car(make, model, price);


            return myCar;
        }

        // Anyone can call this.
        public static void DisplayAllCars(List<Car> allCars)
        {/* Method statements here */

            Console.WriteLine("\nHere is the current list of cars:\n");
            foreach (Car car in allCars)
            {
                Console.WriteLine("Make: {0}", car.make);
                Console.WriteLine("Model: {0}", car.model);
                Console.WriteLine("Price: {0} \n", car.price);
            }
        }
    }//END CLASS


    /* ==================================================================== */
    class Program
    {
        static void Mainf(string[] args)
        {
            string response;


            List<Car> carsList = new List<Car>();

            do
            {
                Console.WriteLine("Please type A to add a car to the list or X to exit:");
                response = Console.ReadLine().ToUpper();

                if (response == "A")
                {

                    // add new car that has been RETURNED by the Create car method in class Car
                    carsList.Add(Car.CreateCar());
                    //display
                    Car.DisplayAllCars(carsList);

                }
            }
            while (response != "X");

        }
    }//End Car
    /* ==================================================================== */

}