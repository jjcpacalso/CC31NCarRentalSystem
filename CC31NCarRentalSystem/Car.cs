using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC31NCarRentalSystem
{
    public class Car : Vehicle
    {
        public int NumOfDoors { get; set; }
        public Car(string registrationNum, string make, string model, int year, double rentalPricePerDay, bool isAvailable, int numOfDoors):
            base(registrationNum, make, model, year, rentalPricePerDay, isAvailable)
        {
            NumOfDoors = numOfDoors;
        }
        public override string DisplayDetails()
        {
            return base.DisplayDetails() + ", number of doors: " + NumOfDoors;
        }
    }
}
