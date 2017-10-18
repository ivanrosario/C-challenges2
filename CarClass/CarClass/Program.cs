using System;

namespace CarClass
{
	class Car
	{
        public string model;
		public int year;
        public int numOfTires;

		//constructor
		public Car(string choice)
		{
            //constructor similar to js

			this.numOfTires = 4;
			this.year = 2017;
			this.model = choice;
		}

	}
    class Program
    {
        static void Main(string[] args)
        {
            //you must call  the name of the class before creating
            Car Car1 = new Car("lambo");
            Car Car2 = new Car("BMW");
            Car Car3 = new Car("Mustang");

            Console.WriteLine("numOftires: {0}, year: {1} , model : {2}", Car1.numOfTires, Car1.year, Car1.model);
			Console.WriteLine("numOftires: {0}, year: {1} , model : {2}", Car2.numOfTires, Car2.year, Car2.model);
			Console.WriteLine("numOftires: {0}, year: {1} , model : {2}", Car3.numOfTires, Car3.year, Car3.model);

		}
    }
	
}
