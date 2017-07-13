using System;

namespace assignment5
{
    public class Animal
{

}
public class Machines
{

}
public class Automobiles : Machines
{

}
public class Vehicle: Automobiles
{

}
public class Car :Vehicle
{

}

class Program
{
    static void Main(string [] args)
    {
        Animal animal = new Animal();
        Machines machines = new Machines();
        Automobiles automobiles = new Automobiles();
        Vehicle vehicle = new Vehicle();
        Car car = new Car();
        
     
      // calling the methods in class Method
      Method i = new Method();
      i.operation(typeof(Car)); // To get the inheritance hierarchies
      i.comparing(car,typeof(Animal)); // To compare each base type with the specified type
    

       }

       
}

    }




