Console.WriteLine("Welcome!");

Console.Write("What's your name? ");
var name = Console.ReadLine();

var dateOfBirth = String.Empty;

Console.Write("What's your date of birth (Y-m-d)? ");
dateOfBirth = Console.ReadLine() ?? "";

DateTime dateTime;
try
{
    dateTime = DateTime.Parse(dateOfBirth);
    // Console.WriteLine(dateTime);
}
catch (System.Exception)
{
    Console.WriteLine($"[Error] Invalid date format: '{dateOfBirth}'.");
    return;
}

var currentDate = DateTime.Now;

// var age = currentDate.Subtract(dateTime);

Console.WriteLine($"Thank you {name}. You're about {currentDate.Year - dateTime.Year} years old.");
