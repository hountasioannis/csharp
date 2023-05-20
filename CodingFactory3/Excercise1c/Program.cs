namespace Excercise1c
{
    /// <summary>
    /// Διαβάζει από τον χρήστη μέρες, ώρες,
    /// λεπτά, δευτερόλεπτα και μετατρέπει σε
    /// δευτερόλεπτα
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Εισάγετε τον αριθμό των μερών: ");
            string? daysInput = Console.ReadLine();
            if (!int.TryParse(daysInput, out int days))
            {
                Console.WriteLine("Μη έγκυρη είσοδος για τα μερες.");
                return;
            }

            Console.Write("Εισάγετε τον αριθμό των ωρών: ");
            string? hoursInput = Console.ReadLine();
            if (!int.TryParse(hoursInput, out int hours))
            {
                Console.WriteLine("Μη έγκυρη είσοδος για τις ώρες.");
                return;
            }

            Console.Write("Εισάγετε τον αριθμό των λεπτών: ");
            string? minutesInput = Console.ReadLine();
            if (!int.TryParse(minutesInput, out int minutes))
            {
                Console.WriteLine("Μη έγκυρη είσοδος για τα λεπτά.");
                return;
            }

            Console.Write("Εισάγετε τον αριθμό των δευτερολέπτων: ");
            string? secondsInput = Console.ReadLine();
            if (!int.TryParse(secondsInput, out int seconds))
            {
                Console.WriteLine("Μη έγκυρη είσοδος για τα δευτερόλεπτα.");
                return;
            }

            int totalSeconds = (days * 24 * 60 * 60) + (hours * 60 * 60) + (minutes * 60) + seconds;

            Console.WriteLine($"Συνολικά δευτερόλεπτα: {totalSeconds}");
        }
    }
}