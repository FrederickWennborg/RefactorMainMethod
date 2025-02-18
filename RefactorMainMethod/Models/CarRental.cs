using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMainMethod.Models
{
    public class CarRental
    {
        public string CarModel { get; set; } = null!;

        public bool IsAvailable { get; set; }

        public string CustomerName { get; set; } = null!;

        public string CustomerLicenseNumber { get; set; } = null!;

        public int RentalDays { get; set; }

        public double DailyRate { get; set; }

        public double TotalCost { get; set; }







    }
}
