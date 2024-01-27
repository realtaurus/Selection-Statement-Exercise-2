namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is ok.");
                    break;
                case "science":
                    Console.WriteLine("Science huh, ok Einstein.");
                    break;
                case "english":
                    Console.WriteLine("English breaks its on rules all the time.");
                    break;
                case "history":
                    Console.WriteLine("History is the best subject.");
                    break;
                case "art":
                    Console.WriteLine("Art, I don't see why it's a mandatory class.");
                    break;
                default:
                    Console.WriteLine($"{favSubject} is not what I expected but keep learning.");
                    break;
            }
        }
    }
}
