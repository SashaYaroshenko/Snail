using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySnail
{
    internal class MatrixConventer
    {
        public static int[][] ConvertMatrix(int[,] matrix)
        {
            int lenRows = matrix.GetLength(0);
            int[][] result = new int[lenRows][];
            int lenCols = matrix.GetLength(1);
            for(int i = 0; i < lenRows; i++)
            {
                result[i] = new int[lenCols]; 
                for(int j = 0; j < lenCols; j++)
                {
                    result[i][j]=matrix[i,j];
                }
            }
            return result;
        }
    }
}
