
using System;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
            "TwoEqualNumbers" , "AddSomething" , "ReverseBool" , "HoursToSeconds", "FindAngleSum", "AddEdabit" , "CheckIfBothTrue" , "Exit"
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
}