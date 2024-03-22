﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CC31NCarRentalSystem
{
    public class RentalSystem
    {
        private List<Vehicle> _availableVehicles = new List<Vehicle>();
        private List<Vehicle> _rentedVehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            _availableVehicles.Add(vehicle);
        }

        public void RentVehicle(Vehicle vehicle, Customer customer)
        {
            if (vehicle.IsAvailable)
            {
                customer.RentVehicle(vehicle);
                _rentedVehicles.Add(vehicle);
                _availableVehicles.Remove(vehicle);
            }
            else
            {
                Console.WriteLine("Vehicle is not available for rent.");
            }
        }

        public void ReturnVehicle(Vehicle vehicle, Customer customer)
        {
            if(_rentedVehicles.Contains(vehicle))
            {
                customer.ReturnVehicle(vehicle);
                _rentedVehicles.Remove(vehicle);
                _availableVehicles.Add(vehicle);
            }
            else
            {
                Console.WriteLine("This vehicle is not rented from our system.");
            }
        }

        public void DisplayAvailableVehicles()
        {
            Console.WriteLine("Available Vehicle:");
            foreach(Vehicle vehicle in _availableVehicles)
            {
                Console.WriteLine("\t"+ vehicle.DisplayDetails());
            }
        }
        public void DisplayRentedVehicles()
        {
            Console.WriteLine("Rented Vehicle:");
            foreach(Vehicle vehicle in _rentedVehicles)
            {
                Console.WriteLine("\t" + vehicle.DisplayDetails());
            }
        }
    }
}
