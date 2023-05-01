using System;


namespace Animal
{
class Bird : Animal
{
    public double wingspan;
    public bool canFly;

    public void fly()
    {
        Console.WriteLine($"{name} is flying.");
    }

    public override void MoveForward(int distance)
    {
        Console.WriteLine($"{name} Moving {distance} units forward.");
    }

    public override void MoveBackward(int distance)
    {
        Console.WriteLine($"{name} Moving {distance} units backward.");
    }

    public override void TurnLeft(int degrees)
    {
        Console.WriteLine($"{name} Turning {degrees} degrees to the left.");
    }

    public override void TurnRight(int degrees)
    {
        Console.WriteLine($"{name} Turning {degrees} degrees to the right.");
    }



}
}