using System;

namespace DreamCar
{
	class Car
	{
        //what the constructor is type
		public string model;
		public int year;
		public int numOfTires;

		//constructor //parmeter are given a type before 
		public Car(string choice, int year, int numOfTires)
		{
			//constructor similar to js

            this.numOfTires = numOfTires;
            this.year = year;
			this.model = choice;
		}

    
        static void Main(string[] args)
        {
            var dreamCar = new Car("lambo", 2017, 4 );
            var hateCar = new Car("bike", 1999, 2);

            Console.WriteLine("numOftires: {0}, year: {1} , model : {2}", dreamCar.numOfTires, dreamCar.year, dreamCar.model);
            Console.WriteLine("numOftires: {0}, year: {1} , model : {2}", hateCar.numOfTires, hateCar.year, hateCar.model);
		}
    }
}



