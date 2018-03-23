using System;

namespace CarShowroom
{
    public class Vehicle
    {
        public string model;
        public string color;
        public int price;
        public Boolean sold;

        public Vehicle(string model, string color, int price)
        {
            this.model = model;
            this.color = color;
            this.price = price;
        }
    }
}
