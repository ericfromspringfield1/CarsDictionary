using System;
using System.Collections.Generic;

namespace CarsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make Model Year Price


        // car1 is an INSTANCE of the Car Class
            Car car1 = new Car(50000);
            car1.Make = "Ford";
            car1.Model = "Explorer";
            car1.Year = 1999;
            car1.Price = 1000.50;

//You can use () at the end of Car, but is not required
            Car car2 = new Car(80000)
            {
                Make = "Mazda",
                Model = "B2500",
                Price = 115.99,
                Year = 1999
            };

            Car car3 = new Car(10000)
            {
                Make = "Nissan",
                Model = "GTR",
                Price = 79999.99,
                Year = 2018    
            };
            //if you leave a property off like Model, the property will still have a value of null (or 0 if an int or double)

            List<Car> garage = new List<Car>();
            garage.Add(car1);
            garage.Add(car2);
            garage.Add(car3);



            foreach(Car car in garage) 
            {
                //We call Accelerate method from the Car.cs file 
                car.Accelerate();
                int age = car.GetAge();
                Console.WriteLine(age);

                Console.WriteLine(car.Description);

            //ca.. the Drive method and say we drove 1000 miles.
                car.Drive(1000);
            }

        }


    }
}







