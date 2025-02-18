namespace RefactorMainMethod
{
    using System;
    using System.Runtime.ConstrainedExecution;

    class Program
    {
        static void Main(string[] args)
        {
            string carModel = "Toyota Corolla";
            bool isAvailable = true;
            string customerName = "John Doe";
            string customerLicenseNumber = "ABF125";
            int rentalDays = 7;
            double dailyRate = 350;

            if (string.IsNullOrEmpty(customerName))
            {
                Console.WriteLine("Customer name is required.");
                return;
            }

            if (string.IsNullOrEmpty(customerLicenseNumber) || customerLicenseNumber.Length < 6)
            {
                Console.WriteLine("Invalid license number.");
                return;
            }

            if (!isAvailable)
            {
                Console.WriteLine($"Sorry, the {carModel} is not available.");
                return;
            }

            double rentalCost = rentalDays * dailyRate;

            Console.WriteLine($"Car Model: {carModel}");
            Console.WriteLine($"Rental Days: {rentalDays}");
            Console.WriteLine($"Daily Rate: {dailyRate}");
            Console.WriteLine($"Total rental cost: {rentalCost}");

            if (rentalCost > 2000)
            {
                Console.WriteLine("This rental exceeds 2000 SEK, special approval required.");
            }

            Console.WriteLine($"Thank you for renting the {carModel}, {customerName}!");


            carModel = "Volvo EC40";
            isAvailable = true;
            customerName = "Jane Doe";
            customerLicenseNumber = "HJD345";
            rentalDays = 3;
            dailyRate = 670;

            if (string.IsNullOrEmpty(customerName))
            {
                Console.WriteLine("Customer name is required.");
                return;
            }

            if (string.IsNullOrEmpty(customerLicenseNumber) || customerLicenseNumber.Length < 6)
            {
                Console.WriteLine("Invalid license number.");
                return;
            }

            if (!isAvailable)
            {
                Console.WriteLine($"Sorry, the {carModel} is not available.");
                return;
            }

             rentalCost = rentalDays * dailyRate;

            Console.WriteLine($"Car Model: {carModel}");
            Console.WriteLine($"Rental Days: {rentalDays}");
            Console.WriteLine($"Daily Rate: {dailyRate}");
            Console.WriteLine($"Total rental cost: {rentalCost}");

            if (rentalCost > 2000)
            {
                Console.WriteLine("This rental exceeds 2000 SEK, special approval required.");
            }

            Console.WriteLine($"Thank you for renting the {carModel}, {customerName}!");



        }
    }
}
