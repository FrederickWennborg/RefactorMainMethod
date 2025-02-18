using RefactorMainMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMainMethod.Services
{
    public class CarRentalService
    {

        public List<CarRental> GetAllCarRentals() 
        {
            //Hämta från databas ?

            return new List<CarRental>
            {
                new CarRental
                {
                    CarModel = "Toyota Corolla",
                    IsAvailable = true,
                    CustomerName = "John Doe",
                    CustomerLicenseNumber = "ABF125",
                    RentalDays = 7,
                    DailyRate = 350,
                },
                 new CarRental
                {
                    CarModel = "Volvo EC40",
                    IsAvailable = true,
                    CustomerName = "Jane Doe",
                    CustomerLicenseNumber = "HJD345",
                    RentalDays = 3,
                    DailyRate = 670,
                }

            }; 

        }


        public double CalculateTotalCost(int rentalDays, double dailyRate)
        {
           return rentalDays * dailyRate;
        }


        public bool RequiresSpecialApproval(double totalCost)
        {
            return totalCost > 2000;
        }


    }
}
