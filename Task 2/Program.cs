using System;

namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        int firstNum;
        int secondNum;

        // პირველი რიცხვის ვალიდაცია
        Console.Write("Enter first num: ");
        while (!int.TryParse(Console.ReadLine(), out firstNum))
        {
            Console.Write("შეცდომა! შეიყვანეთ მხოლოდ რიცხვი: ");
        }

        // მეორე რიცხვის ვალიდაცია
        Console.Write("Enter second num: ");
        while (!int.TryParse(Console.ReadLine(), out secondNum))
        {
            Console.Write("შეცდომა! შეიყვანეთ მხოლოდ რიცხვი: ");
        }

        Console.WriteLine(); // ცარიელი ხაზი

        // გამოთვლები
        int sum = firstNum + secondNum;
        int product = firstNum * secondNum;
        int difference = Math.Abs(firstNum - secondNum); // მოდული (ყოველთვის დადებითი სხვაობა)

        // შედეგების ბეჭდვა
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");

        // ნულზე გაყოფის შემოწმება
        if (secondNum != 0)
        {
            double division = (double)firstNum / secondNum;
            Console.WriteLine($"Division: {division}");
        }
        else
        {
            Console.WriteLine("Division: Cannot divide by zero!");
        }
    }
}