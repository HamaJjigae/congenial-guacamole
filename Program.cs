namespace Lab_0
{
    internal class Program
    {
        //Additional Task 5
        static bool PrimeCheck(double number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static void Main()
        {
            // Additional Task 1
            try
            {
                Console.Write("Please enter the lower value: ");
                int low = int.Parse(Console.ReadLine());

                // Task 2-1
                while (low <= 0)
                {
                    Console.Write("Please enter a lower value that is greater than 0: ");
                    low = int.Parse(Console.ReadLine());
                }

                Console.Write("Please enter the higher value: ");
                int high = int.Parse(Console.ReadLine());

                // Task 2-2
                while (low > high)
                {
                    Console.Write("The lower value is currently greater than the higher value, please enter a new higher value: ");
                    high = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"The difference between {high} and {low} is {high - low}");

                // Task 3-1 + 3-2
                using (StreamWriter writer = new StreamWriter("numbers.txt"))
                {
                    //Additional task 3 converting array to list
                    List<int> low_to_high = new List<int>();

                    for (int i = low + 1; i < high; i++)
                    {
                        low_to_high.Add(i);
                    }
                    // Task 3-3
                    for (int i = low_to_high.Count - 1; i >= 0; i--)
                    {
                        writer.WriteLine(low_to_high[i]);
                    }
                }

                // Additional Task 2
                List<int> read_list = new List<int>();
                using (StreamReader reader = new StreamReader("numbers.txt"))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        read_list.Add(int.Parse(line));
                    }
                }
                int sum = 0;
                foreach (int i in read_list)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
                // Additional Task 5
                for (int i = 0; i < read_list.Count; i++)
                {
                    if (PrimeCheck(read_list[i]))
                    {
                        Console.Write($"{read_list[i]} ");
                    }
                }
            }
            // Additional Task 1
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
