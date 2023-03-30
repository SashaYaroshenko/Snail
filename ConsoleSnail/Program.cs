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
            int[,] ar = new int[row, col];
            //int[] rand = RandomNum(ar.GetLength(0)* ar.GetLength(1)); 
            int[]rand = Enumerable.Range(0, row*col).ToArray();
            Console.WriteLine("Here is your matrix with random numbers!"); 
            
            ShowMatrix(ar, rand);
            Console.WriteLine();

            Console.WriteLine("Here is your processed matrix!");
            var str = string.Join(" ", SnailSolution.Snail(ar));
            Console.WriteLine(str);
        }
        static void ShowMatrix (int[,] mat, int[]num)
        {
            int index = 0;
            string res = "";
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = num[index];
                    index++;
                    res = (mat[i, j].ToString()).PadLeft(2, ' ') + " ";
                    Console.Write(res);
                }
                Console.WriteLine();
            }          
        }
        static int[] RandomNum (int len)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            int[] rand = new int[len];
            for(int i = 0; i < len; i++)
            {
                list.Add(i);
            }
            for(int i = 0; i < len; i++)
            {
                int index = random.Next(0, len-i);
                rand[i] = list[index];
                list.Remove(list[index]);
            }
            return rand;
        }
    }
}