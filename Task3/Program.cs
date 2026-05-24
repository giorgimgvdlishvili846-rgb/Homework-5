namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter a first number: ");
        int firstNum;   
        while (!int.TryParse(Console.ReadLine(), out firstNum)) {
            Console.WriteLine("invalid input");
        }
        
        Console.Write("enter a second number: ");
        int secondNum;
        while (!int.TryParse(Console.ReadLine(), out secondNum))
        {
            Console.WriteLine("invalid input");
        }
        
        
        Console.WriteLine($" values    First: {firstNum}, Second: {secondNum}");
        Console.WriteLine("After changes ");
        int temp = firstNum;
        firstNum = secondNum;
        secondNum = temp;
        Console.WriteLine($" values    First: {firstNum}, Second: {secondNum}");
        
        
    }
}