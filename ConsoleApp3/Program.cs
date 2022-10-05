// מטלה 4
Console.WriteLine("Please enter the time: ");
int hours = int.Parse(Console.ReadLine());
int hoursformat = hours / 100;
int minutesformat = hours % 100;
if (hoursformat > 12 && minutesformat < 10)
{
    hoursformat = hoursformat - 12;
    Console.WriteLine($".P.M {hoursformat}:0{minutesformat}");
} else if (hoursformat > 12 && minutesformat > 10)
{
    hoursformat = hoursformat - 12;
    Console.WriteLine($".P.M {hoursformat}:{minutesformat}");
}
else if (hoursformat < 12 && minutesformat < 10) 
{
    Console.WriteLine($".A.M 0{hoursformat}:0{minutesformat}");
} else if (hoursformat < 12 && minutesformat > 10)
{
    Console.WriteLine($".A.M 0{hoursformat}:{minutesformat}");
    Console.WriteLine($".A.M {hoursformat}:{minutesformat}");
} else if (hoursformat == 12)
{
    Console.WriteLine($".P.M {hoursformat}:{minutesformat}");
}

// מטלה 5
Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());
if (number < 0)
{
    number = number * -1;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine(number);
}

// מטלה 6
Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());
if ((num % 2) == 0)
{
    Console.WriteLine($"{num} EVEN");
} else if ((num % 2) != 0)
{
    Console.WriteLine($"{num} NOT EVEN");
}
