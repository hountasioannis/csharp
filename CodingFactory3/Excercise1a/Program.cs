namespace Excercise1a
{
    /// <summary>
    /// Διαβάζει από τον χρήστη ένα ποσό σε Ευρώ
    /// και το μετατρέπει σε δολάρια USA
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double euroRate = 1.16; // Ισοτιμία ευρώ προς δολάρια ΗΠΑ
           
            Console.Write("Εισάγετε το ποσό σε ευρώ: ");
            string? input = Console.ReadLine();

             if (double.TryParse(input, out double euroAmount))
            {
                double dollarAmount = euroAmount * euroRate;
                Console.WriteLine($"Το ποσό {euroAmount} ευρώ αντιστοιχεί σε {dollarAmount} δολάρια ΗΠΑ.");
            }
            else
            {
                Console.WriteLine("Μη έγκυρη είσοδος.");
            }
        }
    }
}