﻿using System;
using System.ComponentModel;

class Challenges
{


    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my coding challenge program! There will be a variety of different funtion programs to choose from. Please pick one");
        bool continueProgram = true;
        while (continueProgram)
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Convert");
            Console.WriteLine("3. PlusOne");
            Console.WriteLine("4. CircuitPower");
            Console.WriteLine("5. CalcAge");
            Console.WriteLine("6. triArea");
            Console.WriteLine("7. lessThanOrEqualToZero");
            Console.WriteLine("8. lessThan100");
            Console.WriteLine("9. IsEqual");
            Console.WriteLine("10. GiveMeSomething");
            Console.WriteLine("12. howManySeconds");
            Console.WriteLine("13. nameString");
            Console.WriteLine("14. SumPolygon");
            Console.WriteLine("16. points");
            Console.WriteLine("17. FindPerimeter");
            Console.WriteLine("18. HelloName");
            Console.WriteLine("19. animals");
            Console.WriteLine("20. FootballPoints");
            Console.WriteLine("21. MonthName");
            Console.WriteLine("22. FindMinMax");
            Console.WriteLine("23. getAbsSum");
            Console.WriteLine("24. CalculateExponent");
            Console.WriteLine("25. MultiplyByLength");
            Console.WriteLine("26. HammingDistance");
            Console.WriteLine("27. NameShuffle");
            Console.WriteLine("28. SmallerNumber");
            Console.WriteLine("29. Factorial");
            Console.WriteLine("30. VowelCount");
            Console.WriteLine("\nPlease enter the corresponding number of your choice");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    continueProgram = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                case "1":
                    Console.WriteLine("Today we are going to use the number adder function called SUM. Please input two numbers for us to add. \n");
                    var number1 = Console.ReadLine();
                    int number1int = int.Parse(number1);
                    Console.WriteLine("Awesome! Please input a 2nd number");
                    var number2 = Console.ReadLine();
                    int number2int = int.Parse(number2);
                    Console.WriteLine("the sum of the number: " + number1 + " and the number: " + number2 + " is equal to:" + Sum(number1int, number2int));
                    break;
                case "2":
                    Console.WriteLine("Let's try converting minutes to seconds. \nGive me a number to convert from minutes to seconds");
                    var number3 = Console.ReadLine();
                    int number3int = int.Parse(number3);
                    Console.WriteLine(number3 + " minutes converted to seconds is: " + Convert(number3int));
                    break;
                case "3":
                    Console.WriteLine("Let's try adding a number by one. \nPlease input a number to add by one");
                    var number4 = Console.ReadLine();
                    int number4int = int.Parse(number4);
                    Console.WriteLine(number4 + " plus one is: " + PlusOne(number4int));
                    break;
                case "4":
                    Console.WriteLine("Let's calculate the power using a voltage and current. \nPlease enter the voltage");
                    var number5 = Console.ReadLine();
                    int number5int = int.Parse(number5);
                    Console.WriteLine("Great, now please enter the current.");
                    var number6 = Console.ReadLine();
                    int number6int = int.Parse(number6);
                    Console.WriteLine("The circuit power is " + CircuitPower(number5int, number6int));
                    break;
                case "5":
                    Console.WriteLine("Let's calculate how old you are in days. \nPlease enter your age");
                    var number7 = Console.ReadLine();
                    int number7int = int.Parse(number7);
                    Console.WriteLine("You are " + CalcAge(number7int) + " days old");
                    break;
                case "6":
                    Console.WriteLine("Let's calculate the area of a triangle by taking the base and the height. \nWhat is the height of the triangle?");
                    var number8 = Console.ReadLine();
                    float number8int = float.Parse(number8);
                    Console.WriteLine("Cool, now enter the base.");
                    var number9 = Console.ReadLine();
                    float number9int = float.Parse(number9);
                    Console.WriteLine("The area of the triangle is " + triArea(number8int, number9int));
                    break;
                case "7":
                    Console.WriteLine("Let's see if a number is less than or equal to 0. \nPlease enter a number");
                    var number10 = Console.ReadLine();
                    int number10int = int.Parse(number10);
                    Console.WriteLine("Your number is " + lessThanOrEqualToZero(number10int));
                    break;
                case "8":
                    Console.WriteLine("Let's see if the sum of two numbers is less than 100. \nPlease enter a number");
                    var number11 = Console.ReadLine();
                    int number11int = int.Parse(number11);
                    Console.WriteLine("Great, now enter a second number");
                    var number12 = Console.ReadLine();
                    int number12int = int.Parse(number12);
                    Console.WriteLine("Your numbers are " + lessThan100(number11int, number12int));
                    break;
                case "9":
                    Console.WriteLine("Let's see if two numbers are equal to each other. \nPlease enter a number");
                    var number13 = Console.ReadLine();
                    int number13int = int.Parse(number13);
                    Console.WriteLine("Cool, now enter a second number");
                    var number14 = Console.ReadLine();
                    int number14int = int.Parse(number14);
                    Console.WriteLine("These numbers are " + IsEqual(number13int, number14int));
                    break;
                case "10":
                    Console.WriteLine("Enter something: ");
                    string userInput = Console.ReadLine();
                    Console.WriteLine(GiveMeSomething(userInput));
                    break;
                case "12":
                    Console.WriteLine("Let's convert hours into seconds. \nPlease enter a number for hours");
                    var number15 = Console.ReadLine();
                    int number15int = int.Parse(number15);
                    Console.WriteLine("There are " + howManySeconds(number15int) + " seconds");
                    break;
                case "13":
                    Console.WriteLine("Enter something: ");
                    string userInput1 = Console.ReadLine();
                    Console.WriteLine(nameString(userInput1));
                    break;
                case "14":
                    Console.WriteLine("Let's calculate the sum of all angles in a polygon.\nEnter a number");
                    var number16 = Console.ReadLine();
                    int number16int = int.Parse(number16);
                    Console.WriteLine("This polygon's angles has " + SumPolygon(number16int) + " degrees");
                    break;
                case "16":
                    Console.WriteLine("Let's calculate the number of points scored in a basketball game. \nEnter the number of 2-pointers");
                    var number17 = Console.ReadLine();
                    int number17int = int.Parse(number17);
                    Console.WriteLine("Great, now enter the number of 3-pointers");
                    var number18 = Console.ReadLine();
                    int number18int = int.Parse(number18);
                    Console.WriteLine("The total number of points scored is " + points(number17int, number18int));
                    break;
                case "17":
                    Console.WriteLine("Let's calculate the perimeter of a rectangle. \nEnter the legnth");
                    var number19 = Console.ReadLine();
                    int number19int = int.Parse(number19);
                    Console.WriteLine("Great, now enter the width");
                    var number20 = Console.ReadLine();
                    int number20int = int.Parse(number20);
                    Console.WriteLine("The perimeter of the rectangle is " + FindPerimeter(number19int, number20int));
                    break;
                case "18":
                    Console.WriteLine("\nPlease enter your name");
                    string userInput2 = Console.ReadLine();
                    Console.WriteLine(HelloName(userInput2));
                    break;
                case "19":
                    Console.WriteLine("Let's count the total number of legs on animals. \nEnter the number of chickens");
                    var number21 = Console.ReadLine();
                    int number21int = int.Parse(number21);
                    Console.WriteLine("Cool, now enter the number of cows");
                    var number22 = Console.ReadLine();
                    int number22int = int.Parse(number22);
                    Console.WriteLine("Cool, now enter the number of pigs");
                    var number23 = Console.ReadLine();
                    int number23int = int.Parse(number23);
                    Console.WriteLine("The total number of legs on the animals are " + animals(number21int, number22int, number23int));
                    break;
                case "20":
                    Console.WriteLine("Let's calculate the number of football points a team has obtained so far. \nEnter the number of wins");
                    var number24 = Console.ReadLine();
                    int number24int = int.Parse(number24);
                    Console.WriteLine("Great now enter the number of draws");
                    var number25 = Console.ReadLine();
                    int number25int = int.Parse(number25);
                    Console.WriteLine("Cool now enter the number of losses");
                    var number26 = Console.ReadLine();
                    int number26int = int.Parse(number26);
                    Console.WriteLine("The total number of points is " + FootballPoints(number24int, number25int, number26int));
                    break;
                case "21":
                    Console.WriteLine("Let's choose a month, enter a number between 1 and 12:");
                    if (int.TryParse(Console.ReadLine(), out int monthNumber))
                    {
                        string result = GetMonthName(monthNumber);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "22":
                    Console.WriteLine("Enter numbers separated by spaces:");
                    string input = Console.ReadLine();

                    int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);
                    int[] result1 = FindMinMax(numbers);

