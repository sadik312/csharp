// Interfaces: 
// abstract class which can only contain abstract methods and properties with empty bodies

interface IAnimal
// Good practice to use 'I' infront of interface - makes it easier to  remember it is an interface and NOT a class
{
    void animalSound(); // inerface method (does not have a body)
    void run(); // interface method (does not have a body)
}

// Pig implements IAnimal interface
class Pig : IAnimal
{
    public void animalSound()
    {
        // body of animalSound() is stated here:
        Console.WriteLine("The pig is says: oink oink");
    }
}

clas Program 
{
    static vid Main(string[] args)
    {
        Pig pigObj = new Pig(); // create Pig object
        pigObj.animalSound();
    }
}