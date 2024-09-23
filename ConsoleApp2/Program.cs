//using static System.Formats.Asn1.AsnWriter;

//Console.Write("Enter rating:");
//double rating1 = double.Parse(Console.ReadLine());

//Console.Write("Enter rating:");
//double rating2 = double.Parse(Console.ReadLine());


//Console.Write("Enter rating:");
//double rating3 = double.Parse(Console.ReadLine());


//Console.Write("Enter rating:");
//double rating4 = double.Parse(Console.ReadLine());


//Console.Write("Enter rating:");
//double rating5 = double.Parse(Console.ReadLine());

//Console.WriteLine("Result Average score");
//Console.Write((rating1 + rating2 + rating3 + rating4 + rating5) /5);

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Console.WriteLine("----------------Degrees in Fahrenheit----------------");
//Console.Write("Enter Degrees:");
//double degrees = double.Parse(Console.ReadLine());
//Console.Write("Result:");
//Math.Round(degrees);
//Console.Write(degrees * 1.800000 + 32);
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Console.WriteLine("-------------The revolution of Mars around the Sun in years-------------");
//Console.Write("Enter revolutions:");
//int day = int.Parse(Console.ReadLine());
//const int revolutions = 686;
//int day1 = day * revolutions;
//Console.WriteLine("Result:"+day1);

//using System.Linq.Expressions;
//using System.Transactions;
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Console.Write("Enter your age:");
//int age = int.Parse(Console.ReadLine());
//if (age >= 15 && age <= 55) 
//{
//Console.ForegroundColor= ConsoleColor.Green;
//    Console.WriteLine("So you can study");
//    Console.ResetColor();   

//}
//else
//{
//Console.ForegroundColor= ConsoleColor.Red;
//    Console.WriteLine("SO you no can study:");
//    Console.ResetColor();
//}

Console.Write("Eneter you price:");
double price =double.Parse(Console.ReadLine());

if (price >= 1000 && price <= 5000) 
{
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("Discounted price:10%");
    double price1 = price - price * (10 / 100.0);
    Console.Write($"Result: {price1} ");
   Console.ResetColor();
}
if (price >= 5000)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Discounted price:25%");
    double price1 = price - price * (25 / 100.0);
    Console.Write($"Result: {price1} ");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("No discount");
    Console.ResetColor();
}
