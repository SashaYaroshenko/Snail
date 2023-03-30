namespace LibrarySnail
{
    public class SnailSolution
    {
            public static int[] Snail(int[,] array)
            {
            List<int> result = new List<int>();
            int zero = 0;
            int one = 1;
            //int col = 0;
            //int row = 0;
            for (int row = 0; row < array.GetLength(0) / 2; row++)
            {
                for (int col = 0; col < array.GetLength(1) / 2; col++)
                {
                    if (array[array.GetLength(0) / 2, array.GetLength(1) / 2] == array[row, col])
                    {
                        if (array.GetLength(0) % 2 != 0)
                        {
                            result.Add(array[row, col]);
                        }
                        break;
                    }
                    while (col < array.GetLength(1) - zero)  
                    {
                        if (col == array.GetLength(1) - one) 
                        {
                            result.Add(array[row, col]);
                            while (row < array.GetLength(0) - zero)  
                            {
                                if (row == array.GetLength(0) - one)
                                {
                                    while (col != zero)
                                    {
                                        col--;
                                        result.Add(array[row, col]);
                                    }
                                    while (row != one)
                                    {
                                        row--;
                                        result.Add(array[row, col]);
                                    }

                                    break;
                                }
                                else
                                {
                                    row++;
                                    result.Add(array[row, col]);
                                }
                            }
                            break;
                        }
                        else
                        {
                            result.Add(array[row, col]);
                            col++;
                        }

                    }
                    zero++;
                    one++;

                }
                break;
            }
            return result.ToArray();
        }
    }
}
