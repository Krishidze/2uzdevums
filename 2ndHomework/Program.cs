// See https://aka.ms/new-console-template for more information
// 2nd Homework
// 1st Task From Presentation

Console.WriteLine("Hello, please enter your name");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name);
Console.WriteLine();

// 2nd Task From Presentation

Console.WriteLine("Please enter yout age");
string userageString = Console.ReadLine();
int userAge = int.Parse(userageString);
int userAgePlusOne = userAge + 1;
Console.WriteLine("Next year you will be " + userAgePlusOne + " years old");
Console.WriteLine();

// 3rd Task From Presentation

Console.WriteLine("Let`s play show me the highest number, please enter 1st number");
string userFisrtNumberString = Console.ReadLine();
int userFirstNumber = int.Parse(userFisrtNumberString);
Console.WriteLine("Please eneter 2nd number");
string userSecondNumberString = Console.ReadLine();
int userSecondNumber = int.Parse(userSecondNumberString);
int largerNumber = Math.Max(userFirstNumber, userSecondNumber);
Console.WriteLine("The largers number was " + largerNumber);
Console.WriteLine();

// 4th Task From Presentation

Console.WriteLine("Let`s play show me the lowest number, please enter 1st number");
string userFisrtNumberLowString = Console.ReadLine();
int userFirstNumberLow = int.Parse(userFisrtNumberLowString);
Console.WriteLine("Please eneter 2nd number");
string userSecondNumberLowString = Console.ReadLine();
int userSecondNumberLow = int.Parse(userSecondNumberLowString);
int smallerNumber = Math.Min(userFirstNumber, userSecondNumber);
Console.WriteLine("The Smallest number was " + smallerNumber);
Console.WriteLine();

// 5th Task From Presentation

Console.WriteLine("Let me show you how much is left after division of two numbers");
Console.WriteLine("Please enter 1st number");
string divisionFirstString = Console.ReadLine();
int divisionFirst = int.Parse(divisionFirstString);
Console.WriteLine("Please enter 2nd number");
string divisionSecondString = Console.ReadLine();
int divisionSecond = int.Parse(divisionSecondString);
int divisonLeft = divisionFirst % divisionSecond;
Console.WriteLine("Leftover from your division is " + divisonLeft);
Console.WriteLine();

// 6th Task From Presentation

Console.WriteLine("Let`s Play, is this number Even or Odd");
Console.WriteLine("Please enter number");
string evenFirstString = Console.ReadLine();
int evenFirst = int.Parse(evenFirstString);

if (evenFirst % 2 == 0)
{ Console.WriteLine("The number is even"); }

else
{
    Console.WriteLine("The number is odd");
}
Console.WriteLine();

// 7th Task From Presentation

Console.WriteLine("Let`s calculate area of a rectangle");
Console.WriteLine("Please enter Height cm");
string heightString = Console.ReadLine();
double height = double.Parse(heightString);
Console.WriteLine("Please enter Lenght cm");
string lenghtString = Console.ReadLine();
double lenght = double.Parse(lenghtString);
double areaRectangle = height * lenght;
double areaRectangleRounded = Math.Round(areaRectangle,2);
Console.WriteLine("The area of your fancy rectangle is " + areaRectangleRounded + "cm");
Console.WriteLine();

// 8th Task From Presentation 

Console.WriteLine("Let`s calculate area of a fancy Triangle with 90 degree angle");
Console.WriteLine("Please enter side A cm");
string sideAString = Console.ReadLine();
double sideA = double.Parse(sideAString);
Console.WriteLine("Please enter side B cm");
string SideBString = Console.ReadLine();
double SideB = double.Parse(SideBString);
double areaTriangle = (sideA * SideB / 2);
Console.WriteLine("Area of your fancy Triangle is " + areaTriangle);
Console.WriteLine();

// 9th Task From Presentation

Console.WriteLine("Please enter your imaginary name");
string imaginaryName = Console.ReadLine();
Console.WriteLine("Please enter your imaginary age");
string imaginaryAgeString = Console.ReadLine();
int imaginaryAge = int.Parse(imaginaryAgeString);
string formattedMessage = $"Hello {imaginaryName}, your imaginary age is {imaginaryAge}";
Console.WriteLine(formattedMessage);