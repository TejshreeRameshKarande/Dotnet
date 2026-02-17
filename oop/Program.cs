//single object
class Car1
{
    string color1 = "red";

    static void Main(string[] args)
    {
        Car1 myObj = new Car1();
        Console.WriteLine(myObj.color1);
    }
}

//multiple objects
class Car2
{
    string color2 = "red";
    static void Main(string[] args)
    {
        Car2 myObj1 = new Car2();
        Car2 myObj2 = new Car2();
        Console.WriteLine(myObj1.color2);
        Console.WriteLine(myObj2.color2);
    }
}

//object created from class cars
class Car
{
    string model;
    string color;
    int year;

    static void Main(string[] args)
    {
        Car Ford = new Car();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;

        Car Opel = new Car();
        Opel.model = "Astra";
        Opel.color = "white";
        Opel.year = 2005;

        Console.WriteLine(Ford.model);
        Console.WriteLine(Opel.model);
    }
}

//constructors
class Car3
{
    public string model;

    // Create a class constructor with a parameter
    public Car3(string modelName)
    {
        model = modelName;
    }

    static void Main(string[] args)
    {
        Car3 Ford = new Car3("Mustang");
        Console.WriteLine(Ford.model);
    }
}

//access modifiers
//private
class Car4
{
    private string model = "Mustang";

    static void Main(string[] args)
    {
        Car4 myObj = new Car4();
        Console.WriteLine(myObj.model);
    }
}

//public
class Car5
{
    public string model = "Mustang";
}

class Program
{
    static void Main(string[] args)
    {
        Car5 myObj = new Car5();
        Console.WriteLine(myObj.model);
    }
}

//inheritance
class Vehicle  
{
    public string brand = "Ford"; 
    public void honk2() {     
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car6 : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field
}

class Program1
{
    static void Main(string[] args)
    {
        Car6 myCar = new Car6();

        myCar.honk2();

        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}

//Polymorphism
class Animal  // Base clas
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program3
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal(); 
        Animal myPig = new Pig();  
        Animal myDog = new Dog(); 

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
    }
}


// Abstract class
abstract class Animal2
{
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep1()
    {
        Console.WriteLine("Zzz");
    }
}

// Derived class (inherit from Animal)
class Pigs : Animal2
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program4
{
    static void Main(string[] args)
    {
        Pigs myPig = new Pigs(); // Create a Pig object
        myPig.animalSound();  // Call the abstract method
        myPig.sleep1();  // Call the regular method
    }
}


// Interface
interface IAnimal
{
    void animalSound(); // interface method 
}

// Pig "implements" the IAnimal interface
class Pig3 : IAnimal
{
    public void animalSound()
    {
       
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program5
{
    static void Main(string[] args)
    {
        Pig3 myPig = new Pig3();  // Create a Pig object
        myPig.animalSound();
    }
}


//Exception

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}




namespace MyApplication
{
    class Program2
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            checkAge(20);
        }
    }
}



//file handling
Result Size: 536 x 578
using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
    class Program6
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

            string readText = File.ReadAllText("filename.txt"); 
            Console.WriteLine(readText); 
        }
    }
}

