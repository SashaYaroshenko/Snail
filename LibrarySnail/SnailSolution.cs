namespace LibrarySnail
{
    public class SnailSolution
    {
        public static int[] Snail(int[,] array)
        {
            List<int> result = new List<int>();
            int dx = 1;
            int dy = 1;

            int row = 0;
            int col = 0;

            while (array[row, col] != array[array.GetLength(0) / 2, array.GetLength(1) / 2])
            {
                while (col < array.GetLength(1) - dx)
                {
                    if (result.Count() == array.GetLength(0) * array.GetLength(1))
                    {
                        break;
                    }
                    result.Add(array[row, col]);
                    col++;
                }
                while (row < array.GetLength(0) - dy)
                {
                    if (result.Count() == array.GetLength(0) * array.GetLength(1))
                    {
                        break;
                    }
                    result.Add(array[row, col]);
                    row++;
                }
                while (col > dx - 1)
                {
                    if (result.Count() == array.GetLength(0) * array.GetLength(1))
                    {
                        break;
                    }
                    result.Add(array[row, col]);
                    col--;
                }
                while (row > dy - 1)
                {
                    if (result.Count() == array.GetLength(0) * array.GetLength(1))
                    {
                        break;
                    }
                    result.Add(array[row, col]);
                    row--;
                }
                dx++;
                dy++;
                if (array[array.GetLength(0) / 2, array.GetLength(1) / 2 - 1] == array[row, col] || result.Count() == array.GetLength(0) * array.GetLength(1))
                {
                    break;
                }
                row++;
                col++;
            }
            //if (array[array.GetLength(0) / 2, array.GetLength(1) / 2 - 1] == array[row, col] && result.Count() != array.GetLength(0) * array.GetLength(1))
            //{
            //    result.Add(array[row, col]);
            //}

            if (array[array.GetLength(0) / 2, array.GetLength(1) / 2] == array[row, col] && result.Count() != array.GetLength(0) * array.GetLength(1))
            {
                if (array.GetLength(0) % 2 != 0)
                {
                    result.Add(array[row, col]);
                }
            }
            return result.ToArray();
        }
        public static int[] Snail(int[][] array)
        {
            List<int> result = new List<int>();

            int row = 0;
            int col = 0;

            int dx = array.GetLength(0);
            int dy = array[row].GetLength(0);

            int xd = 1;
            int yd = 1;

            if (array.Length == 0)
            {
                return new int[0];
            }
            //while (/*array[row][col] != array[array.GetLength(0) / 2][array[row].GetLength(0) / 2]*/)
            while(true)
            {
                while (col < array[row].GetLength(0)-xd && result.Count() != array.GetLength(0) * array[row].GetLength(0))
                {
                    result.Add(array[row][col]);
                    col++;
                }
                while (row < array.GetLength(0)-yd && result.Count() != array.GetLength(0) * array[row].GetLength(0))
                {                   
                    result.Add(array[row][col]);
                    row++;
                }
                while (col > array[row].GetLength(0)-dy && result.Count() != array.GetLength(0) * array[row].GetLength(0))
                {                    
                    result.Add(array[row][col]);
                    col--;
                }
                while (row > array.GetLength(0)-dx && result.Count() != array.GetLength(0) * array[row].GetLength(0)
                    )
                {                    
                    result.Add(array[row][col]);
                    row--;
                }
                dx--;
                dy--;
                xd++;
                yd++;
                if (array[array.GetLength(0) / 2][array[row].GetLength(0) / 2 - 1] == array[row][col] || result.Count() == array.GetLength(0) * array[row].GetLength(0))
                {
                    break;
                }
                row++;
                col++;
            }           

            if (array[array.GetLength(0) / 2][array[row].GetLength(0) / 2] == array[row][col] && result.Count() != array.GetLength(0) * array[row].GetLength(0))
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
