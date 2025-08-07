using System;

namespace CarRentalSystem.Models
{
    public class Customer
    {
        public static int TotalCustomers = 0;

        public string Name { get; private set; }
        public string Email { get; private set; }
        public int RentedCars { get; private set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
            RentedCars = 0;
            TotalCustomers++;
        }

        public void RentCar(Car car)
        {
            if (car != null && car.IsAvailable && RentedCars < 2)
            {
                car.RentCar();
                RentedCars++;
            }
            else
            {
                Console.WriteLine($"{Name} cannot rent {car.Model}.");
            }
        }

        public void ReturnCar(Car car)
        {
            if (RentedCars > 0)
            {
                car.ReturnCar();
                RentedCars--;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Cars Rented: {RentedCars}");
            Console.WriteLine("------------------------");
        }
    }
}