                    Console.WriteLine("(" + result1[0] + ", " + result1[1] + ")");
                    break;
                case "23":
                    Console.WriteLine("Please input the numbers for the array, separated by spaces: ");
                    string input2 = Console.ReadLine();
                    int[] numbers2 = Array.ConvertAll(input2.Split(' '), int.Parse);
                    // Call the SumAbsoluteValues function
                    int sum = SumAbsoluteValues(numbers2);
                    // Display the result
                    Console.WriteLine("The sum of the absolute values is: " + sum);
                    break;
                case "24":
                    Console.WriteLine("Enter the base number: ");
                    var baseNumber = Console.ReadLine();
                    int baseNumberInt = int.Parse(baseNumber);
                    Console.WriteLine("Enter the exponent number: ");
                    var exponentNumber = Console.ReadLine();
                    int exponentNumberInt = int.Parse(exponentNumber);
                    Console.WriteLine("The result is: " + Power(baseNumberInt, exponentNumberInt));
                    break;
                case "25":
                    Console.WriteLine("Please input the numbers for the array, separated by spaces: ");
                    string input3 = Console.ReadLine();
                    int[] numbers3 = Array.ConvertAll(input3.Split(' '), int.Parse);
                    // Call the MultiplyByArrayLength function
                    int[] multipliedArray = MultiplyByArrayLength(numbers3);
                    // Display the result
                    Console.WriteLine("The multiplied array is: " + string.Join(", ", multipliedArray));
                    break;
                case "26":
                    Console.WriteLine("Please enter the first string: ");
                    string str1 = Console.ReadLine();
                    Console.WriteLine("Please enter the second string: ");
                    string str2 = Console.ReadLine();
                    int distance = HammingDistance(str1, str2);
                    Console.WriteLine("The Hamming distance between the two strings is: " + distance);
                    break;
                case "27":
                    Console.WriteLine("Enter a full name (first last): ");
                    string fullName = Console.ReadLine();
                    string swappedName = SwapNames(fullName);
                    Console.WriteLine("Swapped name: " + swappedName);
                    break;
                case "28":
                    Console.WriteLine("Enter two numbers separated by a comma");
                    string input4 = Console.ReadLine();

