﻿

using System;
using System.Globalization;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
class CodingChallenges()
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to my Coding Challenge program. There will be a variety of different functions you will have to choose from. Please pick one.");
            ChooseFunction();
        }
    }

    public static int MinuteConvert (int minutes)
    {
        return ( minutes * 60 ) ;  
    }

    public static int AddOne(int a)
    { return( a + 1 ) ; }

    public static int FindPower(int voltage, int current)
    {
        return voltage * current ;
    }

    public static int YearsToDays(int years)
    {
        return years * 365;
    }

    public static bool IsLeapYear(int year)
    {
        if ((year/4) is int)
        {
            return true;
        }
        else if ((year/100) is int && ((year/400) is int))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static float triArea(float h, float b)
    {
        return (h * b)/2 ;
    }

    public static bool lessThanOrEqualToZero(int number)
    {
        if (number <= 0)
        {
            return true;
        }
        else { return false; }
    }

    public static void ChooseFunction()
    {
        string[] functions =
        {
            "Sum", "MinuteConvert", "AddOne", "FindPower", "YearsToDays", "IsLeapYear", "TriangleArea", "LessThanOrEqualToZero", "SumLessThan100" , 
            "TwoEqualNumbers" , "AddSomething" , "ReverseBool" , "HoursToSeconds", "FindAngleSum", "AddEdabit" , "CheckIfBothTrue" , "BasketballPoints" , "FindPerimeter" , "SayHello!", 
            "AnimalLegs" , "FootballPoints" , "FindMonth" , "MinAndMax", "CensorString" , "AbsoluteSum" , "FindExponent" , "MultiplyByLength" , "HammingDistance", "NameSwitch" , 
            "SmallestNumber" , "Factorial" , "VowelCount" , "Exit"
        };



        for (int i = 0; i < functions.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + functions[i]);
        }

        var chosenFunction = Console.ReadLine();
        int chosenFunctionInt;
        while (!int.TryParse(chosenFunction, out chosenFunctionInt) || (chosenFunctionInt - 1 >= functions.Length) || (chosenFunctionInt - 1 < 0))
        {
            Console.WriteLine("Not a function, please try again.");
            chosenFunction = Console.ReadLine();
        }

        chosenFunctionInt -= 1;
        Console.WriteLine("You have chosen " + functions[chosenFunctionInt]);

        if (chosenFunctionInt == 0) { SumFunction(); }
        else if (chosenFunctionInt == 1) { MinuteConversion(); }
        else if (chosenFunctionInt == 2) { AddOneFunction(); }
        else if (chosenFunctionInt == 3) { FindPowerFunction(); }
        else if (chosenFunctionInt == 4) { YearsToDaysFunction(); }
        else if (chosenFunctionInt == 5) { FindLeapYearFunction(); }
        else if (chosenFunctionInt == 6) { TriAreaFunction(); }
        else if (chosenFunctionInt == 7) { LessThanOrEqualToZeroFunction(); }
        else if (chosenFunctionInt == 8) { LessThan100(); }
        else if (chosenFunctionInt == 9) { IsEqual(); }
        else if (chosenFunctionInt == 10) { GiveMeSomething(); }
        else if (chosenFunctionInt == 11) { ReverseTheBool(); }
        else if (chosenFunctionInt == 12) { HoursToSeconds(); }
        else if (chosenFunctionInt == 13) { FindAnglePolygon(); }
        else if (chosenFunctionInt == 14) { AddEdabit();  }
        else if (chosenFunctionInt == 15) { CheckIfBothTrue(); }
        else if (chosenFunctionInt == 16) { BBallPoints(); }
        else if (chosenFunctionInt == 17) { FindPerimeter(); }
        else if (chosenFunctionInt == 18) { HelloName(); }
        else if (chosenFunctionInt == 19) { AnimalLegs(); }
        else if (chosenFunctionInt == 20) { FootBallPoints(); }
        else if (chosenFunctionInt == 21) { FindMonth();  }
        else if (chosenFunctionInt == 22) { MinAndMax(); }
        else if (chosenFunctionInt == 23) { Censorship(); }
        else if (chosenFunctionInt == 24) { AbsoluteSum(); }
        else if (chosenFunctionInt == 25) { CalculateExponent(); }
        else if (chosenFunctionInt == 26) { MultiplyByLength();  }
        else if (chosenFunctionInt == 27) { HammingDistance(); }  
        else if (chosenFunctionInt == 28) { NameShuffle(); }
        else if (chosenFunctionInt == 29) { SmallestNum(); }
        else if (chosenFunctionInt == 30) { Factorial(); }
        else if (chosenFunctionInt == 31) { VowelCount(); }
 
        else if (chosenFunctionInt == functions.Length) { Environment.Exit(1); }
    }

    public static void SumFunction ()
    {
        Console.WriteLine("We are going to use the number adder called SUM. Please input two numbers for us to add. \n");
        // \n makes the next line go down. Put it at the end of the string.

        var number1 = Console.ReadLine(); // Console.ReadLine lets the user input a command.
        int number1int;
        while (!int.TryParse(number1, out number1int))
        {
            Console.WriteLine("Error: Please input a number.");
            number1 = Console.ReadLine();
        }

        Console.WriteLine("Now please input a second number.");

        var number2 = Console.ReadLine();
        int number2int;
        while (!int.TryParse(number2, out number2int))
        {
            Console.WriteLine("Error: Please input a number.");
            number2 = Console.ReadLine();
        }

        Console.WriteLine("The sum of the number " + number1 + " and the number " + number2 + " is equal to: " + (number1int + number2int) + "\n\n");
    }

    public static void MinuteConversion ()
    {
        Console.WriteLine("Now we are going to use the Minute Conversion system. It will find how many seconds are in minutes. \n");
        Console.WriteLine("Please input a number for minutes.");

        var minuteCount = Console.ReadLine();
        int minutesInt;
        while (!int.TryParse(minuteCount, out minutesInt))
        {
            Console.WriteLine("Error: Please input a number.");
            minuteCount = Console.ReadLine();
        }

        Console.WriteLine("The number of seconds inside " + minutesInt + " minutes is " + MinuteConvert(minutesInt) + "\n\n");
    }

    public static void AddOneFunction()
    {
        Console.WriteLine("Now we are using the function that adds one to any number you input.\n");
        Console.WriteLine("Please input a number.");

        var firstNumber = Console.ReadLine();
        int firstNumberint = int.Parse(firstNumber);

        Console.WriteLine("The number " + firstNumberint + " plus 1 is equal to: " + AddOne(firstNumberint) + "\n\n");
    }

    public static void FindPowerFunction()
    {
        Console.WriteLine("Now we are using the function that finds the power of an inputted voltage and current. \n");
        Console.WriteLine("Please input a voltage.");
        var voltageNum = Console.ReadLine();
        int voltageNumint = int.Parse(voltageNum);
        Console.WriteLine("Please input a current.");
        var currentNum = Console.ReadLine();
        int currentNumint = int.Parse(currentNum);
        Console.WriteLine("The power of " + voltageNumint + " volts and " + currentNumint + " amps is " + FindPower(voltageNumint, currentNumint) + " watts. \n\n");
    }

    public static void YearsToDaysFunction()
    {
        Console.WriteLine("Now we are using the function that finds the amount of days in a given amount of years. \n");
        Console.WriteLine("Please input a number of years.");
        var years = Console.ReadLine();
        int yearsInt = int.Parse(years);
        Console.WriteLine("The number of days in " + years + " years is " + YearsToDays(yearsInt) + "\n\n");
    }

    public static void FindLeapYearFunction ()
    {
        Console.WriteLine("Now we are using the function that finds if a particular year is a leap year.\n");
        Console.WriteLine("Please input a year.");
        var LeapYear = Console.ReadLine();
        int LeapYearInt = int.Parse(LeapYear);
        Console.WriteLine("The statement that the year " + LeapYearInt + " is a leap year is " + IsLeapYear(LeapYearInt) + "\n\n");
    }

    public static void TriAreaFunction ()
    {
        Console.WriteLine("Now we are using the function that finds the area of a triangle.\n");
        Console.WriteLine("Please input a base.");
        var baselength = Console.ReadLine();
        int baselengthint = int.Parse(baselength);
        Console.WriteLine("Please input a height.");
        var height = Console.ReadLine();
        int heightInt = int.Parse(height);
        Console.WriteLine("The area of a triangle with a base length of " + baselengthint + " units and height of " + heightInt + " units is " + triArea(heightInt, baselengthint) + " units squared.\n\n");
    }

    public static void LessThanOrEqualToZeroFunction ()
    {
        Console.WriteLine("Now we are using the function that finds if an inputted number is less than or equal to zero.\n");
        Console.WriteLine("Please input a number.");
        var checklessthan0 = Console.ReadLine();
        int checklessthan0int = int.Parse(checklessthan0);
        Console.WriteLine("The statement " + checklessthan0int + " is less than or equal to 0 is " + lessThanOrEqualToZero(checklessthan0int) + "\n\n");
    }

    public static void LessThan100()
    {
        Console.WriteLine("We are going to use the Less than 100 function, finding if a sum of two numbers is less than or equal to 100.\n Please input two numbers for us to add. \n");
        // \n makes the next line go down. Put it at the end of the string.

        var number1 = Console.ReadLine(); // Console.ReadLine lets the user input a command.
        int number1int;
        while (!int.TryParse(number1, out number1int))
        {
            Console.WriteLine("Error: Please input a number.");
            number1 = Console.ReadLine();
        }

        Console.WriteLine("Now please input a second number.");

        var number2 = Console.ReadLine();
        int number2int;
        while (!int.TryParse(number2, out number2int))
        {
            Console.WriteLine("Error: Please input a number.");
            number2 = Console.ReadLine();
        }

        int addedint = (number1int + number2int);
        if (addedint < 100)
        {
            Console.WriteLine("The sum of the number " + number1 + " and the number " + number2 + " is equal to: " + (addedint) + ". The statement that this number is less than or equal to 100 is TRUE.\n\n");
        }
        else
        {
            Console.WriteLine("The sum of the number " + number1 + " and the number " + number2 + " is equal to: " + (addedint) + ". The statement that this number is less than or equal to 100 is FALSE.\n\n");
        }
    }

    public static void IsEqual()
    {
        Console.Write("We are going to use the IsEqual function, finding if two numbers are equal.\n Please input two numbers for us to compare. \n");
        var number1 = (Console.ReadLine());
        int number1int;
        while (!int.TryParse(number1, out number1int))
        {
            Console.WriteLine("Error: Please input a number.");
            number1 = Console.ReadLine();
        }

        Console.WriteLine("Now please input a second number.");

        var number2 = Console.ReadLine();
        int number2int;
        while (!int.TryParse(number2, out number2int))
        {
            Console.WriteLine("Error: Please input a number.");
            number2 = Console.ReadLine();
        }

        if (number1int == number2int)
        {
            Console.WriteLine("The two numbers " + number1int + " and the number " + number2int + " are equal.");
        }
        else
        {
            Console.WriteLine("The two numbers " + number1int + " and the number " + number2int + " are unequal.");
        }
    }

    public static void GiveMeSomething()
    {
        Console.WriteLine("We are going to use the function that adds the word 'something' before anything you type.\n");
        Console.WriteLine("Please write literally anything.");
        var words = Console.ReadLine();
        Console.WriteLine("something " + words);
    }

    public static void ReverseTheBool()
    {
        Console.WriteLine("We are going to use the function that reverses a truth or a lie.\n");
        Console.WriteLine("Type in either [true] or [false].");
        var boolean = Console.ReadLine();
        bool check;

        while (!bool.TryParse(boolean, out check))
        {
            Console.WriteLine("Invalid input. Please try again.");
            boolean = Console.ReadLine();
        }

        string trueString = "true";
        string falseString = "false";

        if (boolean.Contains(trueString))
        {
            check = true;
            Console.WriteLine(ReverseIt(check));
        }
        else if (boolean.Contains(falseString))
        {
            check = false;
            Console.WriteLine(ReverseIt(check));
        }

        static bool ReverseIt(bool bool1)
        {
            return !bool1;
        }

    }

    public static void HoursToSeconds()
    {
        Console.WriteLine("We are going to use the function that finds out how many seconds are in a given amount of hours.\n");
        Console.WriteLine("Please input a number.");

        var hours = Console.ReadLine();
        float hoursFloat;

        while (!float.TryParse(hours, out hoursFloat))
        {
            Console.WriteLine("Invalid input. Please try again.");
            hours = Console.ReadLine();
        }

        Console.WriteLine("The amount of seconds in " + hours + " hours is " + (hoursFloat * 3600));
    }

    public static void FindAnglePolygon()
    {
        Console.WriteLine("We are going to use the function that finds out the sum of internal angles of a polygon with an n amount of sides.\n");
        Console.WriteLine("Please input a number for n.");

        var sides = Console.ReadLine();
        int sidesInt;

        while(!int.TryParse(sides, out sidesInt) || int.Parse(sides) <= 2)
        {
            Console.WriteLine("Invalid input. Please try again.");
            sides = Console.ReadLine();
        }

        Console.WriteLine("The sum of the internal angles in a " + sidesInt + "-sided polygon is " + ((sidesInt - 2) * 180) + " degrees.\n");
    }

    public static void AddEdabit()
    {
        Console.WriteLine("We are going to use the function that adds the word 'Edabit' to anything you input.\n");
        Console.WriteLine("Please input anything.");

        var name = Console.ReadLine();
        Console.WriteLine(name + "Edabit.\n");
    }

    public static void CheckIfBothTrue()
    {
        Console.WriteLine("We are going to use the function that takes two boolean values and returns true if both are true.\n");
        Console.WriteLine("Type in either [true] or [false].");
        var boolean1 = Console.ReadLine();
        bool check;

        while (!bool.TryParse(boolean1, out check))
        {
            Console.WriteLine("Invalid input. Please try again.");
            boolean1 = Console.ReadLine();
        }

        string trueString = "true";
        string falseString = "false";

        if (boolean1.Contains(trueString))
        {
            check = true;
        }
        else if (boolean1.Contains(falseString))
        {
            check = false;
        }

        Console.WriteLine("Please type in another [true] or [false].");
        var boolean2 = Console.ReadLine();
        bool check2;

        while (!bool.TryParse(boolean2, out check2))
        {
            Console.WriteLine("Invalid input. Please try again.");
            boolean2 = Console.ReadLine();
        }

        if (boolean2.Contains(trueString))
        {
            check2 = true;
        }
        else if (boolean2.Contains(falseString))
        {
            check2 = false;
        }

        Console.WriteLine("And(" + check + ", " + check2 + ") -> " + CheckBools(check, check2) + "\n\n");

        static bool CheckBools(bool bool1, bool bool2)
        {
            if (bool1 == true && bool2 == true)
            {
                return true;
            }
            else if (bool1 == false && bool2 == false)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }

    static void BBallPoints()
    {
        Console.WriteLine("We are going to use the function that finds the amount of 2 and 3 pointers you shot (assuming you make all buckets) and adds up all the points.\n");
        Console.WriteLine("How many 2 pointers did you make?");

        var twoPointers = Console.ReadLine();
        float twoPointersInt;

        while (!float.TryParse(twoPointers, out twoPointersInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            twoPointers = Console.ReadLine();
        }

        Console.WriteLine("How many 3 pointers did you make?");

        var threePointers = Console.ReadLine();
        float threePointersInt;

        while (!float.TryParse(threePointers, out threePointersInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            threePointers = Console.ReadLine();
        }

        Console.WriteLine("Points: ([" + twoPointersInt + "] 2-pointers, [" + threePointersInt + "] 3-pointers" + ") -> " + ((twoPointersInt * 2) + (threePointersInt * 3)));
    }

    static void FindPerimeter()
    {
        Console.WriteLine("We are going to use the function that finds the perimeter of a rectangle in cm.\n");
        Console.WriteLine("Enter length");

        var length = Console.ReadLine();
        float lengthInt;

        while (!float.TryParse(length, out lengthInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            length = Console.ReadLine();
        }

        Console.WriteLine("Enter width");

        var width = Console.ReadLine();
        float widthInt;

        while (!float.TryParse(width, out widthInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            width = Console.ReadLine();
        }

        Console.WriteLine("The perimeter with dimensions(" + lengthInt + " cm, " + widthInt + " cm) is = " + (lengthInt * 2 + widthInt * 2) + "cm.\n\n");
    }

    static void HelloName()
    {
        Console.WriteLine("We are going to use the function that says hello to you!\n");
        Console.WriteLine("What's your name?");

        var name = Console.ReadLine();
        Console.WriteLine("heyyyyy " + name + " ! :D\n\n");
    }

    static void AnimalLegs()
    {
        int chickenLegs = 2;
        int cowLegs = 4;
        int pigLegs = 4;

        Console.WriteLine("We are going to use the function that finds the total amount of legs in a collection of animals.\n");
        Console.WriteLine("How many chickens are there?");

        var chicken = Console.ReadLine();
        float chickensInt;

        while (!float.TryParse(chicken, out chickensInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            chicken = Console.ReadLine();
        }

        Console.WriteLine("How many cows are there?");

        var cow = Console.ReadLine();
        float cowsInt;

        while (!float.TryParse(cow, out cowsInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            cow = Console.ReadLine();
        }

        Console.WriteLine("How many pigs are there?");

        var pig = Console.ReadLine();
        float pigsInt;

        while (!float.TryParse(pig, out pigsInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            pig = Console.ReadLine();
        }

        Console.WriteLine("With " + chickensInt + " chickens, " + cowsInt + " cows, and " + pigsInt + " pigs, there are a total of " + ((chickensInt * chickenLegs) + (cowsInt * cowLegs) + (pigsInt * pigLegs)) + " legs.");

    }

    static void FootBallPoints()
    {
        int winPoints = 3;
        int drawPoints = 1;
        int lossPoints = 0;

        Console.WriteLine("We are going to use the function that finds the total amount of points a football team got in a football game.\n");
        Console.WriteLine("How many wins were there?");

        var wins = Console.ReadLine();
        float winsInt;

        while (!float.TryParse(wins, out winsInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            wins = Console.ReadLine();
        }

        Console.WriteLine("How many draws were there?");

        var draws = Console.ReadLine();
        float drawsInt;

        while (!float.TryParse(draws, out drawsInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            draws = Console.ReadLine();
        }

        Console.WriteLine("How many losses were there?");

        var losses = Console.ReadLine();
        float lossesInt;

        while (!float.TryParse(losses, out lossesInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            losses = Console.ReadLine();
        }

        Console.WriteLine("With " + winsInt + " wins, " + drawsInt + " draws, and " + lossesInt + " losses, there are a total of " + ((winsInt * winPoints) + (drawsInt * drawPoints) + (lossesInt * lossPoints)) + " points.\n\n");

    }

    static void FindMonth()
    {
        Console.WriteLine("We are going to use the function that finds the month based on the corresponding number that you will input.\n");
        Console.WriteLine("Input a month number.");

        string[] monthIndex = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        var monthNum = Console.ReadLine();
        int monthNumInt;
        while (!int.TryParse(monthNum, out monthNumInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            monthNum = Console.ReadLine();
        }

        while (monthNumInt >= 13 || monthNumInt <= 0)
        {
            Console.WriteLine("Invalid input. Please try again.");
            monthNum = Console.ReadLine(); monthNumInt = int.Parse(monthNum);
        }

        Console.WriteLine((monthNumInt) + " corresponds to " + monthIndex[monthNumInt - 1] + "\n\n");
    }

    static void MinAndMax()
    {
        Console.WriteLine("We are going to use the function that finds the minimum and maximum numbers in an array.\n");
        Console.WriteLine("How many numbers are going to be in the array?");

        var numbers = Console.ReadLine();
        int amountNumbersInt;
        while (!int.TryParse(numbers, out amountNumbersInt) || amountNumbersInt <= 0)
        {
            Console.WriteLine("Invalid input, please input a whole number.");
            numbers = Console.ReadLine();
        }

        float[] listOfNumbers = new float[amountNumbersInt];

        Console.WriteLine("Please fill out the list with the amount of numbers you assigned the array.");
        for (int i = 0; i < listOfNumbers.Length; i++)
        {
            var newNumber = Console.ReadLine();
            while (!float.TryParse(newNumber, out listOfNumbers[i]))
            {
                Console.WriteLine("Please input a number.");
                newNumber = Console.ReadLine();
            }
        }

        float minimum = listOfNumbers.Min();
        float maximum = listOfNumbers.Max();

        Console.WriteLine("The minimum is " + minimum + " and the maximum is " + maximum + ".\n\n");
    }

    static void Censorship()
    {
        Console.WriteLine("This function is going to censor your values, l*k* th*s!");
        Console.WriteLine("Please input anything, preferably letters.");

        var input = Console.ReadLine();
        while (input == null)
        {
            Console.WriteLine("Please make an input.");
            input = Console.ReadLine();
        }
        string firstInput = input;

        List<char> input1List = new List<char>();

        for (int i = 0; i < firstInput.Length; i++)
        {
            input1List.Add(firstInput[i]);
        }

        string vowels = "AEIOUaeiou";
        List<char> vowelsList = new List<char>();

        for (int i = 0; i < vowels.Length; i++)
        {
            vowelsList.Add(vowels[i]);
        }

        string modifiedString = "";
        string censoredVowels = "";

        for (int i = 0; i < input1List.Count; i++)
        {
            for (int j = 0; j < vowelsList.Count; j++)
            {
                if (vowels[j] == input1List[i])
                {
                    censoredVowels += vowels[j];
                    modifiedString += "*";
                }
            }
            modifiedString += input1List[i];
        }

        Console.WriteLine(firstInput + " -> (" + modifiedString + ", " +  censoredVowels + ")\n\n");

    }

    static void AbsoluteSum()
    {
        Console.WriteLine("We are going to use the function that finds the sum of an array and then shows the absolute value of that sum.\n");
        Console.WriteLine("How many numbers are going to be in the array?");

        var numbers = Console.ReadLine();
        int amountNumbersInt;
        while (!int.TryParse(numbers, out amountNumbersInt) || amountNumbersInt <= 0)
        {
            Console.WriteLine("Invalid input, please input a whole number.");
            numbers = Console.ReadLine();
        }

        float[] listOfNumbers = new float[amountNumbersInt];

        Console.WriteLine("Please fill out the list with the amount of numbers you assigned the array.");
        for (int i = 0; i < listOfNumbers.Length; i++)
        {
            var newNumber = Console.ReadLine();
            while (!float.TryParse(newNumber, out listOfNumbers[i]))
            {
                Console.WriteLine("Please input a number.");
                newNumber = Console.ReadLine();
            }
        }

        string AllValues = "";

        for (int i = 0; i < listOfNumbers.Length; i++)
        {
            AllValues += listOfNumbers[i] + ",";
            listOfNumbers[i] = MathF.Abs(listOfNumbers[i]);
        }

        float sumValue = 0;
        
        for (int i = 0; i < listOfNumbers.Length; i++)
        {
            sumValue += listOfNumbers[i];
        }
        Console.WriteLine("The sum of all your numbers(" + AllValues + ") is = " + sumValue);

    }

    static void CalculateExponent()
    {
        Console.WriteLine("We are going to use the function that finds the value of a base number to an exponent number.\n");
        Console.WriteLine("Input a base number.");

        var baseNum = Console.ReadLine();
        float baseNumInt;
        while (!float.TryParse(baseNum, out baseNumInt))
        {
            Console.WriteLine("Invalid input, please input a whole number.");
            baseNum = Console.ReadLine();
        }

        Console.WriteLine("Input an exponent number.");
        var exponent = Console.ReadLine();
        float exponentInt;
        while (!float.TryParse(exponent, out exponentInt))
        {
            Console.WriteLine("Invalid input, please input a whole number.");
            exponent = Console.ReadLine();
        }

        Console.WriteLine("The number " + baseNumInt + " raised to the exponent " + exponentInt + " is equal to " + MathF.Pow(baseNumInt, exponentInt) +"\n\n");
    }

    static void MultiplyByLength()
    {
        Console.WriteLine("We are going to use the function that multiplies each value in an array by the length of the array.\n");
        Console.WriteLine("How many numbers are going to be in the array?");

        var numbers = Console.ReadLine();
        int amountNumbersInt;
        while (!int.TryParse(numbers, out amountNumbersInt) || amountNumbersInt <= 0)
        {
            Console.WriteLine("Invalid input, please input a whole number.");
            numbers = Console.ReadLine();
        }

        float[] listOfNumbers = new float[amountNumbersInt];

        Console.WriteLine("Please fill out the list with the amount of numbers you assigned the array.");
        for (int i = 0; i < listOfNumbers.Length; i++)
        {
            var newNumber = Console.ReadLine();
            while (!float.TryParse(newNumber, out listOfNumbers[i]))
            {
                Console.WriteLine("Please input a number.");
                newNumber = Console.ReadLine();
            }
        }

        string AllFirstValues = "";
        string AllMultipliedValues = "";

        for (int i = 0; i < listOfNumbers.Length; i++)
        {
            AllFirstValues += listOfNumbers[i] + ",";
            listOfNumbers[i] *= amountNumbersInt;
            AllMultipliedValues += listOfNumbers[i] + ",";
        }

        Console.WriteLine("The values you inputted (" + AllFirstValues + ") were multiplied to become (" + AllMultipliedValues + ")\n\n");

    }

    static void HammingDistance()
    {
        Console.WriteLine("This function finds the difference between 2 strings.");
        Console.WriteLine("Please input the first string.");
        var input = Console.ReadLine();
        while (input ==  null)
        {
            Console.WriteLine("Please make an input.");
            input = Console.ReadLine();
        }
        string firstInput = input;

        Console.WriteLine("Please input the second string (MUST BE SAME LENGTH AS FIRST STRING).");
        var input2 = Console.ReadLine();
        while (input2.Length != input.Length || input2 == null)
        {
            Console.WriteLine("Please make an input.");
            input2 = Console.ReadLine();
        }
        string secondInput = input2;

        int stringLengthDif = input.Length - input2.Length;
        int difference = 0;

        List<char> input1List = new List<char>(); 
        List<char> input2List = new List<char>();

        for (int i =0; i < firstInput.Length; i++)
        {
            input1List.Add(firstInput[i]);
        }
        for (int i =0; i < secondInput.Length; i++)
        {
            input2List.Add(secondInput[i]);
        }
        
        
        for (int i = 0; i < input1List.Count; i++)
        {
            if (input1List[i] != input2List[i])
            {
                difference++;
            }
        }


        Console.WriteLine(input + ", " + input2 + " -> " + difference);
    }

    static void NameShuffle()
    {
        Console.WriteLine("This function is going to switch yoour first and last name.");
        Console.WriteLine("Please input first name.");

        var firstName = Console.ReadLine();

        Console.WriteLine("Please input last name.");

        var lastName = Console.ReadLine();

        Console.WriteLine("The name " + firstName + " " + lastName + " switched is " + lastName + " " + firstName + ".\n\n");
    }

    static void SmallestNum()
    {
        Console.WriteLine("We are going to use the function that finds the smallest number in two inputs.\n");
        Console.WriteLine("Please input the first number.");

        var firstInput = Console.ReadLine();
        float firstInputInt;

        while (!float.TryParse(firstInput, out firstInputInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            firstInput = Console.ReadLine();
        }

        Console.WriteLine("Please input the second number.");

        var secondInput = Console.ReadLine();
        float secondInputInt;

        while (!float.TryParse(secondInput, out secondInputInt))
        {
            Console.WriteLine("Invalid input. Please try again.");
            secondInput = Console.ReadLine();
        }

        if (firstInputInt > secondInputInt)
        {
            Console.WriteLine("The smallest number is " + secondInputInt);
        }
        if (firstInputInt < secondInputInt)
        {
            Console.WriteLine("The smallest number is " + firstInput);
        }
        if (firstInputInt == secondInputInt)
        {
            Console.WriteLine("Both numbers are the same.");
        }
    }

    static void Factorial()
    {
        Console.WriteLine("We are going to use the function that finds the value of a base number and factorial it.\n");
        Console.WriteLine("Input a base number.");

        var baseNum = Console.ReadLine();
        float baseNumInt;

        while (!float.TryParse(baseNum, out baseNumInt))
        {
            Console.WriteLine("Invalid input, please input a whole number.");
            baseNum = Console.ReadLine();
        }

        float factoredBase = baseNumInt;

        for (int i = 1; i < (baseNumInt - 1); i++)
        {
            factoredBase *= (baseNumInt - i);
        }

        Console.WriteLine("The factorial of " + baseNumInt + " is " +  factoredBase + "\n\n");
    }

    static void VowelCount()
    {
        Console.WriteLine("This function finds the amount of vowels in a string.");
        Console.WriteLine("Please input the first string.");
        var input = Console.ReadLine();
        while (input == null)
        {
            Console.WriteLine("Please make an input.");
            input = Console.ReadLine();
        }
        string firstInput = input;

        List<char> input1List = new List<char>();

        for (int i = 0; i < firstInput.Length; i++)
        {
            input1List.Add(firstInput[i]);
        }

        string vowels = "AEIOUaeiou";
        List<char> vowelsList = new List<char>();

        for (int i = 0; i < vowels.Length; i++)
        {
            vowelsList.Add(vowels[i]);
        }


        int vowelCount = 0;

        for (int i = 0; i < input1List.Count; i++)
        {
            for (int j = 0; j < vowelsList.Count; j++)
            {
                if (vowels[j] == input1List[i]) { vowelCount++; }
            }
        }

        Console.WriteLine("The number of vowels in [" + input + "] is " + vowelCount + ".\n\n");
    }
}