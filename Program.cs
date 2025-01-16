namespace assignment_qs3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  user  input for distance and time
            Console.Write("Enter distance in kilometers: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter time in hours: ");
            double time = Convert.ToDouble(Console.ReadLine());

            // Calculate speed in kilometers per hour
            double speedKmPerHour = distance / time;

            // Convert distance to miles (1 km = 0.621371 miles)
            double distanceInMiles = distance * 0.621371;

            // Calculate speed in miles per hour
            double speedMph = distanceInMiles / time;

            // Display the results
            Console.WriteLine($"Speed: {speedKmPerHour} kilometers per hour (km/h)");
            Console.WriteLine($"Speed: {speedMph} miles per hour (mph)");
        }
    }
}
