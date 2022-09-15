using System;
namespace Fall2022_Pillars_of_OOP
{
    internal class Car : Vehicle
    {
        // Properties 
        public string Make { get; set; }

        public string Model { get; set; } 
        
	 


        // Constructor
        public Car()
        {
            Make = "Chrysler";
            Model = "PT Cruiser";
            Speed = 0;
            TopSpeed = 150;
            Cost = -1500;
	    }
       
        // Methods
        public override void ChangeCost(decimal cost)
        {
            Cost = cost;
	    }

        public override string ToStringRepresentation()
        {
            return $"Make: {Make} \nModel {Model} \nTop Speed: {TopSpeed} \n Cost: {Cost}"; // $ allows us to directly insert variables instead of us doing String + String + String etc..

        }

        public static void HonkHorn()
        {
            Console.WriteLine("HONK!!!!");
            Console.Beep();
	    }
    }
}

