using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Truck 
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
        public Truck() { }

        public Truck (string brand, string model, double weigth)
        {
            Brand = brand;
            Model = model;
            Weight = weigth;
        }
    }

    public class Car 
    { 
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }

        public Car () { }

        public Car (string brand , string model, double horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }


    }

    public class Catalog 
    {
        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

       


    }



