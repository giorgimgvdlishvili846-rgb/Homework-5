namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        int number;

        // ციკლი ტრიალებს მანამ, სანამ მომხმარებელი არ შეიყვანს სწორ რიცხვს
        while (true)
        {
            Console.Write("Enter a number between 1 and 10: ");
            string input = Console.ReadLine();

            // 1. ჯერ ვამოწმებთ, საერთოდ რიცხვია თუ არა
            if (int.TryParse(input, out number))
            {
                // 2. თუ რიცხვია, მერე ვამოწმებთ, არის თუ არა 1-დან 10-მდე
                if (number >= 1 && number <= 10)
                {
                    // თუ ყველაფერი სწორია, ციკლიდან გამოვდივართ break-ით
                    break;
                }
                else
                {
                    // თუ რიცხვია, მაგრამ არ ზის დიაპაზონში
                    Console.WriteLine("Number must be between 1 and 10.");
                }
            }
            else
            {
                // თუ საერთოდ არ არის რიცხვი (მაგ. ტექსტია)
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
            
            Console.WriteLine(); // უბრალოდ ცარიელი ხაზი სილამაზისთვის
        }

        // გამრავლების ტაბულის ბეჭდვა (1-დან 9-ის ჩათვლით, როგორც შენ გეწერა)
        Console.WriteLine($"\nMultiplication table for {number}:");
        for (int i = 1; i <= 9; i++)
        {
            // აქ შევცვალე WriteLine-ით, რომ სვეტად დაიბეჭდოს
            Console.WriteLine($"{number} x {i} = {number * i}"); 
        }
    }
}