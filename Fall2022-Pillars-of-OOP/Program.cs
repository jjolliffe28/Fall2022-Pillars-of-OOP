using System;
using Fall2022_Pillars_of_OOP;

Car jacksCar = new Car();
jacksCar.TopSpeed = 5000;
jacksCar.Make = "Infiniti";
jacksCar.Cost = 5000;

// Cannot create Vehicle (or any abstract class) objects, but we can use them as variables
Vehicle jacksBike = new Bike();
// When in a variable of the parent class, the child only has access to the properties and methods on the parent
// meaning we cant do jacksBike.Brand
// we can write 
Console.WriteLine(jacksBike.ToStringRepresentation());

// Polymorphism allows us to store both bikes and cars in this list because they both inherit
//  the abstract class 'Vehicle'
List<Vehicle> Vehicles = new List<Vehicle>();

