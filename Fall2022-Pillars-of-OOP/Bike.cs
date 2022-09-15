using System;
using System.Reflection;

namespace Fall2022_Pillars_of_OOP
{
    internal class Bike : Vehicle
    {
        // Properties
        public string Brand { get; set; }

      
        // Constructor - default
        // This outlines what our default bike looks like, this DOES NOT create a new bike

        public Bike()
        {
            Brand = "Schwinn";
            Speed = 0;
            TopSpeed = 50;
            Cost = 300;
	    }

        // Methods

        public override void ChangeCost(decimal cost)
        {
            Cost = cost;
	    }


        public override string ToStringRepresentation()
        {
            return $"Brand: {Brand} \nTop Speed: {TopSpeed} \n Cost: {Cost}"; 

        }
        
        public static void RingBell ()
        {
            Console.WriteLine("Ring!");
	    }

    }
}

