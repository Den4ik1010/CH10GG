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

//Console.Write("Enter width: ");
//int width = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter height: ");
//int height = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter symbols:");
//char symbols = char.Parse(Console.ReadLine());

//Console.Write("choose a collar from 1 to 3: 1-ed 2-green 3-blue");
//int color =int.Parse(Console.ReadLine());

//switch(color)
//{
//    case 1: Console.ForegroundColor= ConsoleColor.Red; break;

//    case 2: Console.ForegroundColor = ConsoleColor.Blue; break;

//    case 3: Console.ForegroundColor = ConsoleColor.Yellow; break;
//}


//for (int i = 0; i < height; i++)
//{

//    Console.WriteLine(new string(symbols, width));
//}
//var rand = new Random();
//int winsInRow = 0;

//Console.Write("Put your money $: ");
//double money = int.Parse(Console.ReadLine());

//while (money > 0)
//{
//    Console.Write("Guess the number [1-6]...");
//    int number = int.Parse(Console.ReadKey().KeyChar.ToString());

//    Console.Clear();

//    int dice = rand.Next(1, 7);

//    DrawDice(dice);

//    if (number == dice)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("You won! +50%");
//        money = Math.Round(money * 1.5, 2, MidpointRounding.ToZero);
//        ++winsInRow;

//        if (number == 3)
//        {
//            Console.ForegroundColor = ConsoleColor.Blue;
//            Console.WriteLine("Happy number! +30%");
//            money = Math.Round(money * 1.3, 2, MidpointRounding.ToZero);
//        }
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("You loose! -20%");
//        money = Math.Round(money / 1.2, 2, MidpointRounding.ToZero);
//        winsInRow = 0;
//    }
//    if (winsInRow >= 2)
//    {
//        Console.ForegroundColor = ConsoleColor.Magenta;
//        Console.WriteLine("Jackpot! +100%");
//        money = Math.Round(money * 2, 2, MidpointRounding.ToZero);
//    }

//    Console.ResetColor();

//    Console.WriteLine($"Balance: {money}$");
//}

//static void DrawDice(int roll)
//{
//    switch (roll)
//    {
//        case 1:
//            Console.WriteLine("+-------+");
//            Console.WriteLine("|       |");
//            Console.WriteLine("|   o   |");
//            Console.WriteLine("|       |");
//            Console.WriteLine("+-------+");
//            break;
//        case 2:
//            Console.WriteLine("+-------+");
//            Console.WriteLine("| o     |");
//            Console.WriteLine("|       |");
//            Console.WriteLine("|     o |");
//            Console.WriteLine("+-------+");
//            break;
//        case 3:
//            Console.WriteLine("+-------+");
//            Console.WriteLine("| o     |");
//            Console.WriteLine("|   o   |");
//            Console.WriteLine("|     o |");
//            Console.WriteLine("+-------+");
//            break;
//        case 4:
//            Console.WriteLine("+-------+");
//            Console.WriteLine("| o   o |");
//            Console.WriteLine("|       |");
//            Console.WriteLine("| o   o |");
//            Console.WriteLine("+-------+");
//            break;
//        case 5:
//            Console.WriteLine("+-------+");
//            Console.WriteLine("| o   o |");
//            Console.WriteLine("|   o   |");
//            Console.WriteLine("| o   o |");
//            Console.WriteLine("+-------+");
//            break;
//        case 6:
//            Console.WriteLine("+-------+");
//            Console.WriteLine("| o   o |");
//            Console.WriteLine("| o   o |");
//            Console.WriteLine("| o   o |");
//            Console.WriteLine("+-------+");
//            break;
//    }
//}
const int size = 4;
int emptyX = 2;
int emptyY = 2;

int[,] puzzle = new int[size, size]
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 0, 12},
    {13, 14, 15, 11}
};
ShowPuzzle();

while (true)
{
    var key = Console.ReadKey().Key;

    switch (key)
    {
        case ConsoleKey.LeftArrow:
            // left
            Swap(ref puzzle[emptyY, emptyX], ref puzzle[emptyY, emptyX + 1]);
            ++emptyX;
            break;
        case ConsoleKey.RightArrow:
            // right
            Swap(ref puzzle[emptyY, emptyX], ref puzzle[emptyY, emptyX - 1]);
            --emptyX;
            break;
        case ConsoleKey.UpArrow:
            // 
            Swap(ref puzzle[emptyY, emptyX], ref puzzle[emptyY + 1, emptyX ]);
            ++emptyY;
            break;
        case ConsoleKey.DownArrow:
            // 
            Swap(ref puzzle[emptyY, emptyX], ref puzzle[emptyY - 1 , emptyX ]);
            --emptyY;
            break;
    }

    Console.Clear();
    ShowPuzzle();
}

void ShowPuzzle()
{
    for (int r = 0; r < size; r++)
    {
        for (int c = 0; c < size; c++)
        {
            if (puzzle[r, c] == 0)
                Console.Write("[  ] ");
            else
                Console.Write($"[{puzzle[r, c],2}] ");
        }
        Console.WriteLine();
    }
}

static void Swap(ref int first, ref int second)
{
    int temp = first;
    first = second;
    second = temp;
}
