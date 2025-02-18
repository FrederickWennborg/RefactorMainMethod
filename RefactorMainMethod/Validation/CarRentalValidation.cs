using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMainMethod.Validation
{
    public  class CarRentalValidation
    {
        public static void ValidateCustomerName(string customerName)
        {
            if (string.IsNullOrWhiteSpace(customerName))
            {
                Console.WriteLine("Customer name is required.");
            }
        }

        public static void ValidateLicenseNumber(string customerName)
        {
            if (string.IsNullOrWhiteSpace(customerName))
            {
                Console.WriteLine("Invalid license number. It must be at least 6 characters long.");
            }
        }

        public static void ValidateAvailability(bool isAvailable, string carModel)
        {
            if (!isAvailable)
            {
                Console.WriteLine($"Sorry, the {carModel} is not available.");
                return;
            }
        }
            




    }
}
