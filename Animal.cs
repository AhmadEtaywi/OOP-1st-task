namespace Animal
{
  abstract class Animal : IMovable
{
    public string name;
    public int age;
    public string gender;
    public double weight;
    public string diet;
    public string habitat;

    public virtual void  MoveForward(int distance)
    {
        Console.WriteLine(" Moving " + distance + " units forward.");
    }

    public virtual void MoveBackward(int distance)
    {
        Console.WriteLine("Moving " + distance + " units backward.");
    }

    public virtual void TurnLeft(int degrees)
    {
        Console.WriteLine( " Turning " + degrees +  " degrees to the left.");
    }

    public virtual void TurnRight(int degrees)
    {
        Console.WriteLine( " Turning " + degrees +  " degrees to the right.");
    }

    public void eat(string food)
    {
        Console.WriteLine($"{name} is eating {food}.");
    }

    public void sleep()
    {
        Console.WriteLine($"{name} is sleeping.");
    }

    public void makeSound()
    {
        Console.WriteLine($"{name} makes a sound.");
    }
}

}