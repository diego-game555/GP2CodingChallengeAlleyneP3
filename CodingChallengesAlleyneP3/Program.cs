using System;
using System.ComponentModel;

class Challenges
{
    let functionArray = [Sum, Convert, PlusOne, CircuitPower, CalcAge, triArea, lessThanOrEqualToZero];
   
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my coding challenge program! There will be a variety of different funtion programs to choose from. Please pick one");
        let fun = functionArray[2]();

        Console.WriteLine("Today we are going to use the number adder function called SUM. Please input two numbers for us to add. \n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Awesome! Please input a 2nd number");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        Console.WriteLine("the sum of the number: " + number1 + " and the number: " + number2 + " is equal to:" + Sum(number1int, number2int));

        Console.WriteLine("Let's try converting minutes to seconds. \nGive me a number to convert from minutes to seconds");

        var number3 = Console.ReadLine();
        int number3int = int.Parse(number3);

        Console.WriteLine(number3 + " minutes converted to seconds is: " + Convert(number3int));

        Console.WriteLine("Let's try adding a number by one. \nPlease input a number to add by one");

        var number4 = Console.ReadLine();
        int number4int = int.Parse(number4);

        Console.WriteLine(number4 + " plus one is: " + PlusOne(number4int));

        Console.WriteLine("Let's calculate the power using a voltage and current. \nPlease enter the voltage");

        var number5 = Console.ReadLine();
        int number5int = int.Parse(number5);

        Console.WriteLine("Great, now please enter the current.");

        var number6 = Console.ReadLine();
        int number6int = int.Parse(number6);

        Console.WriteLine("The circuit power is " + CircuitPower(number5int, number6int));

        Console.WriteLine("Let's calculate how old you are in days. \nPlease enter your age");

        var number7 = Console.ReadLine();
        int number7int = int.Parse(number7);
        
        Console.WriteLine("You are " + CalcAge(number7int) + " days old");

        Console.WriteLine("Let's calculate the area of a triangle by taking the base and the height. \nWhat is the height of the triangle?");

        var number8 = Console.ReadLine();
        float number8int = float.Parse(number8);

        Console.WriteLine("Cool, now enter the base.");

        var number9 = Console.ReadLine();
        float number9int = float.Parse(number9);

        Console.WriteLine("The area of the triangle is " + triArea(number8int, number9int));

        Console.WriteLine("Let's see if a number is less than or equal to 0. \nPlease enter a number");

        var number10 = Console.ReadLine();
        int number10int = int.Parse(number10);

        Console.WriteLine("Your number is " + lessThanOrEqualToZero(number10int));

        
    }
    
    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Convert(int number3)
    {
        return number3 * 60;
    }

    public static int PlusOne(int number4)
    {
        return number4 + 1;
    }

    public static int CircuitPower(int number5, int number6)
    {
        return number5 * number6;
    }

    public static int CalcAge(int number7)
    {
        return number7 * 365;
    }

    public static float triArea(float number8, float number9)
    {
        
        return (number8 * number9) / 2;
    }

    public static bool lessThanOrEqualToZero(int number10)
    {
        return number10 <= 0;
    }
        
}

