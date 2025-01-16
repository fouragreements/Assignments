


namespace assignment_qs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Predefined credentials 
            string UserId = "aiswarya";
            string Password = "aiswarya100";

            int attempts = 0; // initialize number of attempts
           

            while (attempts < 3) // Allow up to 3 attempts
            {
                //  user  input
                Console.Write("Enter User ID: ");
                string userId = Console.ReadLine();

                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                // Check if the provided credentials match the predefined ones
                if (userId == UserId && password == Password)
                {
                    Console.WriteLine("Login successful! Welcome.");
                    
                    break; // Exit the loop if the credentials are correct
                }
                else
                {
                    attempts++; // Increment the attempt counter
                    Console.WriteLine("Incorrect User ID or Password. Try again.");
                    Console.WriteLine($"Attempts remaining: {3 - attempts}");
                   
                    
                }
            }
            // If the user fails all 3 attempts, show time out message
            if (attempts >= 3)
            {
                Console.WriteLine("Time out!!,failed three attempts...please try after sometime");
            }




        }
    }
}
