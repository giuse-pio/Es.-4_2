using LibraryN4_2;
namespace Es._4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci i valori dei quadrati, seguiti da Q#:");
            string inputq1 = Console.ReadLine();
            Quadrato q1 = Quadrato.Parse(inputq1);

            string inputq2 = Console.ReadLine();
            Quadrato q2 = Quadrato.Parse(inputq2);

            Quadrato somma = q1 + q2;
            Quadrato differenza = q1 - q2;

            Console.WriteLine($"Primo quadrato: {q1}");
            Console.WriteLine($"Secondo quadrato: {q2}");
            Console.WriteLine($"Somma: {somma}");
            Console.WriteLine($"Differenza: {differenza}");
            Console.WriteLine($"Uguaglianza: {q1 == q2}");
        }
    }
}
