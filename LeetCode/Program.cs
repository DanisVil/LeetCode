using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>() { 
                new List<int> { 1, 2, 3 }, 
                new List<int> { 4, 5, 6 }, 
                new List<int> { 7, 8, 9} };
            List<int> a = spiralOrder(matrix);
        }
        static IList<int> SpiralOrder(int[][] matrix)
        {
            List<List<int>> spiralMatrix = new List<List<int>>();
            foreach (int[] line in matrix)
            {
                List<int> listLine = new List<int>(line);
                spiralMatrix.Add(listLine);
            }
            return spiralOrder(spiralMatrix);
        }
        static List<int> spiralOrder(List<List<int>> matrix)
        {
            List<int> spiralMatrix = new List<int>();
            if (matrix.Count <= 1 || matrix[0].Count <= 1)
            {
                foreach (var line in matrix)
                {
                    foreach (int num in line) spiralMatrix.Add(num);
                }
                return spiralMatrix;
            }
            for (int i = 0; i < matrix[0].Count; i++) spiralMatrix.Add(matrix[0][i]);
            int lastIndex = matrix[0].Count - 1;
            for (int i = 1; i < matrix.Count; i++) spiralMatrix.Add(matrix[i][lastIndex]);
            lastIndex = matrix.Count - 1;
            for (int i = matrix[0].Count - 2; i >= 0; i--) spiralMatrix.Add(matrix[lastIndex][i]);
            for (int i = matrix.Count - 2; i > 0; i--) spiralMatrix.Add(matrix[i][0]);
            spiralMatrix.AddRange(spiralOrder(lowerMatrix(matrix)));
            return spiralMatrix;
        }
        static List<List<int>> lowerMatrix(List<List<int>> matrix)
        {
            matrix.RemoveAt(matrix.Count - 1);
            matrix.RemoveAt(0);
            for (int i = 0; i < matrix.Count; i++)
            {
                matrix[i].RemoveAt(matrix[i].Count - 1);
                matrix[i].RemoveAt(0);
            }
            return matrix;
        }
    }
}
