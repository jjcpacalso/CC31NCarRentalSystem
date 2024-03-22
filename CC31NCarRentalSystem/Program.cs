namespace CC31NCarRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(
                "ABC123",
                "Toyota",
                "Innova",
                2017,
                3500,
                true,
                5
            );
            Car car2 = new Car(
                "DEF456",
                "Mitsubishi",
                "Mirage",
                2021,
                2000,
                true,
                3
                );

            Truck truck1 = new Truck("DEF313", "Mitsubishi", "ModelNya", 2010, 4000, true, 4);
            Truck truck2 = new Truck("JKL890", "Hina", "Model2", 2009, 2000, true, 3.5);
            Motorcycle motor1 = new Motorcycle("IOU907", "Kawasaki", "Z1000", 2022, 3500, true, false);
            Motorcycle motor2 = new Motorcycle("VBN", "BrandKano", "NWOW", 2019, 2000, true, true);

            Customer jaiden = new Customer("Jaiden", 0909123);
            Customer jack = new Customer("Jack", 56789);
            RentalSystem rs = new RentalSystem();
            rs.AddVehicle(car1);
            rs.AddVehicle(car2);
            rs.AddVehicle(truck1);
            rs.AddVehicle(truck2);
            rs.AddVehicle(motor1);
            rs.AddVehicle(motor2);
            rs.DisplayAvailableVehicles();
            rs.RentVehicle(car1, jaiden);
            rs.RentVehicle(truck2, jack);
            rs.RentVehicle(motor1, jaiden);
            rs.DisplayRentedVehicles();
        }
    }
}
