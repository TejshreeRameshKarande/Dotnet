//Print Hello world program
//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");

//        }
//    }
//}

//variables
//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string name = "Priyanka";
//            Console.WriteLine(name);

//            int myNum = 100;
//            Console.WriteLine(myNum);

//            int num;
//            num = 10;
//            Console.WriteLine(num);

//            int myNum2 = 15;
//            myNum2 = 20; // myNum is now 20
//            Console.WriteLine(myNum2);

//            int myNum3 = 5;
//            Console.WriteLine(myNum3);

//            double myDoubleNum = 5.99D;
//            Console.WriteLine(myDoubleNum);

//            char myLetter = 'D';
//            Console.WriteLine(myLetter);

//            bool myBool = true;
//            Console.WriteLine(myBool);

//            string myText = "Hello";
//            Console.WriteLine(myText);

//        }
//    }
//}


//datatypes
//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int myNum = 100000;
//            Console.WriteLine(myNum);

//            long myNum2 = 15000000000L;
//            Console.WriteLine(myNum2);

//            float myNum3 = 5.75F;
//            Console.WriteLine(myNum3);

//            double myNum4 = 19.99D;
//            Console.WriteLine(myNum4);

//        }
//    }
//}

//type casting
//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int myInt = 9;
//            double myDouble = myInt;      

//            Console.WriteLine(myInt);     
//            Console.WriteLine(myDouble);

//            double Double = 9.78;
//            int Int = (int)Double;    

//            Console.WriteLine(Double);  
//            Console.WriteLine(Int);

//            double myDouble1 = 9.78;
//            int myInt1 = (int)myDouble1;   

//            Console.WriteLine(myDouble1);  
//            Console.WriteLine(myInt1);

//        }
//    }
//}


//user inpput
//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter username:");
//            string userName = Console.ReadLine();
//            Console.WriteLine("user name : "+ userName);

//        }
//    }
//}

//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter age:");
//            int age = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Your age is: " + age);



//        }
//    }
//}



//operators

//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int x = 5;
//            int y = 3;
//            Console.WriteLine(x > y);
//            Console.WriteLine(x < y); 
//            Console.WriteLine(x >= y);
//            Console.WriteLine(x <= y);
//            Console.WriteLine(x == y);
//            Console.WriteLine(x != y);
//            Console.WriteLine(x += 2);
//            Console.WriteLine(x -= 1);
//            Console.WriteLine(y *= 2);
//            Console.WriteLine(y /= 1);

//        }
//    }
//}


//Math
//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine(Math.Max(11, 12));
//            Console.WriteLine(Math.Min(11, 12));
//            Console.WriteLine(Math.Sqrt(64));
//            Console.WriteLine(Math.Abs(-2.3));
//            Console.WriteLine(Math.Round(11.11));

//        }
//    }
//}


//if else
//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            if (200 > 400)
//            {
//                Console.WriteLine("200 is greater than 400");
//            }
//            else
//            {
//                Console.WriteLine("400 is greater than 200");
//            }

//        }
//    }
//}


//else-if
//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            int time = 22;
//            if (time < 10)
//            {
//                Console.WriteLine("Good morning.");
//            }
//            else if (time < 20)
//            {
//                Console.WriteLine("Good day.");
//            }
//            else
//            {
//                Console.WriteLine("Good evening.");
//            }

//        }
//    }
//}


//switch
//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            int day = 3;
//            switch (day)
//            {
//                case 1:
//                    Console.WriteLine("Monday");
//                    break;
//                case 2:
//                    Console.WriteLine("Tuesday");
//                    break;
//                case 3:
//                    Console.WriteLine("Wednesday");
//                    break;
//                case 4:
//                    Console.WriteLine("Thursday");
//                    break;

//            }
//        }
//    }
//}


//while loop
//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            int i = 1;
//            while (i < 10)
//            {
//                Console.WriteLine(i);
//                i++;
//            }


//        }

//    }
//}


//do-while loop
//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            int i = 1;
//            do
//            {
//                Console.WriteLine(i);
//                i++;
//            }
//            while (i < 10);


//        }

//    }
//}


//for-loop
//namespace program1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            for (int i = 1; i <= 10; i = i + 2)
//            {
//                Console.WriteLine(i);
//            }


//        }

//    }
//}

namespace program1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }


        }

    }
}


