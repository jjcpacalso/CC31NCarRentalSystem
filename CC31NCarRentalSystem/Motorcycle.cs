using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC31NCarRentalSystem
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar {  get; set; }
        public Motorcycle(
            string registrationNum,
            string make,
            string model,
            int year,
            double rentalPricePerDay,
            bool isAvailable,
            bool hasSideCar):
            base(registrationNum, make, model, year, rentalPricePerDay, isAvailable)
        {
            HasSideCar = hasSideCar;
        }

        public override string DisplayDetails()
        {
            if (HasSideCar)
            {
                return base.DisplayDetails() + ", has side car";
            }
            else
            {
                return base.DisplayDetails() + ", without side car";
            }
        }
    }
}
