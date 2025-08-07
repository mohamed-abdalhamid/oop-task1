using System;

namespace CarRentalSystem.Models
{
    public class Car
    {
        public const int MaxRentalDays = 30;
        public static int TotalCars = 0;
        private readonly DateTime dateAdded;

        public string Model { get; private set; }
        public string Brand { get; private set; }
        public string PlateNumber { get; private set; }
        public bool IsAvailable { get; private set; }

        public Car()
        {
            Model = "Unknown";
            Brand = "Unknown";
            PlateNumber = "0000";
            IsAvailable = true;
            dateAdded = DateTime.Now;
            TotalCars++;
        }

        public Car(string model, string brand, string plate, bool available)
        {
            Model = model;
            Brand = brand;
            PlateNumber = plate;
            IsAvailable = available;
            dateAdded = DateTime.Now;
            TotalCars++;
        }

        public Car(Car other)
        {
            Model = other.Model;
            Brand = other.Brand;
            PlateNumber = other.PlateNumber;
            IsAvailable = other.IsAvailable;
            dateAdded = DateTime.Now;
            TotalCars++;
        }

        public void RentCar()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"{Brand} {Model} has been rented.");
            }
            else
            {
                Console.WriteLine($"{Brand} {Model} is already rented.");
            }
        }

        public void ReturnCar()
        {
            IsAvailable = true;
            Console.WriteLine($"{Brand} {Model} has been returned.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Plate: {PlateNumber}");
            Console.WriteLine($"Available: {IsAvailable}");
            Console.WriteLine($"Date Added: {dateAdded}");
            Console.WriteLine("------------------------");
        }
    }
}
