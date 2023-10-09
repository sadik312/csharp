// Interfaces: 
// abstract class which can only contain abstract methods and properties with empty bodies

using System;

public interface IAnimal
// Good practice to use 'I' infront of interface - makes it easier to  remember it is an interface and NOT a class
{
    void animalSound(); // inerface method (does not have a body)
    // void run(); // interface method (does not have a body)
}

// Pig implements IAnimal interface
public class Pig : IAnimal
{
    public void animalSound()
    {
        // body of animalSound() is stated here:
        Console.WriteLine("oink oink");
    }
}

// Dog class that implements IAnimal interface
public class Dog : IAnimal
{
    public void animalSound()
    {
        Console.WriteLine("Woof woof");
    }
}

class Program 
{
    static void Main(string[] args)
    {
        Pig pigObj = new Pig(); // create Pig object
        Dog dogObj = new Dog(); // create Dog object

        // call method for each instance
        Console.WriteLine("Piggy says: ");
        pigObj.animalSound();

        Console.WriteLine("Doggy says: ");
        dogObj.animalSound();
    }
}