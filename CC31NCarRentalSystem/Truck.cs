using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC31NCarRentalSystem
{
    public class Truck : Vehicle
    {
        double CargoCapacityInTons { get; set; }

        public Truck(string registrationNum,
                     string make,
                     string model,
                     int year,
                     double rentalPricePerDay,
                     bool isAvailable,
                     double cargoCapacityInTons) :
            base(registrationNum, make, model, year, rentalPricePerDay, isAvailable)
        {
            CargoCapacityInTons = cargoCapacityInTons;
        }

        public override string DisplayDetails()
        {
            return base.DisplayDetails() + ", cargo capacity in tons: "+CargoCapacityInTons;
        }

    }
}
