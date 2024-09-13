using static System.Formats.Asn1.AsnWriter;

Console.Write("Enter rating:");
double rating1 = double.Parse(Console.ReadLine());

Console.Write("Enter rating:");
double rating2 = double.Parse(Console.ReadLine());


Console.Write("Enter rating:");
double rating3 = double.Parse(Console.ReadLine());


Console.Write("Enter rating:");
double rating4 = double.Parse(Console.ReadLine());


Console.Write("Enter rating:");
double rating5 = double.Parse(Console.ReadLine());

Console.WriteLine("Result Average score");
Console.Write((rating1 + rating2 + rating3 + rating4 + rating5) /5);


