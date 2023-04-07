using LibrarySnail;
namespace ConsoleSnail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Write rows and cols:");
            string[] rowsCols = Console.ReadLine().Split(' ');
            int row = Convert.ToInt32(rowsCols[0]);
            int col = Convert.ToInt32(rowsCols[1]);
            Console.WriteLine();
            int[][] ar = new int[row][]; 
            for (int i = 0; i < row; i++)
            {
                ar[i] = new int[col];  
            }
            int[]rand = Enumerable.Range(0, row*col).ToArray();
            Console.WriteLine("Here is your matrix with random numbers!"); 
            
            Class1.ShowMatrix(ar, rand);
            Console.WriteLine();

            Console.WriteLine("Here is your processed matrix!");
            var str = string.Join(" ", SnailSolution.Snail(ar));
            Console.WriteLine(str);
        }
        
    }

}