namespace assignment_qs4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loop through values of y  ranging from -5 to 5
            for (int y = -5; y <= 5; y++)
            {
                // Calculate x using the formula x = y^2 + 2y + 1
                int x = y * y + 2 * y + 1;

                // Display the result
                Console.WriteLine($"For y = {y}, x = {x}");
            }
        }
    }
}
