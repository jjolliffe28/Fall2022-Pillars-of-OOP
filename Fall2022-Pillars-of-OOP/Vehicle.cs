using System;
namespace Fall2022_Pillars_of_OOP
{
    // Abstraction - making a generic class that can be inherited by children classes by lending functionality
    // When we use abstract on a property, we are declaring the getters and setters abstract, NOT the property itself
    internal abstract class Vehicle
    {

        // We dont need to make these properties abstract, and we can remove them from the children classes. 
        // Don't need to implement the properties in the children class because these properties are in the parent class 
        public int Speed { get; set; } 

        public  int TopSpeed { get; set; }

        public  decimal Cost { get; set; }

        // Because we used the 'abstract' keyword, we were able to leave the implementation of these methods out

        public abstract string ToStringRepresentation();

        public abstract void ChangeCost(decimal cost);

        // Just like other classes we can still implement methods
        public static void Travel(int distance)
        {
            Console.WriteLine($"You traveled {distance} miles!");
	    }
         
	    
	  
    }
}

