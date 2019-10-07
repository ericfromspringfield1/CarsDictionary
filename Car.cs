using System;

namespace CarsDictionary {

    class Car 
    {
        //public allows us to use this variable in any Class. Private allows it to only be available for that Class (Car)
        //get; set; I can get something and/or set it to something. 
        //get only with no set would be good for Year because you want to get the Year, but you really wouldn't want the car to be 
        // set to another year.
        // You can add functionality to get and set.
        // the underscore (_milesDriven) indicates a read-only property
        //in order to see the milesDriven while protecting the _milesDriven (no one can go in and change milesDriven)
        //OR you can do public int {get; private set;} -- easiest to do it as shown
        private int _milesDriven = 0;

        //Anytime someone calls new Car from car1, car2, or car3, the public Car() method will run. Once you add the argument startingMiles, 
        //you must enter starting miles inside the new Car () method in car1, car2, car3 in Program.cs
        public Car(int startingMiles)
        {
            _milesDriven = startingMiles;
        }

        public int totalMiles 
        {
            get
            {
                return _milesDriven;
            }
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Description 
        {
            get
            {
                return $"A {Year} {Make} {Model}";
            }
            
        }
//When we write a method that accepts an arguement, we must name it with a type. 
        public int Drive(int miles)
        {
            _milesDriven += miles;
            return _milesDriven;
        }

        public void Accelerate()
        {
            Console.WriteLine($" The {Make} {Model} goes HEY YA YAYAYAYA");
        }

        public int GetAge()
        {
         DateTime date = DateTime.Now;
         int currentYear = date.Year;
         return currentYear - Year;
        }
       

    }
}