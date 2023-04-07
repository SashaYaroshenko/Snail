using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnail
{
    internal class Class1
    {
        public static void ShowMatrix(int[,] mat, int[] num)
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

        public static void ShowMatrix(int[][] mat, int[] num)
        {
            int index = 0;
            string res = "";
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat[i].GetLength(0); j++) 
                {
                    mat[i][j] = num[index];
                    index++;
                    res = (mat[i][j].ToString()).PadLeft(2, ' ') + " ";
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }

        public static int[] RandomNum(int len)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            int[] rand = new int[len];
            for (int i = 0; i < len; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < len; i++)
            {
                int index = random.Next(0, len - i);
                rand[i] = list[index];
                list.Remove(list[index]);
            }
            return rand;
        }


    }
}
