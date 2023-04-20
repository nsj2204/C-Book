namespace DulAlgorithmNuGetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 33, 22, 55, 11 };

            int[] results = DulAlgorithm.Algorithm.SelectionSort(numbers);

            foreach (var r in results)
            {
                System.Console.WriteLine(r);
            }
        }
    }
}
