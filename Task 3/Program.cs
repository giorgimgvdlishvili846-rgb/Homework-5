using System;

namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a first number (x): ");
        int firstNum;
        
        while (!int.TryParse(Console.ReadLine(), out firstNum)) {
            Console.Write("Invalid input. Try again: ");
        }
        
        Console.Write("Enter a second number (y): ");
        int secondNum;
        
        while (!int.TryParse(Console.ReadLine(), out secondNum))
        {
            Console.Write("Invalid input. Try again: ");
        }
        
        // საწყისი მნიშვნელობების ბეჭდვა
        Console.WriteLine($"\nBefore Swap -> x = {firstNum}; y = {secondNum}");

        // მნიშვნელობების გადაცვლა (Swap)
        int temp = firstNum;
        firstNum = secondNum;
        secondNum = temp;
        
     
        Console.WriteLine($"After Swap  -> x = {firstNum}; y = {secondNum}");
    }
}
