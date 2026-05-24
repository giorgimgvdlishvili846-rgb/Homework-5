namespace Task_3;



        class Program
        {
            static void Main()
            {
                // ვთხოვთ მომხმარებელს რიცხვის შეყვანას
                Console.Write("Enter a number: ");
        
                // კონსოლიდან შემოყვანილ ტექსტს ვაქცევთ მთელ რიცხვად (int)
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    // ვამოწმებთ 5-ზე გაყოფის ნაშთს
                    if (number % 5 == 0)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }
        
    
