namespace list_assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<string> colours = new List<string>{"Red", "Blue", "Green", "Purple", "Orange"};
            Console.WriteLine("This is a list of " + colours.Count + " colours:");
            for (int i = 0; i < colours.Count; i++)
            {
                Console.Write(colours[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here is a random colour:");
            Console.WriteLine(colours[generator.Next(colours.Count)]);

        }
    }
}
