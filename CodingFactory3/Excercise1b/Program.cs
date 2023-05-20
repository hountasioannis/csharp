namespace Excercise1b
{
    /// <summary>
    /// Διαβάζει από τον χρήστη δευτερόλεπτα και
    /// τα μετατρέπει σε μέρες, ώρες, λεπτά,
    /// δευτερόλεπτα
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Εισάγετε τον αριθμό των δευτερολέπτων: ");
            string? input = Console.ReadLine();
            

            if (int.TryParse(input, out int totalSeconds))
            {
                int days = totalSeconds / (24 * 60 * 60);
                int hours = (totalSeconds % (24 * 60 * 60)) / (60 * 60);
                int minutes = (totalSeconds % (60 * 60)) / 60;
                int seconds = totalSeconds % 60;

                Console.WriteLine($"Μετατροπή σε μορφή μέρες:ώρες:λεπτά:δευτερόλεπτα: {days}:{hours}:{minutes}:{seconds}");
            }
            else
            {
                Console.WriteLine("Μη έγκυρη είσοδος.");
            }
        }
    }
}