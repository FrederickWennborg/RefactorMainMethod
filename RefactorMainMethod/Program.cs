namespace RefactorMainMethod
{
    using RefactorMainMethod.Models;
    using RefactorMainMethod.Services;
    using RefactorMainMethod.Validation;
    using System;
    using System.Runtime.ConstrainedExecution;

    public class Program
    {
        static void Main(string[] args)
        {
            var carRentalService = new CarRentalService();
            var carRentals = carRentalService.GetAllCarRentals();

            foreach (var rental in carRentals)
            {
                CarRentalValidation.ValidateCustomerName(rental.CustomerName);
                CarRentalValidation.ValidateLicenseNumber(rental.CustomerLicenseNumber);
                CarRentalValidation.ValidateAvailability(rental.IsAvailable, rental.CarModel);

                rental.TotalCost = carRentalService.CalculateTotalCost(rental.RentalDays, rental.DailyRate);

                DisplayCarRental(rental);
            }

        }

        public static void DisplayCarRental(CarRental rental)
        {
            Console.WriteLine($"Car Model: {rental.CarModel}");
            Console.WriteLine($"Rental Days: {rental.RentalDays}");
            Console.WriteLine($"Daily Rate: {rental.DailyRate}");
            Console.WriteLine($"Total rental cost: {rental.TotalCost}");

            Console.WriteLine($"Rental updated. Thank you, {rental.CustomerName} for renting the {rental.CarModel}, at {rental.DailyRate}$!");
            Console.WriteLine(" ");
        }

    }
}
