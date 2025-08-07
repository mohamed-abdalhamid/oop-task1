using System;
using CarRentalSystem.Models;

namespace CarRentalSystem
{
    class Program
    {
        static void Main()
        {
            Car car1 = new Car("Civic", "Honda", "ABC123", true);
            Car car2 = new Car("Corolla", "Toyota", "XYZ789", true);
            Car car3 = new Car(car1);

            Customer customer1 = new Customer("Mohamed", "mohamed@example.com");

            car1.DisplayInfo();
            car2.DisplayInfo();
            car3.DisplayInfo();
            customer1.DisplayInfo();

            customer1.RentCar(car1);
            customer1.RentCar(car2);

            customer1.ReturnCar(car1);

            car1.DisplayInfo();
            car2.DisplayInfo();
            customer1.DisplayInfo();

            Console.WriteLine($"Total Cars: {Car.TotalCars}");
            Console.WriteLine($"Total Customers: {Customer.TotalCustomers}");
        }
    }
}
