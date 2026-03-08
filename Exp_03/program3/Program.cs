//using System;

//class Bird
//{
//    public virtual void Fly()
//    {
//        Console.WriteLine("Bird is flying");
//    }
//}

//class Sparrow : Bird
//{
//    public override void Fly()
//    {
//        Console.WriteLine("Sparrow is flying");
//    }
//}

//class Ostrich : Bird
//{
//    public override void Fly()
//    {
//        // Violates LSP
//        throw new Exception("Ostrich cannot fly");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Bird bird1 = new Sparrow();
//        bird1.Fly();   

//        Bird bird2 = new Ostrich();
//        bird2.Fly();  
//    }
//}


using System;

// Base class with only common behavior
abstract class Bird
{
    public abstract void Eat();
}

// Interface for flying behavior
interface IFlyingBird
{
    void Fly();
}

// Flying bird
class Sparrow : Bird, IFlyingBird
{
    public override void Eat()
    {
        Console.WriteLine("Sparrow is eating");
    }

    public void Fly()
    {
        Console.WriteLine("Sparrow is flying");
    }
}

// Non-flying bird
class Ostrich : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Ostrich is eating");
    }
}

class Program
{
    static void Main()
    {
        // Bird behavior
        Bird sparrow = new Sparrow();
        sparrow.Eat();

        Bird ostrich = new Ostrich();
        ostrich.Eat();

        // Flying behavior only for flying birds
        IFlyingBird flyingBird = new Sparrow();
        flyingBird.Fly();
    }
}
