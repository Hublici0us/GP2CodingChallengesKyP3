
using System;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
class CodingChallenges()
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Coding Challenge program. There will be a variety of different functions you will have to choose from. Please pick one.");
        ChooseFunction();
    }

    public static int Sum (int a, int b)
    {
        return( a + b ) ;
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
            "Sum", "MinuteConvert", "AddOne", "FindPower", "YearsToDays", "IsLeapYear", "TriangleArea", "LessThanOrEqualToZero", "SumLessThan100"
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
        Console.WriteLine("We are going to use the Less than 100 function, finding if a sum of two numbers is less than 100.\n Please input two numbers for us to add. \n");
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
            Console.WriteLine("The sum of the number " + number1 + " and the number " + number2 + " is equal to: " + (addedint) + ". The statement that this number is less than 100 is TRUE.\n\n");
        }
        else
        {
            Console.WriteLine("The sum of the number " + number1 + " and the number " + number2 + " is equal to: " + (addedint) + ". The statement that this number is less than 100 is FALSE.\n\n");
        }
    }
}