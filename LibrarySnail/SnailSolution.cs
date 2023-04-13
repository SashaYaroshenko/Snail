namespace LibrarySnail
{
    public class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {
            List<int> result = new List<int>();
            int dx = 1;
            int dy = 1;

            int row = 0;
            int col = 0;

            int len = array[row].GetLength(0) * array.GetLength(0);

            while (dx + dx <= array[row].GetLength(0) || dy + dy <= array.GetLength(0))
            {
                while (col <= array[row].GetLength(0) - dx)
                {
                    result.Add(array[row][col]);
                    col++;
                }   col--; row++;
                if (result.Count == len) break;
                while (row <= array.GetLength(0) - dy)
                {
                    result.Add(array[row][col]);
                    row++;
                }   row--; col--;
                if (result.Count == len) break;
                while (col >= dx - 1)
                {
                    result.Add(array[row][col]);
                    col--;
                }   col++; row--;
                if (result.Count == len) break;
                while (row > dy - 1)
                {
                    result.Add(array[row][col]);
                    row--;
                }   row++; col++;
                if (result.Count == len) break;            
                dx++;
                dy++;
            }

            if (array.GetLength(0) == array[row].GetLength(0))
            {
                if (array.GetLength(0) % 2 != 0)
                {
                    result.Add(array[row][col]);
                }
            }
            return result.ToArray();
        }

    }
}
