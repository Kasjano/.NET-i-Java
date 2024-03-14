namespace Problem_plecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Number of items :");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the seed :");
            int Seed = int.Parse(Console.ReadLine());

            Problem problem = new Problem(N,Seed);
            //problem.AddItemManually(1, 2, 1);

            Console.WriteLine(" Enter the capacity :");
            int capacity = int.Parse(Console.ReadLine());

            Result result = problem.Solve(capacity);
            Console.WriteLine(result.ToString());

        }
    }
}
