// See https://aka.ms/new-console-template for more information
Console.WriteLine("Learn your squares and cubes!");

do
{
    string userInput = GetUserInput("Please Enter an integer and see the exponents table.  ");
    //Console.Write(userInput);

    int num = int.Parse(userInput);
    //Console.WriteLine(num);

    for (int i = 1; i <= num; i++)
    {
        //double root = SqrtNum(i);
        int square = SquareNum(i);
        int cube = CubeNum(i);

        //String interpolation is a short hand way of constructing a string     
        Console.WriteLine($" {i} \t {square} \t {cube}");
        //Console.WriteLine($"{root} \t {i} \t {square} \t {cube}");
    }
} while(TryAgain());

 static string GetUserInput(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    return input;
}
static int SquareNum(int num)
{
    return num * num;
}

static int CubeNum(int num)
{
    return num * num * num;
}

//static double SqrtNum(int num)
//{
//    return Math.Round(Math.Sqrt(num), 2);
//}

static bool TryAgain()
{
    Console.Write("Would you like to continue y/n: ");
    string userAnswer = Console.ReadLine();

    if (userAnswer.ToLower() == "y")
    {
        return true;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        return false;
    }
}