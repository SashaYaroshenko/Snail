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

            while (col <= array.GetLength(1) - dx)
            {
                if (col == array.GetLength(1) - dx)
                {
                    while (row <= array.GetLength(0) - dy)
                    {
                        if (row == array.GetLength(0) - dy)
                        {
                            while (col >= dx-1)
                            {
                                if (col == dx-1)
                                {
                                    dx++;
                                }
                                else
                                {
                                    result.Add(array[row, col]);
                                    col--;
                                }
                                
                            }

                            while (row >= dy-1)
                            {
                                if (row == dy-1)
                                {
                                    dy++;
                                    row++;
                                    col++;
                                    break;
                                }
                                else
                                {
                                    result.Add(array[row, col]);
                                    row--;
                                }                             
                            }
                            break;
                        }
                        else
                        {
                            result.Add(array[row, col]);
                            row++;
                        }
                    }
                }
                else
                {
                    result.Add(array[row, col]);
                    col++;
                }
                if (row > array.GetLength(0) - dy) break;
            }
            row--;
            col--;

            if (array[array.GetLength(0) / 2, array.GetLength(1) / 2] == array[row, col])
            {
                if (array.GetLength(0) % 2 != 0)
                {
                    result.Add(array[row, col]);
                }
            }
            return result.ToArray();
        }
    }
}
