using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC31NCarRentalSystem
{
    public class Customer
    {
        private static int s_CustomerIDSeed = 1000;
        string Name {  get; set; }
        int PhoneNumber { get; set; }
        int CustomerID {  get; set; }

        public Customer(string name, int phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            CustomerID = s_CustomerIDSeed++;
        }

        public void RentVehicle(Vehicle vehicle)
        {
            vehicle.Rent();
            Console.WriteLine("Vehicle rented: " + vehicle.DisplayDetails());
        }
        public void ReturnVehicle(Vehicle vehicle)
        {
            vehicle.Return();
            Console.WriteLine("Vehicle returned: " + vehicle.DisplayDetails());
        }
    }
}
