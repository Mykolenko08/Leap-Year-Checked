namespace CS_years
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            bool year_visokos = false;
            string output_help = ""; // may or may not add a "not" part for the output

            if (year < 1)
            {
                Console.WriteLine("Invalid year");
                return;
            }
            Console.WriteLine("Now checking facts a, b, c");
            if (year % 4 == 0) //check for a
            {
                year_visokos = true;
            }

            if (year % 100 == 0) //check for b
            {
                year_visokos = false;
            }

            if (year % 400 == 0) //check for c
            {
                year_visokos = true;
            }

            if (year_visokos != true)
            {
                output_help = " not";
            }

            Console.WriteLine($"The year number {year} is{output_help} visokosniy");

        }
    }
}
