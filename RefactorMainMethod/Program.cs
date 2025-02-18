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

                if (carRentalService.RequiresSpecialApproval(rental.TotalCost))
                    Console.WriteLine("This rental exceeds 2000 SEK, special approval required.");

                else
                    DisplayCarRental(rental);

            }

        }

        public static void DisplayCarRental(CarRental rental)
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine($"Car Model: {rental.CarModel}");
            Console.WriteLine($"Rental Days: {rental.RentalDays}");
            Console.WriteLine($"Daily Rate: {rental.DailyRate}");
            Console.WriteLine($"Total rental cost: {rental.TotalCost}");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Rental updated. Thank you, {rental.CustomerName} for renting the {rental.CarModel}, at {rental.TotalCost} SEK!");
            Console.WriteLine(Environment.NewLine);

        }

    }
}
