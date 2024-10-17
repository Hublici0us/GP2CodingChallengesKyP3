
using System;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
class CodingChallenges()
{
    public static void Main(string[] args)
    {
        ChooseFunction();

        Console.WriteLine("Welcome to my Coding Challenge program. There will be a variety of different functions you will have to choose from. Please pick one.");
        Console.WriteLine("We are going to use the number adder called SUM. Please input two numbers for us to add. \n");
        // \n makes the next line go down. Put it at the end of the string.

        bool firstNumberInputted = false;
        
        var number1 = Console.ReadLine(); // Console.ReadLine lets the user input a command.
        int number1int;
        if (int.TryParse(number1, out number1int))
        {
            firstNumberInputted = true;
            number1int = int.Parse(number1); // int.Parse changes the variable # that the user inputs into a stored integer.
        }
        else
        {
            Console.WriteLine("Error: Please input a number.");
            
        }
        

        Console.WriteLine("Now please input a second number.");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        Console.WriteLine("The sum of the number " + number1 + " and the number " + number2 + " is equal to: " + Sum(number1int, number2int) + "\n\n");

        // Minute Conversion.
        Console.WriteLine("Now we are going to use the Minute Conversion system. It will find how many seconds are in minutes. \n");
        Console.WriteLine("Please input a number for minutes.");

        var minuteCount = Console.ReadLine();
        int minutesInt = int.Parse(minuteCount);

        Console.WriteLine("The number of seconds inside " + minutesInt + " minutes is " + MinuteConvert(minutesInt) + "\n\n");

        // Add One
        Console.WriteLine("Now we are using the function that adds one to any number you input.\n");
        Console.WriteLine("Please input a number.");

        var firstNumber = Console.ReadLine();
        int firstNumberint = int.Parse(firstNumber);

        Console.WriteLine("The number " + firstNumberint + " plus 1 is equal to: " + AddOne(firstNumberint) + "\n\n");

        //CircuitPower
        Console.WriteLine("Now we are using the function that finds the power of an inputted voltage and current. \n");
        Console.WriteLine("Please input a voltage.");
        var voltageNum = Console.ReadLine();
        int voltageNumint = int.Parse(voltageNum);
        Console.WriteLine("Please input a current.");
        var currentNum = Console.ReadLine();
        int currentNumint = int.Parse(currentNum);
        Console.WriteLine("The power of " + voltageNumint + " volts and " + currentNumint + " amps is " + FindPower(voltageNumint, currentNumint) + " watts. \n\n");

        //YearsToDays

        Console.WriteLine("Now we are using the function that finds the amount of days in a given amount of years. \n");
        Console.WriteLine("Please input a number of years.");
        var years = Console.ReadLine();
        int yearsInt = int.Parse(years);
        Console.WriteLine("The number of days in " + years + " years is " + YearsToDays(yearsInt) + "\n\n");

        // Leap Year Conversion
        Console.WriteLine("Now we are using the function that finds if a particular year is a leap year.\n");
        Console.WriteLine("Please input a year.");
        var LeapYear = Console.ReadLine();
        int LeapYearInt = int.Parse(LeapYear);
        Console.WriteLine("The statement that the year " + LeapYearInt + " is a leap year is " + IsLeapYear(LeapYearInt) + "\n\n");


        // Triangle Area
        Console.WriteLine("Now we are using the function that finds the area of a triangle.\n");
        Console.WriteLine("Please input a base.");
        var baselength = Console.ReadLine();
        int baselengthint = int.Parse(baselength);
        Console.WriteLine("Please input a height.");
        var height = Console.ReadLine();
        int heightInt = int.Parse(height);
        Console.WriteLine("The area of a triangle with a base length of " + baselengthint + " units and height of " + heightInt + " units is " + triArea(heightInt, baselengthint) + " units squared.\n\n");

        // Less Than or Equal to 0
        Console.WriteLine("Now we are using the function that finds if an inputted number is less than or equal to zero.\n");
        Console.WriteLine("Please input a number.");
        var checklessthan0 = Console.ReadLine();
        int checklessthan0int = int.Parse(checklessthan0);
        Console.WriteLine("The statement " + checklessthan0int + " is less than or equal to 0 is " + lessThanOrEqualToZero(checklessthan0int) + "\n\n");
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
            "Sum", "MinuteConvert", "AddOne", "FindPower", "YearsToDays", "IsLeapYear", "TriangleArea", "LessThanOrEqualToZero"
        };

        int functionNumber;

        foreach (string function in functions)
        {
            Console.WriteLine(functions[functionNumber]);
            functionNumber++;
        }
        
    }

    public static void SumFunction ()
    {

    }
}