static string DigitsOfANumber(int num)
{
    if (num < 10)
    {
        return ((char)(num + '0')).ToString();
    }
    //'0' adds 48 to convert the number to a char
    //flip the num / 10 and the %10 to get the reverse order
    return DigitsOfANumber(num / 10) + " " + (char)((num % 10) +'0');
}

Console.WriteLine("Assignment 5.4.1");
Console.WriteLine();
Console.WriteLine($"The digits in the number are {DigitsOfANumber(1234)}");
Console.WriteLine($"The digits in the number are {DigitsOfANumber(5)}");
Console.WriteLine();
Console.ReadKey();

Console.WriteLine("Assignment 5.4.2");
Console.WriteLine();

Console.WriteLine("Enter the size of the square array. ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] myArr = new int[size, size];
Console.WriteLine("Enter the array:");
for (int i = 0; i < size; i ++)
{
    for (int j = 0; j < size; j ++)
    {
        try
        {
            Console.WriteLine($"Enter value at poisition ({i},{j}): ");
            myArr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        catch(FormatException)
        {
            Console.WriteLine("Incorrect Input! 0 is placed in this spot!");
            myArr[i, j] = 0;
        }
        
    }
}

Console.WriteLine();
for (int i = 0; i < size; i ++)
{
    Console.Write("[ ");
    for (int j = 0; j < size; j ++)
    {
        Console.Write(myArr[i,j] + " ");
    }
    Console.WriteLine("]");
}
static int SumOfDiagonals(int[,] myArr, int size)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += myArr[i, size - 1 - i];
    }
    return sum;
}

Console.WriteLine(SumOfDiagonals(myArr, size));