                    try
                    {
                        int result = SmallerNumber(input4);
                        Console.WriteLine("Smaller number: " + result);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid input"); 
                    }
                    break;
                case "29":
                    Console.WriteLine("Enter an integer: ");
                    string input5 = Console.ReadLine();
                    int number28 = int.Parse(input5);
                    int factorial = Factorial(number28);
                    Console.WriteLine("The factorial of " + number28 + " is: " + factorial);
                    break;
                case "30":
                    Console.WriteLine("Enter a word: ");
                    string input6 = Console.ReadLine();

                    int vowelCount = CountVowel(input6);

                    Console.WriteLine($"Number of vowels: {vowelCount}");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please pick a valid number");
                    break;
            }

            Console.WriteLine("\n------------------\n");
        }

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

    public static bool lessThan100(int number11, int number12)
    {
        return (number11 + number12) < 100;
    }

    public static bool IsEqual(int number13, int number14)
    {
        return number13 == number14;
    }

    public static string GiveMeSomething(string input)
    {
        return "something " + input;
    }

    public static int Add(int number0)
    {
        return number0 + 1;
    }

    public static int howManySeconds(int number15)
    {
        return number15 * 3600;
    }

    public static string nameString(string input1)
    {
        return input1 + "Edabit";
    }

    public static int SumPolygon(int number16)
    {
        return (number16 - 2) * 180;
    }

    public static int points(int number17, int number18)
    {
        return (number17 * 2) + (number18 * 3);
    }

    public static int FindPerimeter(int number19, int number20)
    {
        return (number19 * 2) + (number20 * 2);
    }

    public static string HelloName(string input2)
    {
        return "Hello " + input2;
    }

    public static int animals(int number21, int number22, int number23)
    {
        return (number21 * 2) + (number22 * 4) + (number23 * 4);
    }

    public static int FootballPoints(int number24, int number25, int number26)
    {
        return (number24 * 3) + (number25) + (number26 * 0);
    }

    public static string GetMonthName(int number27)
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        if (number27 >= 1 && number27 <= 12)
        {
            return months[number27 - 1];
        }
        else
        {
            return "Invalid number. Please choose a number between 1 and 12.";
        }
    }

    public static int[] FindMinMax(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            return new int[] { 0, 0 };
        }

        int min = numbers[0];
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return new int[] { min, max };
    }

    public static int SumAbsoluteValues(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += Math.Abs(number);
        }
        return sum;
    }

    public static int Power(int baseNumber, int exponentNumber)
    {
        int result = 1;
        for (int i = 0; i < exponentNumber; i++)
        {
            result *= baseNumber;
        }
        return result;
    }

    public static int[] MultiplyByArrayLength(int[] numbers)
    {
        int[] result = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            result[i] = numbers[i] * numbers.Length;
        }
        return result;
    }

    public static int HammingDistance(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            throw new ArgumentException("Strings must be of equal length.");
        }
        int distance = 0;
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                distance++;
            }
        }
        return distance;
    }

    public static string SwapNames(string name)
    {
        string[] names = name.Split(' ');
        if (names.Length != 2)
        {
            throw new ArgumentException("Invalid name format. Please provide a first and last name.");
        }
        return names[1] + " " + names[0];
    }

    public static int SmallerNumber(string input4)
    {
        string[] numbers3 = input4.Split(',');

        int num1a = int.Parse(numbers3[0].Trim());
        int num2a = int.Parse(numbers3[1].Trim());

        return Math.Min(num1a, num2a);
    }

    public static int Factorial(int number28)
    {
        if (number28 < 0)
        {
            throw new ArgumentException("Factorial is not defined for negative numbers.");
        }
        else if (number28 == 0)
        {
            return 1;
        }
        else
        {
            int factorial = 1;
            for (int i = 1; i <= number28; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }

    public static int CountVowel(string str5)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";

        foreach (char c in str5)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }
}

