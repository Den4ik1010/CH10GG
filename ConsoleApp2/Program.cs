﻿//using static System.Formats.Asn1.AsnWriter;

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

//Console.Write("Result Average score");
//Console.Write((rating1 + rating2 + rating3 + rating4 + rating5) / 5);


//Console.WriteLine("----------------Degrees in Fahrenheit----------------");
//Console.Write("Enter Degrees:");
//double degrees = double.Parse(Console.ReadLine());
//Console.Write("Result:");
//Math.Round(degrees);
//Console.Write(degrees * 1.800000 + 32);

//Console.WriteLine("-------------The revolution of Mars around the Sun in years-------------");
//Console.Write("Enter revolutions:");
//int day = int.Parse(Console.ReadLine());
//const int revolutions = 686;
//int day1 = day * revolutions;
//Console.WriteLine("Result:" + day1);

//Console.Write("Enter your age:");
//int age = int.Parse(Console.ReadLine());
//if (age >= 15 && age <= 55)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("So you can study");
//    Console.ResetColor();

//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("SO you no can study:");
//    Console.ResetColor();
//}

//Console.Write("Eneter you price:");
//double price = double.Parse(Console.ReadLine());

//if (price >= 1000 && price <= 5000)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("Discounted price:10%");
//    double price1 = price - price * (10 / 100.0);
//    Console.Write($"Result: {price1} ");
//    Console.ResetColor();
//}
//if (price >= 5000)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("Discounted price:25%");
//    double price1 = price - price * (25 / 100.0);
//    Console.Write($"Result: {price1} ");
//    Console.ResetColor();
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("No discount");
//    Console.ResetColor();
//}

//Console.Write("Enter you rating:");
//int rating = int.Parse(Console.ReadLine());

//if (rating == 1)
//{
//    Console.WriteLine("badly");
//}
//if (rating == 2)
//{
//    Console.WriteLine("satisfactorily");
//}
//if (rating == 3)
//{
//    Console.WriteLine("satisfactorily");
//}
//if (rating == 4)
//{
//    Console.WriteLine("good");
//}
//if (rating == 5)
//{
//    Console.WriteLine("good");
//}
//Console.Write("choose currency (1-3):");
//int currency =int.Parse(Console.ReadLine());

//Console.Write("Enter GRN:");
//int GRN = int.Parse(Console.ReadLine());

//switch (currency)
//{
//    case 1: Console.WriteLine($"Result: {GRN / 41.14}"); break;
//    case 2: Console.WriteLine($"Result: {GRN / 48}"); break;
//    case 3: Console.WriteLine($"Result: {GRN / 10.74}"); break;
//    default: Console.WriteLine("no"); break;
//}
//Console.Write("length (number):");
//int length = int.Parse(Console.ReadLine());

//for (int count = 0; count < length; count++)
//{
//    Console.Write("#");
//}

Console.Write("Enter width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter height: ");
int height = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter symbols:");
char symbols = char.Parse(Console.ReadLine());

Console.Write("choose a collar from 1 to 3: 1-ed 2-green 3-blue");
int color =int.Parse(Console.ReadLine());

switch(color)
{
    case 1: Console.ForegroundColor= ConsoleColor.Red; break;

    case 2: Console.ForegroundColor = ConsoleColor.Blue; break;

    case 3: Console.ForegroundColor = ConsoleColor.Yellow; break;
}


for (int i = 0; i < height; i++)
{

    Console.WriteLine(new string(symbols, width));
}

