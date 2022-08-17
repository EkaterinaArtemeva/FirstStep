string? inputLine = Console.ReadLine();

if(inputLine != null)
    {
        char[] numbers = inputLine.ToCharArray();

         if(numbers.Length >= 2)
         {
            Console.WriteLine(numbers[2]);
         }
         else
         {
            Console.WriteLine("no third number");
         }

    }

