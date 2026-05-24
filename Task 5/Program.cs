namespace Task_5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input");
        }

        for (int n = 1; n <= number; n++)
        {
            if (n % 2 == 0)
            {     Console.WriteLine(n*n);
            }
        }
        
    }
}