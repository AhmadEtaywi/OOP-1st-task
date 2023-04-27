interface IMovable
{
    void MoveForward(int distance);
    void MoveBackward(int distance);
    void TurnLeft(int degrees);
    void TurnRight(int degrees);
}

abstract class Animal : IMovable
{
    public string name;
    public int age;
    public string gender;
    public double weight;
    public string diet;
    public string habitat;

    public void MoveForward(int distance)
    {
        Console.WriteLine($"{name} Moving {distance} units forward.");
    }

    public void MoveBackward(int distance)
    {
        Console.WriteLine($"{name} Moving {distance} units backward.");
    }

    public void TurnLeft(int degrees)
    {
        Console.WriteLine($"{name} Turning {degrees} degrees to the left.");
    }

    public void TurnRight(int degrees)
    {
        Console.WriteLine($"{name} Turning {degrees} degrees to the right.");
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

class Mammal : Animal
{
    public string furColor;
    public int gestationPeriod;

    public void nurse()
    {
        Console.WriteLine($"{name} is nursing its young.");
    }
}

class Bird : Animal
{
    public double wingspan;
    public bool canFly;

    public void fly()
    {
        Console.WriteLine($"{name} is flying.");
    }
}

class Reptile : Animal
{
    public bool isColdBlooded;
    public string habitatType;

    public void sunbathe()
    {
        Console.WriteLine($"{name} is sunbathing.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Mammal Deer = new Mammal();
        Deer.name = "Deer";
        Deer.age = 3;
        Deer.gender = "Female";
        Deer.weight = 90;
        Deer.diet = "grass";
        Deer.habitat = "forest";
        Deer.furColor = "reddish brown";
        Deer.gestationPeriod = 20;

        Deer.MoveForward(10);
        Deer.MoveBackward(5);
        Deer.TurnLeft(45);
        Deer.TurnRight(90);
        Deer.eat(Deer.diet);
        Deer.sleep();
        Deer.makeSound();
        Deer.nurse();

        Bird eagle = new Bird();
        eagle.name = "Eagle";
        eagle.age = 25;
        eagle.gender = "Male";
        eagle.weight = 11;
        eagle.diet = "Meat";
        eagle.habitat = "Mountain";
        eagle.wingspan = 2.3;
        eagle.canFly = true;

        eagle.MoveForward(20);
        eagle.MoveBackward(10);
        eagle.TurnLeft(90);
        eagle.TurnRight(180);
        eagle.eat("rabbit");
        eagle.sleep();
        eagle.makeSound();
        eagle.fly();

        Reptile turtle = new Reptile();
        turtle.name = "turtle";
        turtle.age = 50;
        turtle.gender = "Female";
        turtle.weight = 100;
        turtle.diet = "meat and plants";
        turtle.habitat = "water";
        turtle.isColdBlooded = true;
        turtle.habitatType = "water";

        turtle.MoveForward(5);
        turtle.MoveBackward(2);
        turtle.TurnLeft(30);
        turtle.TurnRight(60);
        turtle.eat("meat and plants");
        turtle.sleep();
        turtle.makeSound();
    }
}


