

namespace assignment_qs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taking user input for the number and the width
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            int width = int.Parse(Console.ReadLine());

            // Displaying the triangle using the input number and width
            for (int i = 1; i <= width; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
