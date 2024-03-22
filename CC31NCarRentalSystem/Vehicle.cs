using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC31NCarRentalSystem
{
    public class Vehicle
    {
        string RegistrationNum { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        double RentalPricePerDay { get; set; }
        public bool IsAvailable { get; set; }

        public Vehicle(string registrationNum,
                   string make,
                   string model,
                   int year,
                   double rentalPricePerDay,
                   bool isAvailable)
        {
            RegistrationNum = registrationNum;
            Make = make;
            Model = model;
            Year = year;
            RentalPricePerDay = rentalPricePerDay;
            IsAvailable = isAvailable;
        }

        //Sample output:
        //Toyota Innova (2017) - Registration: ABC123, Rent Price: 3500 per day
        public virtual string DisplayDetails()
        {
            return
            $"{Make} {Model} ({Year}) - Registration: {RegistrationNum}, Rent Price: {RentalPricePerDay} per day";
        }

        public void Rent()
        {
            IsAvailable = false;
        }

        public void Return()
        {
            IsAvailable = true;
        }
    }
}
